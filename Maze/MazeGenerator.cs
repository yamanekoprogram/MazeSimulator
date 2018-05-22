using System;
using System.Collections.Generic;

namespace Maze {
    //--------------------------------
    //　　迷路の自動生成アルゴリズム
    //--------------------------------
    public static class MazeGenerator {

        //-----------------------------------
        // 棒倒し法で壁を生成するメソッド
        //-----------------------------------
        public static int[,] StabCollapse(int NodeNumber, int MazeWidth, int MazeHeight) {
            // 現在の探索ノード
            int targetNode;

            // 隣接リストを作成
            int[,] AdjacencyList = new int[NodeNumber, 4];

            // 隣接リストを初期化
            for (int i = 0; i < NodeNumber; i++) {
                for (int j = 0; j < 4; j++) {
                    AdjacencyList[i, j] = -1;
                }
            }

            // 乱数の設定
            int rnd;
            Random r = new Random((int)DateTime.Now.Ticks);

            // 壁のない空白の迷路を作成
            int currentID;
            for (int i = 0; i < MazeHeight; i++) {
                for (int j = 0; j < MazeWidth; j++) {
                    currentID = (MazeWidth * i) + j;
                    // 上，右，下，左方向に穴をあける．
                    if (!(currentID < MazeWidth)) AdjacencyList[currentID, 0] = currentID - MazeWidth;
                    if (!((currentID + 1) % MazeWidth == 0) && currentID < NodeNumber) AdjacencyList[currentID, 1] = currentID + 1;
                    if (!(currentID >= (NodeNumber - MazeWidth))) AdjacencyList[currentID, 2] = currentID + MazeWidth;
                    if (!(currentID % MazeWidth == 0)) AdjacencyList[currentID, 3] = currentID - 1;
                }
            }

            // 棒倒し開始
            for (int i = 0; i < MazeHeight - 1; i++) {
                for (int j = 0; j < MazeWidth - 1; j++) {
                    targetNode = (MazeWidth * i) + j;
                    bool Flag = true;   //ループ制御用フラグ

                    while (Flag) {
                        if (targetNode < MazeWidth) {
                            rnd = r.Next(4);    // 上下左右どの方向に倒すか．0:右 1:下 2:左 3:上
                        } else {
                            rnd = r.Next(3);    // 1行目以降は右下左の3方向
                        }
                        int temp = 0;
                        // 乱数値毎に棒を倒す
                        switch (rnd) {
                            case 0: // 右
                                if (AdjacencyList[targetNode + 1, 2] != -1) {
                                    temp = AdjacencyList[targetNode + 1, 2];
                                    AdjacencyList[targetNode + 1, 2] = -1;
                                    AdjacencyList[temp, 0] = -1;
                                    Flag = false;
                                }
                                break;
                            case 1: // 下
                                if (AdjacencyList[targetNode + MazeWidth, 1] != -1) {
                                    temp = AdjacencyList[targetNode + MazeWidth, 1];
                                    AdjacencyList[targetNode + MazeWidth, 1] = -1;
                                    AdjacencyList[temp, 3] = -1;
                                    Flag = false;
                                }
                                break;
                            case 2: // 左
                                if (AdjacencyList[targetNode, 2] != -1) {
                                    temp = AdjacencyList[targetNode, 2];
                                    AdjacencyList[targetNode, 2] = -1;
                                    AdjacencyList[temp, 0] = -1;
                                    Flag = false;
                                }
                                break;
                            case 3: // 上
                                if (AdjacencyList[targetNode, 1] != -1) {
                                    temp = AdjacencyList[targetNode, 1];
                                    AdjacencyList[targetNode, 1] = -1;
                                    AdjacencyList[temp, 3] = -1;
                                    Flag = false;
                                }
                                break;
                        }
                    }
                }
            }
            return AdjacencyList;
        }

