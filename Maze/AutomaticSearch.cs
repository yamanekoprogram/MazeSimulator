using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Maze {
    //----------------------------
    // 自動探索クラス
    //----------------------------
    class AutomaticSearch {
        Searcher sc;
        int ExecutionTimes; // 実行回数
        int[,] AMatrix;
        int MazeHeight;
        int MazeWidth;
        List<Node> MazeNode = new List<Node>();
        TextBox MazeConsole;

        //---------------------------
        //      コンストラクタ
        //---------------------------
        public AutomaticSearch(int Height, int Width, int ExecutionTimes, ref TextBox MazeConsole) {
            this.ExecutionTimes = ExecutionTimes;
            int[,] AMatrix = new int[Height * Width, 4];
            MazeHeight = Height;
            MazeWidth  = Width;
            this.MazeConsole = MazeConsole;
            
            // ノードを生成
            int id = 0;
            for (int i = 0; i < MazeHeight; i++) {
                for (int j = 0; j < MazeWidth; j++) {
                    // リストに生成したノードを格納
                    MazeNode.Add(new Node(id++, j * SysCon.CellSize, i * SysCon.CellSize));
                }
            }

            // 隣接行列の生成
            AMatrix = MazeGenerator.StabCollapse(MazeNode.Count, MazeWidth, MazeHeight);
            sc = new Searcher(ref MazeNode, AMatrix, 1);
        }

        //-------------------------
        //     実行メソッド
        //-------------------------
        public void Run() {
            // ラベルの表示
            Stopwatch sw = new Stopwatch();
            MazeConsole.AppendText(String.Format("\r\n---- {0}*{1} ----\r\n", MazeHeight, MazeWidth));
            MazeConsole.AppendText(String.Format("Take\tBreadth\tDepth\tA*\tWinner\r\n"));
            MazeConsole.AppendText(String.Format("-------------------------------------------\r\n"));


            int        top;        // 現在の最小展開ノード数
            int        flag = 0;   // どの探索が優秀だったか判断するためのフラグ
            int[]      winnumber  = new int[3];          // 勝利数
            double[]   average    = new double[3];       // 平均展開ノード数
            long[]     extime     = new long[3];     // 各Take各アルゴリズム毎の合計Ticks
            long[]     avgtime    = new long[3];     // 各アルゴリズムの平均Ticks
            TimeSpan[] time = new TimeSpan[3];

            for (int i = 1; i <= ExecutionTimes; i++) {
                // 迷路を新たに作成
                switch (SysCon.GenerateMode) {
                    case 0:
                        AMatrix = MazeGenerator.StabCollapse(MazeNode.Count, MazeWidth, MazeHeight);
                        break;
                    case 1:
                        AMatrix = MazeGenerator.Clustering(MazeNode.Count, MazeWidth, MazeHeight);
                        break;
                }

                sc = new Searcher(ref MazeNode, AMatrix, 1);

                // 各探索を実行しながら結果を表示する
                MazeConsole.AppendText(string.Format("Take:{0}\t", i));

                // 幅優先
                sw.Reset();
                sw.Start();
                sc.Breadth();
                sw.Stop();
                extime[0] += sw.ElapsedTicks;
                MazeConsole.AppendText(string.Format("{0}\t", SysCon.OpenCount));
                top = SysCon.OpenCount;
                average[0] += SysCon.OpenCount;

                // 深さ優先
                sw.Reset();
                sw.Start();
                sc.Depth();
                sw.Stop();
                extime[1] += sw.ElapsedTicks;
                MazeConsole.AppendText(string.Format("{0}\t", SysCon.OpenCount));
                
                if (SysCon.OpenCount < top) {
                    top = SysCon.OpenCount;
                    flag = 1;
                }
                average[1] += SysCon.OpenCount;

                //　A*
                sw.Reset();
                sw.Start();
                sc.Astar();
                sw.Stop();
                extime[2] += sw.ElapsedTicks;
                MazeConsole.AppendText(string.Format("{0}\t", SysCon.OpenCount));

                if (SysCon.OpenCount < top) {
                    top = SysCon.OpenCount;
                    flag = 2;
                }
                average[2] += SysCon.OpenCount;

                // 優秀だった探索法を表示する
                switch (flag) {
                    case 0:
                        MazeConsole.AppendText("Breadth\r\n");
                        winnumber[0]++;
                        break;
                    case 1:
                        MazeConsole.AppendText("Depth\r\n");
                        winnumber[1]++;
                        break;
                    case 2:
                        MazeConsole.AppendText("A*\r\n");
                        winnumber[2]++;
                        break;
                }
            }
            // 平均値計算
            for (int i = 0; i < 3; i++) {
                average[i] = average[i] / ExecutionTimes;
                avgtime[i] = extime[i] /  ExecutionTimes;
                time[i] = new TimeSpan(avgtime[i]);
            }
            
            MazeConsole.AppendText(string.Format("\r\nMethod\tWin\tAverage\tRate\tTime\r\n"));
            MazeConsole.AppendText(string.Format("-------------------------------------------------\r\n"));
            MazeConsole.AppendText(string.Format("Breadth\t{0}\t{1}\t{2}%\t{3}\r\n",winnumber[0], average[0].ToString("F1"), ((average[0] / MazeNode.Count) * 100.0).ToString("F1"), time[0]));
            MazeConsole.AppendText(string.Format("Depth\t{0}\t{1}\t{2}%\t{3}\r\n",  winnumber[1], average[1].ToString("F1"), ((average[1] / MazeNode.Count) * 100.0).ToString("F1"), time[1]));
            MazeConsole.AppendText(string.Format("A*\t{0}\t{1}\t{2}%\t{3}\r\n",     winnumber[2], average[2].ToString("F1"), ((average[2] / MazeNode.Count) * 100.0).ToString("F1"), time[2]));
        }
    }
}
