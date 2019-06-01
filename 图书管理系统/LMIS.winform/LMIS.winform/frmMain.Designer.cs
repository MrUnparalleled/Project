namespace LMIS.Winform
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览身份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借还管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.借还管理ToolStripMenuItem,
            this.查询操作ToolStripMenuItem,
            this.用户登录ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户ToolStripMenuItem,
            this.浏览用户ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            this.系统管理ToolStripMenuItem.Visible = false;
            // 
            // 添加用户ToolStripMenuItem
            // 
            this.添加用户ToolStripMenuItem.Name = "添加用户ToolStripMenuItem";
            this.添加用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加用户ToolStripMenuItem.Text = "添加用户";
            this.添加用户ToolStripMenuItem.Click += new System.EventHandler(this.添加用户ToolStripMenuItem_Click);
            // 
            // 浏览用户ToolStripMenuItem
            // 
            this.浏览用户ToolStripMenuItem.Name = "浏览用户ToolStripMenuItem";
            this.浏览用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览用户ToolStripMenuItem.Text = "浏览用户";
            this.浏览用户ToolStripMenuItem.Click += new System.EventHandler(this.浏览用户ToolStripMenuItem_Click);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书分类ToolStripMenuItem,
            this.浏览图书ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            this.图书管理ToolStripMenuItem.Visible = false;
            // 
            // 图书分类ToolStripMenuItem
            // 
            this.图书分类ToolStripMenuItem.Name = "图书分类ToolStripMenuItem";
            this.图书分类ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.图书分类ToolStripMenuItem.Text = "图书分类";
            this.图书分类ToolStripMenuItem.Click += new System.EventHandler(this.图书分类ToolStripMenuItem_Click);
            // 
            // 浏览图书ToolStripMenuItem
            // 
            this.浏览图书ToolStripMenuItem.Name = "浏览图书ToolStripMenuItem";
            this.浏览图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览图书ToolStripMenuItem.Text = "浏览图书";
            this.浏览图书ToolStripMenuItem.Click += new System.EventHandler(this.浏览图书ToolStripMenuItem_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览身份ToolStripMenuItem,
            this.浏览读者ToolStripMenuItem});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            this.读者管理ToolStripMenuItem.Visible = false;
            // 
            // 浏览身份ToolStripMenuItem
            // 
            this.浏览身份ToolStripMenuItem.Name = "浏览身份ToolStripMenuItem";
            this.浏览身份ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览身份ToolStripMenuItem.Text = "浏览身份";
            this.浏览身份ToolStripMenuItem.Click += new System.EventHandler(this.浏览身份ToolStripMenuItem_Click);
            // 
            // 浏览读者ToolStripMenuItem
            // 
            this.浏览读者ToolStripMenuItem.Name = "浏览读者ToolStripMenuItem";
            this.浏览读者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览读者ToolStripMenuItem.Text = "浏览读者";
            this.浏览读者ToolStripMenuItem.Click += new System.EventHandler(this.浏览读者ToolStripMenuItem_Click);
            // 
            // 借还管理ToolStripMenuItem
            // 
            this.借还管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.还书ToolStripMenuItem});
            this.借还管理ToolStripMenuItem.Name = "借还管理ToolStripMenuItem";
            this.借还管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.借还管理ToolStripMenuItem.Text = "借还管理";
            this.借还管理ToolStripMenuItem.Visible = false;
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 还书ToolStripMenuItem
            // 
            this.还书ToolStripMenuItem.Name = "还书ToolStripMenuItem";
            this.还书ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.还书ToolStripMenuItem.Text = "还书";
            this.还书ToolStripMenuItem.Click += new System.EventHandler(this.还书ToolStripMenuItem_Click);
            // 
            // 查询操作ToolStripMenuItem
            // 
            this.查询操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书查询ToolStripMenuItem,
            this.借阅查询ToolStripMenuItem});
            this.查询操作ToolStripMenuItem.Name = "查询操作ToolStripMenuItem";
            this.查询操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.查询操作ToolStripMenuItem.Text = "查询操作";
            this.查询操作ToolStripMenuItem.Visible = false;
            // 
            // 图书查询ToolStripMenuItem
            // 
            this.图书查询ToolStripMenuItem.Name = "图书查询ToolStripMenuItem";
            this.图书查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.图书查询ToolStripMenuItem.Text = "图书查询";
            this.图书查询ToolStripMenuItem.Visible = false;
            this.图书查询ToolStripMenuItem.Click += new System.EventHandler(this.图书查询ToolStripMenuItem_Click);
            // 
            // 借阅查询ToolStripMenuItem
            // 
            this.借阅查询ToolStripMenuItem.Name = "借阅查询ToolStripMenuItem";
            this.借阅查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.借阅查询ToolStripMenuItem.Text = "借阅查询";
            this.借阅查询ToolStripMenuItem.Visible = false;
            this.借阅查询ToolStripMenuItem.Click += new System.EventHandler(this.借阅查询ToolStripMenuItem_Click);
            // 
            // 用户登录ToolStripMenuItem
            // 
            this.用户登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.重新登录ToolStripMenuItem});
            this.用户登录ToolStripMenuItem.Name = "用户登录ToolStripMenuItem";
            this.用户登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户登录ToolStripMenuItem.Text = "用户管理";
            this.用户登录ToolStripMenuItem.Click += new System.EventHandler(this.用户登录ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(703, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "系统";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "读者";
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "借书";
            this.toolStripButton3.Visible = false;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton4.Text = "还书";
            this.toolStripButton4.Visible = false;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton5.Text = "查询";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton6.Text = "用户";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton7.Text = "占座";
            this.toolStripButton7.Visible = false;
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "当前登录用户   ";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel2.Text = "     ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Enabled = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel3.Text = "     ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Enabled = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel4.Text = "     ";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Enabled = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel5.Text = "作者：wjf   ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Enabled = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel6.Text = "图书管理信息系统";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton8.Text = "聊天";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 495);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书分类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览身份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 借还管理ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 查询操作ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 用户登录ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 借阅查询ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 图书查询ToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        public System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.ToolStripButton toolStripButton4;
        public System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}