        //-----------------------------------------
        // クラスタリング法で迷路を作成するメソッド
        //-----------------------------------------
        public static int[,] Clustering(int NodeNumber, int MazeWidth, int MazeHeight) {
            int temp;
            int[,] AdjacencyList = new int[NodeNumber, 4];  // 隣接リスト
            List<int> Open = new List<int>();             // 展開したノードを格納するスタック
            List<Node> MazeNode = new List<Node>();

            // 処理用の仮のノード作成
            for (int i = 0; i < MazeHeight; i++) {
                for (int j = 0; j < MazeWidth; j++) {
                    MazeNode.Add(new Node((i * MazeWidth) + j, j * SysCon.CellSize, i * SysCon.CellSize));
                }
            }
            // 隣接リストを初期化
            for (int i = 0; i < NodeNumber; i++) {
                for (int j = 0; j < 4; j++) {
                    AdjacencyList[i, j] = -1;
                }
            }
            // 乱数の設定
            int rnd;
            int targetNode; // クラスタリングするノード番号
            Random r = new Random((int)DateTime.Now.Ticks);

            while (!ClusterCheck(ref MazeNode)) {
                // ノードを設定
                targetNode = r.Next(NodeNumber);
                 
                // 上
                if (!(targetNode < MazeWidth)) {
                    if (MazeNode[targetNode - MazeWidth].ClusterID != MazeNode[targetNode].ClusterID) {
                        Open.Add(targetNode - MazeWidth);
                    }
                }
                // 右
                if (!((targetNode + 1) % MazeWidth == 0) && targetNode < NodeNumber) {
                    if (MazeNode[targetNode + 1].ClusterID != MazeNode[targetNode].ClusterID) {
                        Open.Add(targetNode + 1);
                    }
                }
                // 下
                if (!(targetNode >= (NodeNumber - MazeWidth))) {
                    if (MazeNode[targetNode + MazeWidth].ClusterID != MazeNode[targetNode].ClusterID) {
                        Open.Add(targetNode + MazeWidth);
                    }
                }
                // 左
                if (!(targetNode % MazeWidth == 0)) {
                    if (MazeNode[targetNode - 1].ClusterID != MazeNode[targetNode].ClusterID) {
                        Open.Add(targetNode - 1);
                    }
                }

                if (Open.Count > 0) {
                    rnd = r.Next(Open.Count);    // 壁を壊すノードを設定
                    temp = Open[rnd];
                    int tempid;
                    // クラスタリング
                    if (MazeNode[temp].ClusterID > MazeNode[targetNode].ClusterID) {
                        tempid = MazeNode[temp].ClusterID;
                        foreach (Node n in MazeNode) {
                            if (n.ClusterID == tempid) {
                                n.ClusterID = MazeNode[targetNode].ClusterID;
                            }
                        }
                    } else {
                        tempid = MazeNode[targetNode].ClusterID;
                        foreach (Node n in MazeNode) {
                            if (n.ClusterID == tempid) {
                                n.ClusterID = MazeNode[temp].ClusterID;
                            }
                        }
                    }

                    if (MazeNode[temp].X > MazeNode[targetNode].X) {         // 右
                        AdjacencyList[targetNode, 1] = temp;
                        AdjacencyList[temp, 3] = targetNode;
                    }
                    else if (MazeNode[temp].X < MazeNode[targetNode].X) {    // 左
                        AdjacencyList[targetNode, 3] = temp;
                        AdjacencyList[temp, 1] = targetNode;
                    }
                    else if (MazeNode[temp].Y < MazeNode[targetNode].Y) {    // 上
                        AdjacencyList[targetNode, 0] = temp;
                        AdjacencyList[temp, 2] = targetNode;
                    }
                    else if (MazeNode[Open[rnd]].Y > MazeNode[targetNode].Y) {    // 下
                        AdjacencyList[targetNode, 2] = temp;
                        AdjacencyList[temp, 0] = targetNode;
                    }
                }
                Open.Clear();

            }

            return AdjacencyList;
        }

        private static bool ClusterCheck(ref List<Node> MazeNode) {
            int temp = MazeNode[0].ClusterID;
            foreach(Node n in MazeNode) {
                if (n.ClusterID != temp) {
                    return false;
                }
            }
            return true;
        }

    }
}
