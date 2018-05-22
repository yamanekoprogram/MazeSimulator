namespace Maze {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMatrixMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.隣接行列を表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.迷路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタート位置の設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左上ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.右上ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.左下ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.右下ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.中央ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ゴール位置の設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.左上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右上ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.左下ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.右下ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.中央ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートを右上ゴールを左下に設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートを左上ゴールを右下に設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スタートを左上ゴールを中央に設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aアルゴリズムの設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通常の設定で探索するToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヒューリスティック値を大きくするToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ゴールを真ん中にするToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.右上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右上ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.左下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.右下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中央ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(737, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Height";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(735, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(793, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "10";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(793, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 19);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "10";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "CellSize";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(793, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 19);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "20";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.toolStripMenuItem1,
            this.迷路ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.Save2ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowMatrixMenu,
            this.隣接行列を表示ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "表示";
            // 
            // ShowMatrixMenu
            // 
            this.ShowMatrixMenu.Enabled = false;
            this.ShowMatrixMenu.Name = "ShowMatrixMenu";
            this.ShowMatrixMenu.Size = new System.Drawing.Size(156, 22);
            this.ShowMatrixMenu.Text = "隣接リストを表示";
            this.ShowMatrixMenu.Click += new System.EventHandler(this.ShowMatrixMenu_Click);
            // 
            // 隣接行列を表示ToolStripMenuItem
            // 
            this.隣接行列を表示ToolStripMenuItem.Enabled = false;
            this.隣接行列を表示ToolStripMenuItem.Name = "隣接行列を表示ToolStripMenuItem";
            this.隣接行列を表示ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.隣接行列を表示ToolStripMenuItem.Text = "隣接行列を表示";
            this.隣接行列を表示ToolStripMenuItem.Click += new System.EventHandler(this.隣接行列を表示ToolStripMenuItem_Click);
            // 
            // 迷路ToolStripMenuItem
            // 
            this.迷路ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.スタート位置の設定ToolStripMenuItem,
            this.ゴール位置の設定ToolStripMenuItem,
            this.スタートを右上ゴールを左下に設定ToolStripMenuItem,
            this.aアルゴリズムの設定ToolStripMenuItem});
            this.迷路ToolStripMenuItem.Enabled = false;
            this.迷路ToolStripMenuItem.Name = "迷路ToolStripMenuItem";
            this.迷路ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.迷路ToolStripMenuItem.Text = "迷路設定";
            // 
            // スタート位置の設定ToolStripMenuItem
            // 
            this.スタート位置の設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.左上ToolStripMenuItem1,
            this.右上ToolStripMenuItem3,
            this.左下ToolStripMenuItem2,
            this.右下ToolStripMenuItem2,
            this.中央ToolStripMenuItem2});
            this.スタート位置の設定ToolStripMenuItem.Name = "スタート位置の設定ToolStripMenuItem";
            this.スタート位置の設定ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.スタート位置の設定ToolStripMenuItem.Text = "スタート位置の設定";
            // 
            // 左上ToolStripMenuItem1
            // 
            this.左上ToolStripMenuItem1.Name = "左上ToolStripMenuItem1";
            this.左上ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.左上ToolStripMenuItem1.Text = "左上";
            this.左上ToolStripMenuItem1.Click += new System.EventHandler(this.左上ToolStripMenuItem1_Click);
            // 
            // 右上ToolStripMenuItem3
            // 
            this.右上ToolStripMenuItem3.Name = "右上ToolStripMenuItem3";
            this.右上ToolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.右上ToolStripMenuItem3.Text = "右上";
            this.右上ToolStripMenuItem3.Click += new System.EventHandler(this.右上ToolStripMenuItem3_Click);
            // 
            // 左下ToolStripMenuItem2
            // 
            this.左下ToolStripMenuItem2.Name = "左下ToolStripMenuItem2";
            this.左下ToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.左下ToolStripMenuItem2.Text = "左下";
            this.左下ToolStripMenuItem2.Click += new System.EventHandler(this.左下ToolStripMenuItem2_Click);
            // 
            // 右下ToolStripMenuItem2
            // 
            this.右下ToolStripMenuItem2.Name = "右下ToolStripMenuItem2";
            this.右下ToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.右下ToolStripMenuItem2.Text = "右下";
            this.右下ToolStripMenuItem2.Click += new System.EventHandler(this.右下ToolStripMenuItem2_Click);
            // 
            // 中央ToolStripMenuItem2
            // 
            this.中央ToolStripMenuItem2.Name = "中央ToolStripMenuItem2";
            this.中央ToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.中央ToolStripMenuItem2.Text = "中央";
            this.中央ToolStripMenuItem2.Click += new System.EventHandler(this.中央ToolStripMenuItem2_Click);
            // 
            // ゴール位置の設定ToolStripMenuItem
            // 
            this.ゴール位置の設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.左上ToolStripMenuItem,
            this.右上ToolStripMenuItem2,
            this.左下ToolStripMenuItem1,
            this.右下ToolStripMenuItem1,
            this.中央ToolStripMenuItem1});
            this.ゴール位置の設定ToolStripMenuItem.Name = "ゴール位置の設定ToolStripMenuItem";
            this.ゴール位置の設定ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.ゴール位置の設定ToolStripMenuItem.Text = "ゴール位置の設定";
            // 
            // 左上ToolStripMenuItem
            // 
            this.左上ToolStripMenuItem.Name = "左上ToolStripMenuItem";
            this.左上ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.左上ToolStripMenuItem.Text = "左上";
            this.左上ToolStripMenuItem.Click += new System.EventHandler(this.左上ToolStripMenuItem_Click);
            // 
            // 右上ToolStripMenuItem2
            // 
            this.右上ToolStripMenuItem2.Name = "右上ToolStripMenuItem2";
            this.右上ToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.右上ToolStripMenuItem2.Text = "右上";
            this.右上ToolStripMenuItem2.Click += new System.EventHandler(this.右上ToolStripMenuItem2_Click);
            // 
            // 左下ToolStripMenuItem1
            // 
            this.左下ToolStripMenuItem1.Name = "左下ToolStripMenuItem1";
            this.左下ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.左下ToolStripMenuItem1.Text = "左下";
            this.左下ToolStripMenuItem1.Click += new System.EventHandler(this.左下ToolStripMenuItem1_Click);
            // 
            // 右下ToolStripMenuItem1
            // 
            this.右下ToolStripMenuItem1.Name = "右下ToolStripMenuItem1";
            this.右下ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.右下ToolStripMenuItem1.Text = "右下";
            this.右下ToolStripMenuItem1.Click += new System.EventHandler(this.右下ToolStripMenuItem1_Click);
            // 
            // 中央ToolStripMenuItem1
            // 
            this.中央ToolStripMenuItem1.Name = "中央ToolStripMenuItem1";
            this.中央ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.中央ToolStripMenuItem1.Text = "中央";
            this.中央ToolStripMenuItem1.Click += new System.EventHandler(this.中央ToolStripMenuItem1_Click);
            // 
            // スタートを右上ゴールを左下に設定ToolStripMenuItem
            // 
            this.スタートを右上ゴールを左下に設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.スタートを左上ゴールを右下に設定ToolStripMenuItem,
            this.スタートを左上ゴールを中央に設定ToolStripMenuItem});
            this.スタートを右上ゴールを左下に設定ToolStripMenuItem.Name = "スタートを右上ゴールを左下に設定ToolStripMenuItem";
            this.スタートを右上ゴールを左下に設定ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.スタートを右上ゴールを左下に設定ToolStripMenuItem.Text = "スタート，ゴールを同時に設定";
            // 
            // スタートを左上ゴールを右下に設定ToolStripMenuItem
            // 
            this.スタートを左上ゴールを右下に設定ToolStripMenuItem.Name = "スタートを左上ゴールを右下に設定ToolStripMenuItem";
            this.スタートを左上ゴールを右下に設定ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.スタートを左上ゴールを右下に設定ToolStripMenuItem.Text = "スタートを左上，ゴールを右下に設定";
            this.スタートを左上ゴールを右下に設定ToolStripMenuItem.Click += new System.EventHandler(this.スタートを左上ゴールを右下に設定ToolStripMenuItem_Click);
            // 
            // スタートを左上ゴールを中央に設定ToolStripMenuItem
            // 
            this.スタートを左上ゴールを中央に設定ToolStripMenuItem.Name = "スタートを左上ゴールを中央に設定ToolStripMenuItem";
            this.スタートを左上ゴールを中央に設定ToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.スタートを左上ゴールを中央に設定ToolStripMenuItem.Text = "スタートを左上，ゴールを中央に設定";
            this.スタートを左上ゴールを中央に設定ToolStripMenuItem.Click += new System.EventHandler(this.スタートを左上ゴールを中央に設定ToolStripMenuItem_Click);
            // 
            // aアルゴリズムの設定ToolStripMenuItem
            // 
            this.aアルゴリズムの設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通常の設定で探索するToolStripMenuItem,
            this.ヒューリスティック値を大きくするToolStripMenuItem1});
            this.aアルゴリズムの設定ToolStripMenuItem.Name = "aアルゴリズムの設定ToolStripMenuItem";
            this.aアルゴリズムの設定ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aアルゴリズムの設定ToolStripMenuItem.Text = "A*アルゴリズムの設定";
            // 
            // 通常の設定で探索するToolStripMenuItem
            // 
            this.通常の設定で探索するToolStripMenuItem.Name = "通常の設定で探索するToolStripMenuItem";
            this.通常の設定で探索するToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.通常の設定で探索するToolStripMenuItem.Text = "通常の設定で探索する";
            this.通常の設定で探索するToolStripMenuItem.Click += new System.EventHandler(this.通常の設定で探索するToolStripMenuItem_Click);
            // 
            // ヒューリスティック値を大きくするToolStripMenuItem1
            // 
            this.ヒューリスティック値を大きくするToolStripMenuItem1.Name = "ヒューリスティック値を大きくするToolStripMenuItem1";
            this.ヒューリスティック値を大きくするToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.ヒューリスティック値を大きくするToolStripMenuItem1.Text = "ヒューリスティック値を大きくする";
            this.ヒューリスティック値を大きくするToolStripMenuItem1.Click += new System.EventHandler(this.ヒューリスティック値を大きくするToolStripMenuItem1_Click);
            // 
            // ゴールを真ん中にするToolStripMenuItem
            // 
            this.ゴールを真ん中にするToolStripMenuItem.Name = "ゴールを真ん中にするToolStripMenuItem";
            this.ゴールを真ん中にするToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(14, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 16);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "NodeID";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Breadth",
            "Depth",
            "A*"});
            this.comboBox1.Location = new System.Drawing.Point(793, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 20);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Breadth";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(710, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "SearchOption";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(737, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(737, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "AutoSearch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(793, 386);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 19);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "10";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(736, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "TryTimes";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(13, 462);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(684, 80);
            this.textBox5.TabIndex = 21;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "Console";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(13, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 375);
            this.panel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Start";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "Goal";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(793, 167);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(69, 20);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(793, 193);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(69, 20);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // 右上ToolStripMenuItem
            // 
            this.右上ToolStripMenuItem.Name = "右上ToolStripMenuItem";
            this.右上ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.右上ToolStripMenuItem.Text = "左上";
            // 
            // 右上ToolStripMenuItem1
            // 
            this.右上ToolStripMenuItem1.Name = "右上ToolStripMenuItem1";
            this.右上ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.右上ToolStripMenuItem1.Text = "右上";
            // 
            // 左下ToolStripMenuItem
            // 
            this.左下ToolStripMenuItem.Name = "左下ToolStripMenuItem";
            this.左下ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.左下ToolStripMenuItem.Text = "左下";
            // 
            // 右下ToolStripMenuItem
            // 
            this.右下ToolStripMenuItem.Name = "右下ToolStripMenuItem";
            this.右下ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.右下ToolStripMenuItem.Text = "右下";
            // 
            // 中央ToolStripMenuItem
            // 
            this.中央ToolStripMenuItem.Name = "中央ToolStripMenuItem";
            this.中央ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.中央ToolStripMenuItem.Text = "中央";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(60, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 29;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(91, 435);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 30;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(91, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(75, 16);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "Animation";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(710, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 12);
            this.label9.TabIndex = 33;
            this.label9.Text = "GenerateOption";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(710, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "AutoSearch";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(736, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 12);
            this.label11.TabIndex = 35;
            this.label11.Text = "Mode";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(281, 37);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(102, 16);
            this.trackBar1.TabIndex = 36;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(172, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 12);
            this.label12.TabIndex = 37;
            this.label12.Text = "AnimationSpeed : 5";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(735, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 12);
            this.label13.TabIndex = 38;
            this.label13.Text = "Mode";
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "StabCollapse",
            "Clustering"});
            this.comboBox4.Location = new System.Drawing.Point(772, 56);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(90, 20);
            this.comboBox4.TabIndex = 39;
            this.comboBox4.Text = "StabCollapse";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.SaveToolStripMenuItem.Text = "迷路をイメージとして保存";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.迷路をイメージとして保存ToolStripMenuItem_Click);
            // 
            // Save2ToolStripMenuItem
            // 
            this.Save2ToolStripMenuItem.Enabled = false;
            this.Save2ToolStripMenuItem.Name = "Save2ToolStripMenuItem";
            this.Save2ToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.Save2ToolStripMenuItem.Text = "現在の迷路の状態をイメージとして保存";
            this.Save2ToolStripMenuItem.Click += new System.EventHandler(this.現在の迷路の状態をイメージとして保存ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 566);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Maze Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ShowMatrixMenu;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ToolStripMenuItem ゴールを真ん中にするToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右上ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 左下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中央ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ゴール位置の設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 右上ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 左下ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 右下ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 中央ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem スタートを右上ゴールを左下に設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタートを左上ゴールを右下に設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタートを左上ゴールを中央に設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem スタート位置の設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 左上ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 右上ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 左下ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 右下ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 中央ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 迷路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隣接行列を表示ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ToolStripMenuItem aアルゴリズムの設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通常の設定で探索するToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヒューリスティック値を大きくするToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save2ToolStripMenuItem;
    }
}

