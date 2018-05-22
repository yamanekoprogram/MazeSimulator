using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Maze {
    //-------------------------
    // 迷路全体を管理するクラス
    //-------------------------
    public class Board {
        int MazeHeight;            // 迷路の縦列数
        int MazeWidth;             // 迷路の横列数
        int NodeNumber;            // 全体のノード数
        List<Node> MazeNode;       // 全体のノードを格納するリスト
        int[,] AdjacencyList;      // 隣接リスト
        int GenerateMode;          // 迷路の生成モード 1:棒倒し法

        //_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
        //
        //　隣接リストは[NodeID,{上隣接，右隣接，下隣接，左隣接}]の構造
        //________________________________________________________________
        // / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / / /

        //----------------------
        //    コンストラクタ
        //----------------------
        public Board(int height, int width, int mode) {
            // 引数から迷路のサイズを決定する
            MazeHeight = height;
            MazeWidth = width;
            NodeNumber = MazeHeight * MazeWidth;
            MazeNode = new List<Node>();
            GenerateMode = mode;

            // 隣接リスト
            AdjacencyList = new int[NodeNumber, 4];

            // ノードを作成
            int id = 0;
            for (int i = 0; i < MazeHeight; i++) {
                for (int j = 0; j < MazeWidth; j++) {
                    // リストに生成したノードを格納
                    MazeNode.Add(new Node(id++, j * SysCon.CellSize, i * SysCon.CellSize));
                }
            }
            // 隣接リストの生成
            switch (SysCon.GenerateMode) {
                case 0:
                    AdjacencyList = MazeGenerator.StabCollapse(NodeNumber, MazeWidth, MazeHeight);
                    break;
                case 1:
                    AdjacencyList = MazeGenerator.Clustering(NodeNumber, MazeWidth, MazeHeight);
                    break;
            }
        }

        //--------------------------
        //   壁を描画するメソッド
        //--------------------------
        public void CreateWall(Graphics g) {
            // グラフィック関連
            Pen p = new Pen(Color.Black, 2);            // 描画用のペン
            Font fnt = new Font("MS UI Gothic", SysCon.CellSize / 3);    // ノード番号表示用のフォント
            int size = SysCon.CellSize;                 // 1マス分のサイズ
            // 描画に使うための変数
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            // StartとGoalを描画
            x1 = MazeNode[SysCon.StartNode].X + SysCon.ScreenAdj;
            y1 = MazeNode[SysCon.StartNode].Y + SysCon.ScreenAdj;
            x2 = SysCon.CellSize;
            y2 = SysCon.CellSize;
            g.FillRectangle(Brushes.Blue, x1, y1, x2, y2);
            x1 = MazeNode[SysCon.GoalNode].X + SysCon.ScreenAdj;
            y1 = MazeNode[SysCon.GoalNode].Y + SysCon.ScreenAdj;
            x2 = SysCon.CellSize;
            y2 = SysCon.CellSize;
            g.FillRectangle(Brushes.Red, x1, y1, x2, y2);

            // リストからノードを取り出す
            foreach (Node current in MazeNode) {
                p.Color = Color.Black;  // ペン色を黒に
                // ノード番号と枠を描画する ScreenAdjは補正
                if (SysCon.DrawNodeID) {
                    g.DrawString(current.NodeID.ToString(), fnt, Brushes.Black, current.X + SysCon.ScreenAdj, current.Y + SysCon.ScreenAdj);
                }
                g.DrawRectangle(p, current.X + SysCon.ScreenAdj, current.Y + SysCon.ScreenAdj, size, size);
            }

            foreach (Node current in MazeNode) {
                p.Color = Color.White;  // ペン色を白に
                // 隣接行列を読み取り，壁を取る
                for (int i = 0; i < 4; i++) {
                    if (AdjacencyList[current.NodeID, i] != -1) {
                        // 対象のノードがどの方向にあるか調べてラインを引く座標を設定．
                        if (i == 1) { //右側
                            x1 = current.X + size + SysCon.ScreenAdj;
                            y1 = current.Y + SysCon.ScreenAdj + 1;
                            x2 = current.X + size + SysCon.ScreenAdj;
                            y2 = current.Y + size + SysCon.ScreenAdj - 1;
                        } else
                        if (i == 3) { //左側
                            x1 = current.X + SysCon.ScreenAdj;
                            y1 = current.Y + SysCon.ScreenAdj + 1;
                            x2 = current.X + SysCon.ScreenAdj;
                            y2 = current.Y + size + SysCon.ScreenAdj - 1;
                        } else
                        if (i == 0) { //上側
                            x1 = current.X + SysCon.ScreenAdj + 1;
                            y1 = current.Y + SysCon.ScreenAdj;
                            x2 = current.X + size + SysCon.ScreenAdj - 1;
                            y2 = current.Y + SysCon.ScreenAdj;
                        } else
                        if (i == 2) { //下側
                            x1 = current.X + SysCon.ScreenAdj + 1;
                            y1 = current.Y + size + SysCon.ScreenAdj;
                            x2 = current.X + size + SysCon.ScreenAdj - 1;
                            y2 = current.Y + size + SysCon.ScreenAdj;
                        }

                        //壁を背景色で上書きして壊す
                        g.DrawLine(p, x1, y1, x2, y2);
                    }
                }
            }

            p.Dispose();
        }

        //--------------------------
        //  経路探索メソッド
        //--------------------------
        public void MazeSeach(int mode, Graphics g, ref PictureBox pictureBox1) {
            Searcher sc = new Searcher(ref MazeNode, AdjacencyList, 0, ref pictureBox1);
                switch (mode) {
                    case 0:
                        Console.WriteLine("Breadth");
                        sc.Breadth(g);
                        break;
                    case 1:
                        Console.WriteLine("Depth");
                        sc.Depth(g);
                        break;
                    case 2:
                        Console.WriteLine("A*");
                        sc.Astar(g);
                        break;
                }

            //// debug--
            //Console.WriteLine("Cost");
            //for (int i = 0; i < MazeHeight; i++) {
            //    for (int j = 0; j < MazeWidth; j++) {
            //        Console.Write("{0,3},", MazeNode[(MazeHeight * i) + j].Cost);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Heuristic");
            //for (int i = 0; i < MazeHeight; i++) {
            //    for (int j = 0; j < MazeWidth; j++) {
            //        Console.Write("{0,3},", (int)MazeNode[(MazeHeight * i) + j].Heuristic);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Score");
            //for (int i = 0; i < MazeHeight; i++) {
            //    for (int j = 0; j < MazeWidth; j++) {
            //        Console.Write("{0,3},", (int)MazeNode[(MazeHeight * i) + j].Score);
            //    }
            //    Console.WriteLine();
            //}
            ////debug--
        }

        // プロパティ設定
        public int[,] AMatrix {
            set { AdjacencyList = value; }
            get { return AdjacencyList; }
        }
        public int MHeight {
            set { MazeHeight = value; }
            get { return MazeHeight; }
        }
        public int MWidth {
            set { MazeWidth = value; }
            get { return MazeWidth; }
        }

    }
}
