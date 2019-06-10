namespace MoviesManage
{
    partial class FilmInformationBackForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmInformationBackForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.影片信息 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSType = new System.Windows.Forms.ComboBox();
            this.cmdSArae = new System.Windows.Forms.ComboBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtMnames = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMZY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtJ = new System.Windows.Forms.TextBox();
            this.cmbMDq = new System.Windows.Forms.ComboBox();
            this.cmbMtype = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtState = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnTJ = new System.Windows.Forms.Button();
            this.btnXG = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.前后端切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭当前窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.影片信息.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(202, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(927, 280);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "MID";
            this.id.HeaderText = "编号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MovieName";
            this.Column1.HeaderText = "影片名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MainPerformer";
            this.Column2.HeaderText = "主演";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MovieTypeId";
            this.Column3.HeaderText = "类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Area";
            this.Column4.HeaderText = "地区";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TimeLength";
            this.Column5.HeaderText = "时长";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OnTime";
            this.Column6.HeaderText = "上映时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Synopsis";
            this.Column7.HeaderText = "简介";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MovieState";
            this.Column8.HeaderText = "状态";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // 影片信息
            // 
            this.影片信息.Controls.Add(this.pictureBox1);
            this.影片信息.Controls.Add(this.dataGridView1);
            this.影片信息.Location = new System.Drawing.Point(9, 196);
            this.影片信息.Name = "影片信息";
            this.影片信息.Size = new System.Drawing.Size(1135, 327);
            this.影片信息.TabIndex = 6;
            this.影片信息.TabStop = false;
            this.影片信息.Text = "影片信息";
            this.影片信息.Enter += new System.EventHandler(this.影片信息_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSType);
            this.panel1.Controls.Add(this.cmdSArae);
            this.panel1.Controls.Add(this.txtSName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSerch);
            this.panel1.Location = new System.Drawing.Point(111, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 41);
            this.panel1.TabIndex = 7;
            // 
            // cmbSType
            // 
            this.cmbSType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSType.FormattingEnabled = true;
            this.cmbSType.Items.AddRange(new object[] {
            "动作",
            "奇幻",
            "喜剧",
            "恐怖",
            "冒险",
            "爱情",
            "警匪",
            "科幻",
            "战争",
            "灾难",
            "温情",
            "史诗",
            "实验",
            "微电影",
            "微动画电影",
            "悬疑",
            "音乐",
            "黑帮",
            "记录",
            "公路",
            "意识流",
            "动画",
            "惊悚",
            "西部",
            "人物",
            "飞车",
            "电影",
            "超级英雄",
            "（无）"});
            this.cmbSType.Location = new System.Drawing.Point(282, 11);
            this.cmbSType.Name = "cmbSType";
            this.cmbSType.Size = new System.Drawing.Size(121, 20);
            this.cmbSType.TabIndex = 24;
            // 
            // cmdSArae
            // 
            this.cmdSArae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdSArae.FormattingEnabled = true;
            this.cmdSArae.Items.AddRange(new object[] {
            "印度",
            "法国",
            "德国",
            "日本",
            "韩国",
            "东欧",
            "俄罗斯",
            "阿拉伯",
            "美国",
            "英国",
            "（无）"});
            this.cmdSArae.Location = new System.Drawing.Point(506, 11);
            this.cmdSArae.Name = "cmdSArae";
            this.cmdSArae.Size = new System.Drawing.Size(121, 20);
            this.cmdSArae.TabIndex = 23;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(82, 11);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(100, 21);
            this.txtSName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "地区：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSC);
            this.groupBox1.Controls.Add(this.btnTJ);
            this.groupBox1.Controls.Add(this.btnXG);
            this.groupBox1.Location = new System.Drawing.Point(111, 573);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0无法01.jpg");
            this.imageList1.Images.SetKeyName(1, "X战警：黑凤凰.jpg");
            this.imageList1.Images.SetKeyName(2, "阿拉丁.jpg");
            this.imageList1.Images.SetKeyName(3, "八尺·一声一世.jpg");
            this.imageList1.Images.SetKeyName(4, "波西米亚狂想曲.jpg");
            this.imageList1.Images.SetKeyName(5, "大侦探皮卡丘.jpg");
            this.imageList1.Images.SetKeyName(6, "地久天长.jpg");
            this.imageList1.Images.SetKeyName(7, "哆啦A梦月球探险记.jpg");
            this.imageList1.Images.SetKeyName(8, "反贪风暴.jpg");
            this.imageList1.Images.SetKeyName(9, "风中有朵雨做的云.jpg");
            this.imageList1.Images.SetKeyName(10, "复仇者联盟4.jpg");
            this.imageList1.Images.SetKeyName(11, "哥斯拉2：怪兽之王.jpg");
            this.imageList1.Images.SetKeyName(12, "狗眼看人心.jpg");
            this.imageList1.Images.SetKeyName(13, "海蒂和爷爷.jpg");
            this.imageList1.Images.SetKeyName(14, "海市蜃楼.jpg");
            this.imageList1.Images.SetKeyName(15, "何以为家.jpg");
            this.imageList1.Images.SetKeyName(16, "绝杀慕尼黑.jpg");
            this.imageList1.Images.SetKeyName(17, "老师好.jpg");
            this.imageList1.Images.SetKeyName(18, "雷霆沙赞.jpg");
            this.imageList1.Images.SetKeyName(19, "邻座的怪同学.jpg");
            this.imageList1.Images.SetKeyName(20, "龙珠超.jpg");
            this.imageList1.Images.SetKeyName(21, "祈祷落幕时.jpg");
            this.imageList1.Images.SetKeyName(22, "巧虎大飞船历险记.jpg");
            this.imageList1.Images.SetKeyName(23, "如影随心.jpg");
            this.imageList1.Images.SetKeyName(24, "神器乐园历险记.jpg");
            this.imageList1.Images.SetKeyName(25, "调音师.jpg");
            this.imageList1.Images.SetKeyName(26, "无所不能.jpg");
            this.imageList1.Images.SetKeyName(27, "五月天人生无限公司.jpg");
            this.imageList1.Images.SetKeyName(28, "小飞象.jpg");
            this.imageList1.Images.SetKeyName(29, "驯龙高手3.jpg");
            this.imageList1.Images.SetKeyName(30, "一个母亲的复仇.jpg");
            this.imageList1.Images.SetKeyName(31, "一条狗的使命2.jpg");
            this.imageList1.Images.SetKeyName(32, "在乎你.jpg");
            this.imageList1.Images.SetKeyName(33, "转型团伙.jpg");
            this.imageList1.Images.SetKeyName(34, "追龙2.jpg");
            this.imageList1.Images.SetKeyName(35, "最好的我们.jpg");
            this.imageList1.Images.SetKeyName(36, "最佳男友.jpg");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "0无法01.jpg");
            this.imageList2.Images.SetKeyName(1, "X战警：黑凤凰.jpg");
            this.imageList2.Images.SetKeyName(2, "阿拉丁.jpg");
            this.imageList2.Images.SetKeyName(3, "八尺·一声一世.jpg");
            this.imageList2.Images.SetKeyName(4, "波西米亚狂想曲.jpg");
            this.imageList2.Images.SetKeyName(5, "大侦探皮卡丘.jpg");
            this.imageList2.Images.SetKeyName(6, "地久天长.jpg");
            this.imageList2.Images.SetKeyName(7, "哆啦A梦月球探险记.jpg");
            this.imageList2.Images.SetKeyName(8, "反贪风暴.jpg");
            this.imageList2.Images.SetKeyName(9, "风中有朵雨做的云.jpg");
            this.imageList2.Images.SetKeyName(10, "复仇者联盟4.jpg");
            this.imageList2.Images.SetKeyName(11, "哥斯拉2：怪兽之王.jpg");
            this.imageList2.Images.SetKeyName(12, "狗眼看人心.jpg");
            this.imageList2.Images.SetKeyName(13, "海蒂和爷爷.jpg");
            this.imageList2.Images.SetKeyName(14, "海市蜃楼.jpg");
            this.imageList2.Images.SetKeyName(15, "何以为家.jpg");
            this.imageList2.Images.SetKeyName(16, "绝杀慕尼黑.jpg");
            this.imageList2.Images.SetKeyName(17, "老师好.jpg");
            this.imageList2.Images.SetKeyName(18, "雷霆沙赞.jpg");
            this.imageList2.Images.SetKeyName(19, "邻座的怪同学.jpg");
            this.imageList2.Images.SetKeyName(20, "龙珠超.jpg");
            this.imageList2.Images.SetKeyName(21, "祈祷落幕时.jpg");
            this.imageList2.Images.SetKeyName(22, "巧虎大飞船历险记.jpg");
            this.imageList2.Images.SetKeyName(23, "如影随心.jpg");
            this.imageList2.Images.SetKeyName(24, "神器乐园历险记.jpg");
            this.imageList2.Images.SetKeyName(25, "调音师.jpg");
            this.imageList2.Images.SetKeyName(26, "无所不能.jpg");
            this.imageList2.Images.SetKeyName(27, "五月天人生无限公司.jpg");
            this.imageList2.Images.SetKeyName(28, "小飞象.jpg");
            this.imageList2.Images.SetKeyName(29, "驯龙高手3.jpg");
            this.imageList2.Images.SetKeyName(30, "一个母亲的复仇.jpg");
            this.imageList2.Images.SetKeyName(31, "一条狗的使命2.jpg");
            this.imageList2.Images.SetKeyName(32, "在乎你.jpg");
            this.imageList2.Images.SetKeyName(33, "转型团伙.jpg");
            this.imageList2.Images.SetKeyName(34, "追龙2.jpg");
            this.imageList2.Images.SetKeyName(35, "最好的我们.jpg");
            this.imageList2.Images.SetKeyName(36, "最佳男友.jpg");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "影视名称：";
            // 
            // txtMnames
            // 
            this.txtMnames.Location = new System.Drawing.Point(422, 54);
            this.txtMnames.Name = "txtMnames";
            this.txtMnames.Size = new System.Drawing.Size(121, 21);
            this.txtMnames.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "主演：";
            // 
            // txtMZY
            // 
            this.txtMZY.Location = new System.Drawing.Point(632, 53);
            this.txtMZY.Name = "txtMZY";
            this.txtMZY.Size = new System.Drawing.Size(121, 21);
            this.txtMZY.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "地区：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "时长：";
            // 
            // txtTime
            // 
            this.txtTime.ForeColor = System.Drawing.Color.Black;
            this.txtTime.Location = new System.Drawing.Point(422, 209);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(121, 21);
            this.txtTime.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "上映时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "简介：";
            // 
            // txtJ
            // 
            this.txtJ.Location = new System.Drawing.Point(422, 276);
            this.txtJ.Multiline = true;
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(350, 200);
            this.txtJ.TabIndex = 21;
            // 
            // cmbMDq
            // 
            this.cmbMDq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMDq.FormattingEnabled = true;
            this.cmbMDq.Items.AddRange(new object[] {
            "印度",
            "法国",
            "德国",
            "日本",
            "韩国",
            "东欧",
            "俄罗斯",
            "阿拉伯",
            "美国",
            "英国"});
            this.cmbMDq.Location = new System.Drawing.Point(422, 134);
            this.cmbMDq.Name = "cmbMDq";
            this.cmbMDq.Size = new System.Drawing.Size(121, 20);
            this.cmbMDq.TabIndex = 22;
            // 
            // cmbMtype
            // 
            this.cmbMtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMtype.FormattingEnabled = true;
            this.cmbMtype.Items.AddRange(new object[] {
            "动作",
            "奇幻",
            "喜剧",
            "恐怖",
            "冒险",
            "爱情",
            "警匪",
            "科幻",
            "战争",
            "灾难",
            "温情",
            "史诗",
            "实验",
            "微电影",
            "微动画电影",
            "悬疑",
            "音乐",
            "黑帮",
            "记录",
            "公路",
            "意识流",
            "动画",
            "惊悚",
            "西部",
            "人物",
            "飞车",
            "电影",
            "超级英雄"});
            this.cmbMtype.Location = new System.Drawing.Point(632, 134);
            this.cmbMtype.Name = "cmbMtype";
            this.cmbMtype.Size = new System.Drawing.Size(121, 20);
            this.cmbMtype.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(632, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // txtState
            // 
            this.txtState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtState.FormattingEnabled = true;
            this.txtState.Items.AddRange(new object[] {
            "1",
            "0"});
            this.txtState.Location = new System.Drawing.Point(851, 276);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(53, 20);
            this.txtState.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(549, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(759, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(549, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(759, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(551, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 30;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(922, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 31;
            this.label16.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(839, 212);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 32;
            this.label18.Text = "*";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtState);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cmbMtype);
            this.panel2.Controls.Add(this.cmbMDq);
            this.panel2.Controls.Add(this.txtJ);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMZY);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMnames);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(80, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 501);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnSC
            // 
            this.btnSC.BackgroundImage = global::MoviesManage.Properties.Resources.圆角矩形_4;
            this.btnSC.ForeColor = System.Drawing.Color.White;
            this.btnSC.Location = new System.Drawing.Point(760, 15);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(114, 29);
            this.btnSC.TabIndex = 3;
            this.btnSC.Text = "删除";
            this.btnSC.UseVisualStyleBackColor = true;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnTJ
            // 
            this.btnTJ.BackgroundImage = global::MoviesManage.Properties.Resources.圆角矩形_4;
            this.btnTJ.ForeColor = System.Drawing.Color.White;
            this.btnTJ.Location = new System.Drawing.Point(93, 15);
            this.btnTJ.Name = "btnTJ";
            this.btnTJ.Size = new System.Drawing.Size(114, 29);
            this.btnTJ.TabIndex = 1;
            this.btnTJ.Text = "新增";
            this.btnTJ.UseVisualStyleBackColor = true;
            this.btnTJ.Click += new System.EventHandler(this.btnTJ_Click);
            // 
            // btnXG
            // 
            this.btnXG.BackgroundImage = global::MoviesManage.Properties.Resources.圆角矩形_4;
            this.btnXG.ForeColor = System.Drawing.Color.White;
            this.btnXG.Location = new System.Drawing.Point(441, 15);
            this.btnXG.Name = "btnXG";
            this.btnXG.Size = new System.Drawing.Size(114, 29);
            this.btnXG.TabIndex = 2;
            this.btnXG.Text = "修改";
            this.btnXG.UseVisualStyleBackColor = true;
            this.btnXG.Click += new System.EventHandler(this.btnXG_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.BackgroundImage = global::MoviesManage.Properties.Resources.圆角矩形_4;
            this.btnSerch.ForeColor = System.Drawing.Color.White;
            this.btnSerch.Location = new System.Drawing.Point(809, 6);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(114, 29);
            this.btnSerch.TabIndex = 0;
            this.btnSerch.Text = "检索";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::MoviesManage.Properties.Resources.顶部信息栏;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.前后端切换ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 前后端切换ToolStripMenuItem
            // 
            this.前后端切换ToolStripMenuItem.BackgroundImage = global::MoviesManage.Properties.Resources.用户信息栏颜色;
            this.前后端切换ToolStripMenuItem.Checked = true;
            this.前后端切换ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.前后端切换ToolStripMenuItem.Name = "前后端切换ToolStripMenuItem";
            this.前后端切换ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.前后端切换ToolStripMenuItem.Text = "前后端切换";
            this.前后端切换ToolStripMenuItem.Click += new System.EventHandler(this.前后端切换ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭当前窗口ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 关闭当前窗口ToolStripMenuItem
            // 
            this.关闭当前窗口ToolStripMenuItem.Name = "关闭当前窗口ToolStripMenuItem";
            this.关闭当前窗口ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭当前窗口ToolStripMenuItem.Text = "关闭当前窗口";
            this.关闭当前窗口ToolStripMenuItem.Click += new System.EventHandler(this.关闭当前窗口ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MoviesManage.Properties.Resources.顶部信息栏;
            this.panel3.Location = new System.Drawing.Point(0, -17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1175, 66);
            this.panel3.TabIndex = 11;
            // 
            // FilmInformationBackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.影片信息);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FilmInformationBackForm";
            this.Text = "影片信息管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.影片信息.ResumeLayout(false);
            this.影片信息.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Button btnTJ;
        private System.Windows.Forms.Button btnXG;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox 影片信息;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMnames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMZY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJ;
        private System.Windows.Forms.ComboBox cmbMDq;
        private System.Windows.Forms.ComboBox cmbMtype;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox txtState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmdSArae;
        private System.Windows.Forms.ComboBox cmbSType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 前后端切换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem 关闭当前窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
    }
}

