using System;

namespace Maze {
    //-------------------------
    // 　ノード単体のクラス
    //-------------------------
    class Node {
        private int nodeID;     // ノード番号
        private int x;          // ノードのx座標
        private int y;          // ノードのy座標
        private int mazex;      // 迷路上でのx座標(マス単位)
        private int mazey;      // 迷路上でのy座標(マス単位)
        private int parentID;   // 親ノードID
        private int cost;       // コスト
        private double heuristic;  // ヒューリスティック
        private double score;      // コストとヒューリスティックの合算
        private int clusterid;  // クラスタ番号 チェック済みの場合は1 

        //----------------------
        //    コンストラクタ
        //----------------------
        public Node(int id, int argx, int argy) {
            // 引数から各値を設定
            nodeID = id;
            parentID = id;
            cost = 0;
            score = 0;
            x = argx;
            y = argy;
            mazex = x / SysCon.CellSize;
            mazey = y / SysCon.CellSize;
            clusterid = nodeID;

            //Console.WriteLine("Node{0}({1}, {2}):Created.", nodeID, mazex, mazey);
        }

        //-------------------------
        // 　プロパティ設定
        //-------------------------
        public int X {
            set { x = value; }
            get { return x;  }
        }
        public int Y {
            set { y = value; }
            get { return y;  }
        }
        public int MazeX {
            set { mazex = value; }
            get { return mazex; }
        }
        public int MazeY {
            set { mazey = value; }
            get { return mazey; }
        }
        public int NodeID {
            set { nodeID = value; }
            get { return nodeID;  }
        }
        public int ParentID {
            set { parentID = value; }
            get { return parentID;  }
        }
        public int Cost {
            set { cost = value; }
            get { return cost;  }
        }
        public double Heuristic {
            set { heuristic = value; }
            get { return heuristic; }
        }
        public double Score {
            set { score = value; }
            get { return score; }
        }
        public int ClusterID {
            set { clusterid = value; }
            get { return clusterid; }
        }
    }
}
