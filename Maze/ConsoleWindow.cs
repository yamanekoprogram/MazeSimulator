using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze {
    public partial class ConsoleWindow : Form {
        int id; // ウィンドウの識別番号 0:隣接リスト 1:隣接行列 2:コンソール
        public ConsoleWindow(int id) {
            InitializeComponent();
            this.id = id;
        }
        
        public int ID {
            set { id = value; }
            get { return id;  }
        }
    }
}
