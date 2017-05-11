namespace KGC_client
{
    partial class clientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.qmcz = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.slab = new System.Windows.Forms.Label();
            this.mlab = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.noSignBut = new System.Windows.Forms.Button();
            this.waitBut = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pkcz = new System.Windows.Forms.Panel();
            this.公钥管理toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bt = new System.Windows.Forms.Panel();
            this.操作票管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jdtiao = new System.Windows.Forms.Timer(this.components);
            this.fromTop = new System.Windows.Forms.Timer(this.components);
            this.daojs = new System.Windows.Forms.Timer(this.components);
            this.nowt = new System.Windows.Forms.Timer(this.components);
            this.upt = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tslang = new System.Windows.Forms.Label();
            this.qmcz.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pkcz.SuspendLayout();
            this.bt.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.label4.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "注：服务器离线时，无法重新生成公私钥";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(60, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(545, 204);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "unll";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(259, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "重新生成公私钥";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "用户公钥：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(553, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "在线";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(124)))), ((int)(((byte)(252)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(460, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "服务器状态";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(285, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "CLIENT";
            // 
            // qmcz
            // 
            this.qmcz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.qmcz.Controls.Add(this.groupBox6);
            this.qmcz.Controls.Add(this.groupBox5);
            this.qmcz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qmcz.Location = new System.Drawing.Point(0, 97);
            this.qmcz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qmcz.Name = "qmcz";
            this.qmcz.Size = new System.Drawing.Size(657, 340);
            this.qmcz.TabIndex = 17;
            this.qmcz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.qmcz_MouseMove);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Location = new System.Drawing.Point(436, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 309);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "消息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.slab);
            this.groupBox4.Controls.Add(this.mlab);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(26, 33);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(170, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "有效时间";
            // 
            // slab
            // 
            this.slab.AutoSize = true;
            this.slab.BackColor = System.Drawing.Color.Transparent;
            this.slab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slab.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.slab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.slab.Location = new System.Drawing.Point(80, 49);
            this.slab.Name = "slab";
            this.slab.Size = new System.Drawing.Size(35, 15);
            this.slab.TabIndex = 17;
            this.slab.Text = "任务";
            // 
            // mlab
            // 
            this.mlab.AutoSize = true;
            this.mlab.BackColor = System.Drawing.Color.Transparent;
            this.mlab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mlab.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mlab.Location = new System.Drawing.Point(47, 49);
            this.mlab.Name = "mlab";
            this.mlab.Size = new System.Drawing.Size(35, 15);
            this.mlab.TabIndex = 16;
            this.mlab.Text = "没有";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(26, 190);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(170, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "当前签名队列";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(25, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "没有你，请稍等。";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.noSignBut);
            this.groupBox5.Controls.Add(this.waitBut);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(10, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(415, 310);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "申请内容：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "签名状态";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(45, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeftLayout = true;
            this.progressBar1.Size = new System.Drawing.Size(296, 19);
            this.progressBar1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(262, 259);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "同意签名";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // noSignBut
            // 
            this.noSignBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.noSignBut.Enabled = false;
            this.noSignBut.FlatAppearance.BorderSize = 0;
            this.noSignBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noSignBut.Location = new System.Drawing.Point(50, 259);
            this.noSignBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noSignBut.Name = "noSignBut";
            this.noSignBut.Size = new System.Drawing.Size(90, 31);
            this.noSignBut.TabIndex = 0;
            this.noSignBut.Text = "等待发起者";
            this.noSignBut.UseVisualStyleBackColor = false;
            this.noSignBut.Click += new System.EventHandler(this.noSignBut_Click);
            // 
            // waitBut
            // 
            this.waitBut.Location = new System.Drawing.Point(31, 32);
            this.waitBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.waitBut.Multiline = true;
            this.waitBut.Name = "waitBut";
            this.waitBut.ReadOnly = true;
            this.waitBut.Size = new System.Drawing.Size(370, 151);
            this.waitBut.TabIndex = 7;
            this.waitBut.Text = "暂时没有人申请操作票，请等待发起者进行申请。";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(8, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 17);
            this.name.TabIndex = 11;
            this.name.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(124)))), ((int)(((byte)(252)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(460, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "time";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("华文细黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(615, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "×";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pkcz
            // 
            this.pkcz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.pkcz.Controls.Add(this.tslang);
            this.pkcz.Controls.Add(this.textBox1);
            this.pkcz.Controls.Add(this.label4);
            this.pkcz.Controls.Add(this.button1);
            this.pkcz.Controls.Add(this.label5);
            this.pkcz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pkcz.Location = new System.Drawing.Point(0, 97);
            this.pkcz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pkcz.Name = "pkcz";
            this.pkcz.Size = new System.Drawing.Size(657, 340);
            this.pkcz.TabIndex = 16;
            this.pkcz.Visible = false;
            // 
            // 公钥管理toolStripMenuItem2
            // 
            this.公钥管理toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.公钥管理toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("公钥管理toolStripMenuItem2.Image")));
            this.公钥管理toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.公钥管理toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.White;
            this.公钥管理toolStripMenuItem2.Name = "公钥管理toolStripMenuItem2";
            this.公钥管理toolStripMenuItem2.Size = new System.Drawing.Size(75, 51);
            this.公钥管理toolStripMenuItem2.Text = "公钥管理";
            this.公钥管理toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.公钥管理toolStripMenuItem2.ToolTipText = "公钥管理";
            this.公钥管理toolStripMenuItem2.Click += new System.EventHandler(this.公钥管理toolStripMenuItem2_Click);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(124)))), ((int)(((byte)(252)))));
            this.bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt.Controls.Add(this.label7);
            this.bt.Controls.Add(this.label8);
            this.bt.Controls.Add(this.label16);
            this.bt.Controls.Add(this.name);
            this.bt.Controls.Add(this.label6);
            this.bt.Controls.Add(this.button3);
            this.bt.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt.Location = new System.Drawing.Point(0, 0);
            this.bt.Margin = new System.Windows.Forms.Padding(0);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(657, 42);
            this.bt.TabIndex = 18;
            this.bt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_MouseDown);
            this.bt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_MouseMove);
            // 
            // 操作票管理ToolStripMenuItem
            // 
            this.操作票管理ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.操作票管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("操作票管理ToolStripMenuItem.Image")));
            this.操作票管理ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.操作票管理ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.操作票管理ToolStripMenuItem.Name = "操作票管理ToolStripMenuItem";
            this.操作票管理ToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.操作票管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 51);
            this.操作票管理ToolStripMenuItem.Text = "签名操作";
            this.操作票管理ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.操作票管理ToolStripMenuItem.ToolTipText = "操作票管理";
            this.操作票管理ToolStripMenuItem.Click += new System.EventHandler(this.操作票管理ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(124)))), ((int)(((byte)(252)))));
            this.menuStrip1.Font = new System.Drawing.Font("华文细黑", 10.5F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作票管理ToolStripMenuItem,
            this.公钥管理toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(657, 55);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // jdtiao
            // 
            this.jdtiao.Tick += new System.EventHandler(this.jdtiao_Tick);
            // 
            // fromTop
            // 
            this.fromTop.Interval = 700;
            this.fromTop.Tick += new System.EventHandler(this.fromTop_Tick);
            // 
            // daojs
            // 
            this.daojs.Interval = 1000;
            this.daojs.Tick += new System.EventHandler(this.js_Tick);
            // 
            // nowt
            // 
            this.nowt.Enabled = true;
            this.nowt.Interval = 900;
            this.nowt.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // upt
            // 
            this.upt.Enabled = true;
            this.upt.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tslang
            // 
            this.tslang.AutoSize = true;
            this.tslang.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tslang.ForeColor = System.Drawing.Color.Red;
            this.tslang.Location = new System.Drawing.Point(62, 258);
            this.tslang.Name = "tslang";
            this.tslang.Size = new System.Drawing.Size(0, 13);
            this.tslang.TabIndex = 4;
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 437);
            this.Controls.Add(this.pkcz);
            this.Controls.Add(this.qmcz);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt);
            this.Font = new System.Drawing.Font("华文细黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientForm";
            this.Load += new System.EventHandler(this.clientForm_Load);
            this.qmcz.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pkcz.ResumeLayout(false);
            this.pkcz.PerformLayout();
            this.bt.ResumeLayout(false);
            this.bt.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel qmcz;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Button noSignBut;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pkcz;
        private System.Windows.Forms.ToolStripMenuItem 公钥管理toolStripMenuItem2;
        private System.Windows.Forms.Panel bt;
        private System.Windows.Forms.ToolStripMenuItem 操作票管理ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer jdtiao;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox waitBut;
        private System.Windows.Forms.Timer nowt;
        private System.Windows.Forms.Timer daojs;
        public System.Windows.Forms.Label slab;
        public System.Windows.Forms.Label mlab;
        private System.Windows.Forms.Timer upt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer fromTop;
        public System.Windows.Forms.Label tslang;
    }
}