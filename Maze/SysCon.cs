using System.Drawing;

namespace Maze {
    //-------------------------
    //　定数を纏めた静的クラス
    //-------------------------
    public static class SysCon {
        private static int  cellsize = 20;        // 1マスのサイズ
        private static int  screenadj = 2;        // 画面調整
        private static bool drawnodeid = true;    // ノードIDを表示するか
        private static int  startnode = 0;        // スタートノード
        private static int  goalnode  = 99;       // ゴールノード
        private static int  opencount = 0;        // 展開ノード数
        private static bool animation = true;     // アニメーションするかどうか
        private static int  animationflame = 50;  // アニメーションの描画感覚(ms)
        private static int  generatemode = 0;     // 生成アルゴリズム 0:棒倒し 1:クラスタリング
        private static double heuristic = 1;      // ヒューリスティック値の係数
        
        // プロパティ設定
        public static int CellSize {
            set { cellsize = value; }
            get { return cellsize;  }
        }
        public static int ScreenAdj {
            set { screenadj = value; }
            get { return screenadj;  }
        }
        public static bool DrawNodeID {
            set { drawnodeid = value; }
            get { return drawnodeid;  }
        }
        public static int StartNode {
            set { startnode = value; }
            get { return startnode;  }
        }
        public static int GoalNode {
            set { goalnode = value; }
            get { return goalnode;  }
        }
        public static int OpenCount {
            set { opencount = value; }
            get { return opencount; }
        }
        public static bool Animation {
            set { animation = value; }
            get { return animation; }
        }
        public static int AnimationFlame {
            set { animationflame = value; }
            get { return animationflame; }
        }
        public static int GenerateMode {
            set { generatemode = value; }
            get { return generatemode; }
        }
        public static double Heuristic {
            set { heuristic = value; }
            get { return heuristic;  }
        }
    }
}
