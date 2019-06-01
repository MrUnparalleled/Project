namespace LMIS.Winform
{
    partial class frmSitManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSitManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.占该位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消站位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.座位信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "座位详情";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(467, -6);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(45, 21);
            this.txt1.TabIndex = 1;
            this.txt1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(7, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(567, 281);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.占该位置ToolStripMenuItem,
            this.取消站位ToolStripMenuItem,
            this.座位信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 占该位置ToolStripMenuItem
            // 
            this.占该位置ToolStripMenuItem.Name = "占该位置ToolStripMenuItem";
            this.占该位置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.占该位置ToolStripMenuItem.Text = "占该位置";
            this.占该位置ToolStripMenuItem.Click += new System.EventHandler(this.占该位置ToolStripMenuItem_Click);
            // 
            // 取消站位ToolStripMenuItem
            // 
            this.取消站位ToolStripMenuItem.Name = "取消站位ToolStripMenuItem";
            this.取消站位ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.取消站位ToolStripMenuItem.Text = "取消站位";
            this.取消站位ToolStripMenuItem.Click += new System.EventHandler(this.取消站位ToolStripMenuItem_Click);
            // 
            // 座位信息ToolStripMenuItem
            // 
            this.座位信息ToolStripMenuItem.Name = "座位信息ToolStripMenuItem";
            this.座位信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.座位信息ToolStripMenuItem.Text = "座位信息";
            this.座位信息ToolStripMenuItem.Click += new System.EventHandler(this.座位信息ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a.png");
            this.imageList1.Images.SetKeyName(1, "b.png");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSitManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 333);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSitManage";
            this.Text = "座位详情";
            this.Load += new System.EventHandler(this.frmSitManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 占该位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消站位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 座位信息ToolStripMenuItem;
        public System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Timer timer1;
    }
}