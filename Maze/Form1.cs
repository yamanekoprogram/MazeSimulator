using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace Maze {

    //-------------------------
    //     メインフォーム
    //-------------------------
    public partial class Form1 : Form {
        // 描画用
        Bitmap canvas;         // 描画するキャンパス
        Graphics g;            // 描画用グラフィクス
        Board maze;            // 生成する迷路
        int ComboFlag = 0;     // コンボボックス制御のために泣く泣く付け加えたフラグ．1の時はGenerateが呼び出されてる．
        ConsoleWindow Consolewindow;      // コンソールウィンドウ
        Stopwatch sw;                     // 処理時間計測用のストップウォッチ

        // コンストラクタ
        public Form1() {
            InitializeComponent();
            this.Focus();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;       // コンボボックスを編集できないようにする
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height); // 描画用のオブジェクトを作製
            g = Graphics.FromImage(canvas);                             // グラフィックに渡す
            pictureBox1.BackColor = Color.White;                        // 背景色を白にする
            sw = new Stopwatch();
            panel1.Controls.Add(pictureBox1);   // PanelのコントロールにPictureBoxを入れる
            Controls.Add(panel1);

        }

        //--------------------------------
        // Generateボタンクリックイベント
        //--------------------------------
        private void button1_Click(object sender, EventArgs e) {
            ComboFlag = 1;          // フラグ立て
            SysCon.OpenCount = 0;   // 展開ノードを0にリセット
            if (!迷路ToolStripMenuItem.Enabled) 迷路ToolStripMenuItem.Enabled = true;
            if (!button3.Enabled)   button3.Enabled     = true;
            if (!button2.Enabled)   button2.Enabled     = true;
            if (!comboBox1.Enabled) comboBox1.Enabled   = true;
            if (!textBox4.Enabled) textBox4.Enabled = true;
            if (!SaveToolStripMenuItem.Enabled) SaveToolStripMenuItem.Enabled = true;
            if (!Save2ToolStripMenuItem.Enabled) Save2ToolStripMenuItem.Enabled = true;

            bool flag   = true; // 入力チェック用フラグ

            // 入力が空ではないかチェック
            if (       textBox1.Text == string.Empty) {
                flag = false;
            } else if (textBox2.Text == string.Empty) {
                flag = false;
            } else if (textBox3.Text == string.Empty) {
                flag = false;
            }

            // 入力が空ならメソッドを抜ける
            if (!flag) {
                MessageBox.Show("値を入力してください．", "Error");
                return;
            }

            // 迷路設計の各値を取得
            int height = int.Parse(textBox1.Text);
            int width  = int.Parse(textBox2.Text);
            int size   = int.Parse(textBox3.Text);

            // 不正な値が無いかチェック
            if (width <= 0 || height <= 0 || size <= 2) {
                flag = false;
            }

            // 値が不正ならメソッドを抜ける
            if (flag == false) {
                MessageBox.Show("不正な値です．", "Error");
                return;
            }

            // コンソールにメッセージ出力
            textBox5.AppendText(string.Format("Generating...\r\n"));

            // 迷路のサイズが変わってなければリストを更新したりする
            if (maze != null) {
                if (height != maze.MHeight || width != maze.MWidth) {
                    // Start,Goalコンボボックスを設定
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    for (int i = 0; i < (height * width); i++) {    // ノード番号を追加
                        comboBox2.Items.Add(i);
                        comboBox3.Items.Add(i);
                    }
                    // コンボボックスの初期値を設定し，SysConに登録する
                    comboBox2.SelectedIndex = 0;
                    comboBox3.SelectedIndex = height * width - 1;
                    SysCon.StartNode = (int)comboBox2.SelectedItem;
                    SysCon.GoalNode  = (int)comboBox3.SelectedItem;
                }
            } else {    // mazeが生成されていない場合はリストの初期化を行う
                for (int i = 0; i < (height * width); i++) {    // ノード番号を追加
                    comboBox2.Items.Add(i);
                    comboBox3.Items.Add(i);
                }
                // コンボボックスの初期値を設定し，SysConに登録する
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = height * width - 1;
                SysCon.StartNode = (int)comboBox2.SelectedItem;
                SysCon.GoalNode  = (int)comboBox3.SelectedItem;
                // コンボボックスを活性化する
                if (!comboBox2.Enabled || !comboBox3.Enabled) {
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                }
            }

            // キャンパスを作成
            pictureBox1.Height = height * size + SysCon.ScreenAdj * 2;
            pictureBox1.Width = width * size + SysCon.ScreenAdj * 2;
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(canvas);
            g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height); // 画面クリア

            // ここから迷路設計
            SysCon.CellSize = size;               // サイズ変更
            maze = new Board(height, width, 1);   // 迷路を作成
            maze.CreateWall(g);                   // 壁を描画
            pictureBox1.Image = canvas;           // イメージを適用
            ShowMatrixMenu.Enabled = true;        // "隣接リストを表示"メニューを活性化
            隣接行列を表示ToolStripMenuItem.Enabled = true;        // "隣接行列を表示"メニューを活性化
            textBox5.AppendText(string.Format("Generated    {0}\tSize : {1} * {2}\tCellSize : {3}\r\n", comboBox4.Text, textBox1.Text, textBox2.Text, textBox3.Text));

            ComboFlag = 0;  // フラグをへし折る
            Invalidate();
        }
        
        //--------------------------------
        //  "NodeID"チェックボックス
        //--------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            SysCon.DrawNodeID = checkBox1.Checked;  // ノードIDを表示するか切り替える
            if (maze != null) { // 迷路が生成されていれば
                Graphics temp = g;
                g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height);　// 画面クリア
                maze.CreateWall(g);                     // 迷路を再描画
                pictureBox1.Image = canvas;             // 変更を反映
            } else {
                return;
            }
        }

        //--------------------------------
        //  "Search"ボタン
        //--------------------------------
        private void button2_Click(object sender, EventArgs e) {
            // 色々なUIを無効化
            button1.Enabled = false;
            button2.Enabled = false;
            迷路ToolStripMenuItem.Enabled = false;
            checkBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            ファイルToolStripMenuItem.Enabled = false;

            sw.Reset();
            if (maze != null) { // 迷路が生成されていれば
                Task.Run(() => {
                    textBox5.Focus();
                    g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height); // 画面クリア
                    maze.CreateWall(g);                         // 迷路を再描画
                    sw.Start();
                    maze.MazeSeach(comboBox1.SelectedIndex, g, ref pictureBox1); // 指定のモードで探索させる
                    sw.Stop();
                    pictureBox1.Image = canvas;                 // 変更を反映
                    // 展開ノード数と処理時間を表示
                    textBox5.AppendText(string.Format("Path Search\t{0}\tOpenCount : {1}\tTime : {2}\r\n", comboBox1.Text, SysCon.OpenCount.ToString(), sw.Elapsed));
                    textBox5.Invalidate();
                    // 無効化したUIを活性化する
                    button1.Enabled = true;
                    button2.Enabled = true;
                    迷路ToolStripMenuItem.Enabled = true;
                    checkBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    ファイルToolStripMenuItem.Enabled = true;
                });
            }
        }

        //---------------------------------
        //  "AutoSearch"ボタン
        //---------------------------------
        private void button3_Click(object sender, EventArgs e) {
            button3.Enabled = false;
            // 値が入力されていて，0よりも大きければ実行
            if (textBox4.Text != String.Empty) {
                if (int.Parse(textBox4.Text) > 0) {
                    Task.Run(() => {    // 並列処理させる．
                        AutomaticSearch Aseach = new AutomaticSearch(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox4.Text), ref textBox5);
                        Aseach.Run();
                        button3.Enabled = true;
                    });
                } else {
                    MessageBox.Show("不正な値です.", "Error");
                }
            }  else {
                MessageBox.Show("値を入力してください", "Error");
            }
        }

        //--------------------------------
        //  Staet,Goalコンボボックスの設定
        //--------------------------------
        // Start
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboFlag != 1) {
                g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height); // 画面クリア
                SysCon.StartNode = (int)comboBox2.SelectedItem;
                if (maze != null) {
                    maze.CreateWall(g);
                }
                pictureBox1.Image = canvas;           // イメージを適用
                textBox5.AppendText(string.Format("Changed StartNode\t{0}\r\n",SysCon.StartNode));
            }
        }
        // Goal
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {
            if (ComboFlag != 1) {
                g.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height); // 画面クリア
                SysCon.GoalNode = (int)comboBox3.SelectedItem;
                if (maze != null) {
                    maze.CreateWall(g);
                }
                pictureBox1.Image = canvas;           // イメージを適用
                textBox5.AppendText(string.Format("Changed GoalNode\t{0}\r\n", SysCon.GoalNode));
            }
        }

        //-------------------------------
        //  "迷路"メニュー
        //-------------------------------
        private void スタートを左上ゴールを右下に設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = maze.MHeight * maze.MWidth - 1;
        }
        private void スタートを左上ゴールを中央に設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            // 迷路のサイズによって中央の求め方にちょっと補正が要るので調整
            int temp;
            temp = (maze.MHeight * maze.MWidth) / 2;
            if (!(maze.MWidth % 2 != 0 && maze.MHeight % 2 != 0)) {
                if (!(maze.MWidth % 2 == 0 && maze.MHeight % 2 != 0)) {
                    temp += (maze.MWidth / 2);
                }
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = temp;
        }
        // スタート
        private void 左上ToolStripMenuItem1_Click(object sender, EventArgs e) {
            comboBox2.SelectedIndex = 0;
        }
        private void 右上ToolStripMenuItem3_Click(object sender, EventArgs e) {
            comboBox2.SelectedIndex = maze.MWidth - 1; ;
        }
        private void 左下ToolStripMenuItem2_Click(object sender, EventArgs e) {
            comboBox2.SelectedIndex = maze.MWidth * (maze.MHeight - 1); ;
        }
        private void 右下ToolStripMenuItem2_Click(object sender, EventArgs e) {
            comboBox2.SelectedIndex = maze.MHeight * maze.MWidth - 1;
        }
        private void 中央ToolStripMenuItem2_Click(object sender, EventArgs e) {
            // 迷路のサイズによって中央の求め方にちょっと補正が要るので調整
            int temp;
            temp = (maze.MHeight * maze.MWidth) / 2;
            if (!(maze.MWidth % 2 != 0 && maze.MHeight % 2 != 0)) {
                if (!(maze.MWidth % 2 == 0 && maze.MHeight % 2 != 0)) {
                    temp += (maze.MWidth / 2);
                }
            }
            comboBox2.SelectedIndex = temp;
        }
        // ゴール
        private void 左上ToolStripMenuItem_Click(object sender, EventArgs e) {
            comboBox3.SelectedIndex = 0;
        }
        private void 右上ToolStripMenuItem2_Click(object sender, EventArgs e) {
            comboBox3.SelectedIndex = maze.MWidth - 1;
        }
        private void 左下ToolStripMenuItem1_Click(object sender, EventArgs e) {
            comboBox3.SelectedIndex = maze.MWidth * (maze.MHeight - 1);
        }
        private void 右下ToolStripMenuItem1_Click(object sender, EventArgs e) {
            comboBox3.SelectedIndex = (maze.MHeight * maze.MWidth) - 1;
        }
        private void 中央ToolStripMenuItem1_Click(object sender, EventArgs e) {
            // 迷路のサイズによって中央の求め方にちょっと補正が要るので調整
            int temp;
            temp = (maze.MHeight * maze.MWidth) / 2;
            if (!(maze.MWidth % 2 != 0 && maze.MHeight % 2 != 0)) {
                if (!(maze.MWidth % 2 == 0 && maze.MHeight % 2 != 0)) {
                    temp += (maze.MWidth / 2);
                }
            }
            comboBox3.SelectedIndex = temp;
        }

        //--------------------------------
        //  "表示"メニュー
        //--------------------------------

        // "隣接リストを表示”
        private void ShowMatrixMenu_Click(object sender, EventArgs e) {
            ConsoleWindow cw = new ConsoleWindow(0);
            cw.Text = "AdjacencyList";
            cw.textBox1.AppendText("Now Printing...\r\n");
            cw.Show();  // ウィンドウに隣接リストを表示させる
            String buffer = System.String.Empty;
            Task.Run(() => {    // 並列処理させる．
                for (int i = 0; i < maze.AMatrix.GetLength(0); i++) {
                    buffer += string.Format("\r\n{0,5}:\t[", i);
                    for (int j = 0; j < 3; j++) {
                        if (maze.AMatrix[i, j] != -1) {
                            buffer += (string.Format("{0}\t,", maze.AMatrix[i, j]));
                        } else {
                            buffer += (string.Format("{0}\t,", ""));
                        }
                    }
                    if (maze.AMatrix[i, 3] != -1) {
                        buffer += (string.Format("{0}\t", maze.AMatrix[i, 3]));
                    } else {
                        buffer += (string.Format("{0}\t", ""));
                    }
                    buffer += "]";
                }
                cw.textBox1.Text = buffer;
            });
        }

        // "隣接行列を表示”
        private void 隣接行列を表示ToolStripMenuItem_Click(object sender, EventArgs e) {

            List<int> temp = new List<int>();
            ConsoleWindow cw = new ConsoleWindow(1);
            cw.Text = "AdjacencyMatrix";
            cw.Show();
            cw.textBox1.AppendText("Now Printing...\r\n");

            String buffer = System.String.Empty;
            Task.Run(() => {    // 並列処理させる．
                // 隣接リストを読み取り，隣接行列へ変換する
                for (int i = 0; i < maze.AMatrix.GetLength(0); i++) {
                    for (int j = 0; j < 4; j++) {
                        if (maze.AMatrix[i, j] != -1) {
                            temp.Add(maze.AMatrix[i, j]);
                        }
                    }
                    for (int k = 0; k < maze.AMatrix.GetLength(0); k++) {
                        if (temp.Exists(x => x == k)) {
                            buffer += "1";
                        } else {
                            buffer += "0";
                        }
                    }
                    buffer += string.Format("\r\n");
                    temp.Clear();
                }
                cw.textBox1.Text = buffer;
            });
        }

        //------------------------
        //   コンソール操作系
        //------------------------

        // "セパレート"
        private void button4_Click(object sender, EventArgs e) {
            Consolewindow = new ConsoleWindow(2);
            Consolewindow.Width = 450;
            Consolewindow.textBox1.Text = this.textBox5.Text;
            Consolewindow.textBox1.Select(0, 0);
            Consolewindow.Show();

        }
        // "ログクリア"
        private void button5_Click(object sender, EventArgs e) {
            textBox5.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            if (Consolewindow != null) {
                    Consolewindow.textBox1.Text = this.textBox5.Text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            SysCon.Animation = this.checkBox2.Checked;
        }

        //-----------------------
        //      トラックバー
        //-----------------------
        private void trackBar1_Scroll(object sender, EventArgs e) {
            SysCon.AnimationFlame = (trackBar1.Maximum - trackBar1.Value) * 10;
            label12.Text = "AnimationSpeed : " + trackBar1.Value.ToString();
            //textBox5.AppendText(string.Format("Animation Speed\t{0}\r\n", SysCon.AnimationFlame));
         }

        //-----------------------
        //  迷路生成アルゴリズム
        //-----------------------
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e) {
            SysCon.GenerateMode = comboBox4.SelectedIndex;
        }

        private void 通常の設定で探索するToolStripMenuItem_Click(object sender, EventArgs e) {
            SysCon.Heuristic = 1;
        }

        private void ヒューリスティック値を大きくするToolStripMenuItem1_Click(object sender, EventArgs e) {
            SysCon.Heuristic = 100;
        }

        //------------------------
        //  迷路の保存
        //------------------------
        private void 迷路をイメージとして保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            Graphics tempg;
            Bitmap tempcanvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            tempg = Graphics.FromImage(tempcanvas);

            tempg.FillRectangle(Brushes.White, 0, 0, pictureBox1.Width, pictureBox1.Height); // 画面クリア
            tempg = Graphics.FromImage(tempcanvas);                         // グラフィックに渡す
            maze.CreateWall(tempg);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "maze.png";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            sfd.Filter = "pngファイル(*.png)|*.png|jpegファイル(*.jpg)|*.jpg|bitmapファイル(*.bmp)|*.bmp";
            sfd.FilterIndex = 1;
            sfd.Title = "迷路の保存先";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK) {
                switch (sfd.FilterIndex) {
                    case 1:
                        tempcanvas.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 2:
                        tempcanvas.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        tempcanvas.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
            tempg.Dispose();
            tempcanvas.Dispose();
        }

        private void 現在の迷路の状態をイメージとして保存ToolStripMenuItem_Click(object sender, EventArgs e) {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "maze.png";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            sfd.Filter = "pngファイル(*.png)|*.png|jpegファイル(*.jpg)|*.jpg|bitmapファイル(*.bmp)|*.bmp";
            sfd.FilterIndex = 1;
            sfd.Title = "迷路の保存先";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK) {
                switch (sfd.FilterIndex) {
                    case 1:
                        canvas.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 2:
                        canvas.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        canvas.Save(sfd.OpenFile(), System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }

        }
    }
}
