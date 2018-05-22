using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Maze {
    //--------------------------
    //    探索を行うクラス
    //--------------------------
    class Searcher {
        int[,] AMatrix;
        List<Node> MazeNode;
        List<Node> ClosedList;
        int opencount; // 展開ノード数
        int mode;      // 探索モード 0:通常 1:自動探索(余計な描画なし)
        PictureBox pictureBox1;
        
        //--------------------------
        //    コンストラクタ
        //--------------------------
        public Searcher(ref List<Node> MazeNode, int[,] AMatrix, int mode, ref PictureBox pictureBox1) {
            this.AMatrix = AMatrix;
            this.MazeNode = MazeNode;
            opencount = 0;
            this.mode = mode;
            this.pictureBox1 = pictureBox1;
        }

        //--------------------------
        //    深さ優先探索
        //--------------------------
        public void Depth(Graphics g) {
            opencount = 0;  // 展開ノード数をリセット
            Pen p = new Pen(Color.Blue, 1);
            Stack<Node> OpenList  = new Stack<Node>();
            ClosedList  = new List<Node>();
            Node CurrentNode;
            OpenList.Push(MazeNode[SysCon.StartNode]);  // スタートノードをOPENへ
            Node temp = MazeNode[SysCon.StartNode];

            // OPENLISTからノードを取り出す
            while (OpenList.Count > 0) {
                CurrentNode = OpenList.Pop();
                opencount++; // 展開ノード数を記録
                int x1 = CurrentNode.X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int y1 = CurrentNode.Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int x2 = MazeNode[CurrentNode.ParentID].X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int y2 = MazeNode[CurrentNode.ParentID].Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                // 描画処理
                if (mode == 0) {    // 通常探索の場合は経路を描画する
                    g.DrawLine(p, x1, y1, x2, y2);
                    if (SysCon.Animation) {
                        System.Threading.Thread.Sleep(SysCon.AnimationFlame);
                        pictureBox1.Refresh();
                    }
                }
                // ゴールなら経路を表示して終了
                if (CurrentNode.NodeID == SysCon.GoalNode) {
                    SysCon.OpenCount = opencount;
                    if (mode == 0) showResult(CurrentNode, g);
                    break;
                }
                // ノードを展開
                for (int i = 0; i < 4; i++) {
                    if (AMatrix[CurrentNode.NodeID, i] != -1 && isInClosed(MazeNode[AMatrix[CurrentNode.NodeID, i]].NodeID) == -1) {
                        OpenList.Push(MazeNode[AMatrix[CurrentNode.NodeID, i]]);
                        MazeNode[AMatrix[CurrentNode.NodeID, i]].ParentID = CurrentNode.NodeID;
                    }
                }
                ClosedList.Add(CurrentNode);
            }
            p.Dispose();
        }

        //--------------------------
        //    幅優先探索
        //--------------------------
        public void Breadth(Graphics g) {
            opencount = 0;  // 展開ノード数をリセット

            Queue<Node> OpenList = new Queue<Node>();
            ClosedList = new List<Node>();
            Node CurrentNode;
            OpenList.Enqueue(MazeNode[SysCon.StartNode]);  // スタートノードをOPENへ
            Pen p = new Pen(Color.Blue, 1);

            // OPENLISTからノードを取り出す
            while (OpenList.Count > 0) {
                CurrentNode = OpenList.Dequeue();
                opencount++; // 展開ノード数を記録
                int x1 = CurrentNode.X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int y1 = CurrentNode.Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int x2 = MazeNode[CurrentNode.ParentID].X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int y2 = MazeNode[CurrentNode.ParentID].Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                // 描画処理
                if (mode == 0) { // 通常探索の場合は経路を描画する
                    g.DrawLine(p, x1, y1, x2, y2);
                    if (SysCon.Animation) {
                        System.Threading.Thread.Sleep(SysCon.AnimationFlame);
                        pictureBox1.Refresh();
                    }
                }

                // ゴールなら経路を表示して終了
                if (CurrentNode.NodeID == SysCon.GoalNode) {
                    SysCon.OpenCount = opencount;
                    if (mode == 0) showResult(CurrentNode, g);
                    break;
                }
                // ノードを展開
                for (int i = 0; i < 4; i++) {
                    if (AMatrix[CurrentNode.NodeID, i] != -1 && isInClosed(MazeNode[AMatrix[CurrentNode.NodeID, i]].NodeID) == -1) {
                        OpenList.Enqueue(MazeNode[AMatrix[CurrentNode.NodeID, i]]);
                        MazeNode[AMatrix[CurrentNode.NodeID, i]].ParentID = CurrentNode.NodeID;
                    }
                }
                ClosedList.Add(CurrentNode);
            }
            p.Dispose();
        }

        //--------------------------
        //    A*アルゴリズム
        //--------------------------
        public void Astar(Graphics g) {
            
            opencount = 0;  // 展開ノード数をリセット
            List<Node> OpenList = new List<Node>();
            ClosedList = new List<Node>();
            Node CurrentNode;
            // 初期位置のスコアを設定
            MazeNode[SysCon.StartNode].Score = heuristic(MazeNode[SysCon.StartNode]);
            OpenList.Add(MazeNode[SysCon.StartNode]);  // スタートノードをOPENへ
            Pen p = new Pen(Color.Blue, 1);

            // OPENLISTからノードを取り出す
            while (OpenList.Count > 0) {
                CurrentNode = OpenList[0];  // Openリストの先頭を取り出す
                OpenList.RemoveAt(0);       // 取り出したデータを削除
                opencount++; // 展開ノード数を記録
                ClosedList.Add(CurrentNode);

                int x1 = CurrentNode.X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int y1 = CurrentNode.Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int x2 = MazeNode[CurrentNode.ParentID].X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                int y2 = MazeNode[CurrentNode.ParentID].Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
                // 描画処理
                if (mode == 0) { // 通常探索の場合は経路を描画する
                    g.DrawLine(p, x1, y1, x2, y2);
                    if (SysCon.Animation) {
                        System.Threading.Thread.Sleep(SysCon.AnimationFlame);
                        pictureBox1.Refresh();
                    }
                }
                // ゴールノードなら結果を表示して終了
                if (CurrentNode.NodeID == SysCon.GoalNode) {
                    SysCon.OpenCount = opencount;
                    if (mode == 0) showResult(CurrentNode, g);
                    break;
                }

                // 隣接リストから子ノードを展開
                int target;
                for (int i = 0; i < 4; i++) {
                    target = AMatrix[CurrentNode.NodeID, i];
                    if (target != -1 && target != SysCon.StartNode) {
                        if (MazeNode[target].Cost == 0 || MazeNode[target].Cost > (CurrentNode.Cost + 1)) {
                            MazeNode[target].Cost = CurrentNode.Cost + 1;    // 子ノードに実コストを設定
                            MazeNode[target].Heuristic = heuristic(MazeNode[target]);    // 子ノードに推定コストを設定
                            MazeNode[target].Score = MazeNode[target].Cost + MazeNode[target].Heuristic;  // 評価関数を加えたスコアを設定
                        }
                        int n1 = isInOpen(ref OpenList, target);
                        int n2 = isInClosed(target);
                        
                        // OpenListにもClosedListにも含まれていない場合
                        if (n1 == -1 && n2 == -1) {
                            MazeNode[target].ParentID = CurrentNode.NodeID;  // 子ノードに親ノードを設定
                            OpenList.Add(MazeNode[target]);  // OpenListに加える
                        // ClosedListに含まれている場合
                        } else if (n2 >= 0 && ClosedList[n2].Score > MazeNode[target].Score) {
                            // スコアを更新してCloseListからOpenListへ移動
                            ClosedList[n2].Score = MazeNode[target].Score;
                            ClosedList[n2].ParentID = CurrentNode.NodeID;
                            OpenList.Add(ClosedList[n2]);
                            ClosedList.RemoveAt(n2);
                        // OpenListに含まれている場合
                        } else if (n1 >= 0 && OpenList[n1].Score > MazeNode[target].Score) {
                            OpenList[n1].Score = MazeNode[target].Score;
                            OpenList[n1].ParentID = CurrentNode.NodeID;
                        }
                    }
                }
                SortList(ref OpenList);
            }
            p.Dispose();
        }

        //--------------------------
        //  ヒューリスティック関数
        //--------------------------
        // なぜか右下辺りのヒューリスティックが狂う
        // どうやら右下がゴールノードになったまま
        // ヒューリスティック関数を計算して渡しちゃうことがあるっぽい
        //-----------------------------------------------------------------
        private double heuristic(Node targetNode) {
            // ゴールノードとの距離で評価
            double h1 = Math.Abs(MazeNode[SysCon.GoalNode].MazeX - targetNode.MazeX);
            double h2 = Math.Abs(MazeNode[SysCon.GoalNode].MazeY - targetNode.MazeY);
            double h3 = Math.Sqrt((h1 * h1) + (h2 * h2));
            //double h3 = h1 + h2;
            // Console.WriteLine(h3);
            return (h3 * SysCon.Heuristic);
        }

        //----------------------
        //     結果の表示
        //----------------------
        private void showResult(Node CurrentNode, Graphics g) {
            Pen p = new Pen(Color.Red, 2);
            if (CurrentNode.NodeID != SysCon.StartNode) {
                showResult(MazeNode[CurrentNode.ParentID], g);
            }
            int x1 = CurrentNode.X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
            int y1 = CurrentNode.Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
            int x2 = MazeNode[CurrentNode.ParentID].X + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
            int y2 = MazeNode[CurrentNode.ParentID].Y + (SysCon.CellSize / 2) + SysCon.ScreenAdj;
            // 描画処理
            if (mode == 0) { // 通常探索の場合は経路を描画する
                g.DrawLine(p, x1, y1, x2, y2);
                if (SysCon.Animation) {
                    System.Threading.Thread.Sleep(SysCon.AnimationFlame);
                    pictureBox1.Refresh();
                }
            }
            //Console.Write("{0}->", CurrentNode.NodeID);
        }


        //----------------------------------
        // ClosedListに指定のノードがあるか
        //----------------------------------
        private int isInClosed(int nodeid) {
            for (int i = 0; i < ClosedList.Count; i++) {
                if (ClosedList[i].NodeID == nodeid) {
                    return i;
                }
            }
            return -1;
        }

        //----------------------------------
        // OpenListに指定のノードがあるか
        //----------------------------------
        private int isInOpen(ref List<Node>OpenList, int nodeid) {
            for (int i = 0; i < OpenList.Count; i++) {
                if (OpenList[i].NodeID == nodeid) {
                    return i;
                }
            }
            return -1;
        }

        //----------------------------------
        //  ソート関数
        //----------------------------------
        private void SortList(ref List<Node> list) {
            // バブルソート(計算量上非推奨)
            Node temp;
            for (int i = 0; i < list.Count - 1; i++) {
                for(int j = 0; j < list.Count - 1 - i; j++) {
                    if (list[j].Score >= list[j + 1].Score) {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        //-------------------------------
        //     オーバーロード(AutoSeach用)
        //-------------------------------

        // ダミーのグラフィックを渡して実行する
        public Searcher(ref List<Node> MazeNode, int[,] AMatrix, int mode) {
            
            this.AMatrix = AMatrix;
            this.MazeNode = MazeNode;
            opencount = 0;
            this.mode = mode;
        }
        public void Depth() {
            Bitmap dummy = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(dummy);
            Depth(g);
            g.Dispose();
        }
        public void Breadth() {
            Bitmap dummy = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(dummy);
            Breadth(g);
            g.Dispose();
        }
        public void Astar() {
            Bitmap dummy = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(dummy);
            Astar(g);
            g.Dispose();
        }
    }
}