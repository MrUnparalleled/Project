namespace LMIS.Winform
{
    partial class frmPersonQuery
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgrdv2 = new System.Windows.Forms.DataGridView();
            this.BID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDtae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrdv1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.dgrdv2);
            this.groupBox2.Location = new System.Drawing.Point(11, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 192);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借阅信息";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, -8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 40;
            this.textBox1.Visible = false;
            // 
            // dgrdv2
            // 
            this.dgrdv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BID,
            this.BName,
            this.BWriter,
            this.BPublish,
            this.BDtae,
            this.BPrice,
            this.BNum,
            this.BType,
            this.BRemark,
            this.ISBN});
            this.dgrdv2.Location = new System.Drawing.Point(6, 20);
            this.dgrdv2.Name = "dgrdv2";
            this.dgrdv2.RowTemplate.Height = 23;
            this.dgrdv2.Size = new System.Drawing.Size(546, 166);
            this.dgrdv2.TabIndex = 0;
            // 
            // BID
            // 
            this.BID.DataPropertyName = "BID";
            this.BID.HeaderText = "图书编号";
            this.BID.Name = "BID";
            // 
            // BName
            // 
            this.BName.DataPropertyName = "BName";
            this.BName.HeaderText = "图书名";
            this.BName.Name = "BName";
            // 
            // BWriter
            // 
            this.BWriter.DataPropertyName = "BWriter";
            this.BWriter.HeaderText = "作者";
            this.BWriter.Name = "BWriter";
            // 
            // BPublish
            // 
            this.BPublish.DataPropertyName = "BPublish";
            this.BPublish.HeaderText = "出版社";
            this.BPublish.Name = "BPublish";
            // 
            // BDtae
            // 
            this.BDtae.DataPropertyName = "BDate";
            this.BDtae.HeaderText = "出版日期";
            this.BDtae.Name = "BDtae";
            // 
            // BPrice
            // 
            this.BPrice.DataPropertyName = "BPrice";
            this.BPrice.HeaderText = "价格";
            this.BPrice.Name = "BPrice";
            // 
            // BNum
            // 
            this.BNum.DataPropertyName = "BNum";
            this.BNum.HeaderText = "数量";
            this.BNum.Name = "BNum";
            // 
            // BType
            // 
            this.BType.DataPropertyName = "TID";
            this.BType.HeaderText = "类型";
            this.BType.Name = "BType";
            // 
            // BRemark
            // 
            this.BRemark.DataPropertyName = "BRemark";
            this.BRemark.HeaderText = "备注";
            this.BRemark.Name = "BRemark";
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(541, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(10, 10);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "BID";
            this.ID.HeaderText = "图书编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PID";
            this.Column1.HeaderText = "借书证编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "OData";
            this.Column2.HeaderText = "借出日期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrdv1);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 104);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            // 
            // dgrdv1
            // 
            this.dgrdv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Sex,
            this.N,
            this.Money,
            this.Identity});
            this.dgrdv1.Location = new System.Drawing.Point(6, 20);
            this.dgrdv1.Name = "dgrdv1";
            this.dgrdv1.RowTemplate.Height = 23;
            this.dgrdv1.Size = new System.Drawing.Size(546, 78);
            this.dgrdv1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "PName";
            this.Name.HeaderText = "姓名";
            this.Name.Name = "Name";
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "PSex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // N
            // 
            this.N.DataPropertyName = "PN";
            this.N.HeaderText = "身份证";
            this.N.Name = "N";
            // 
            // Money
            // 
            this.Money.DataPropertyName = "PMoney";
            this.Money.HeaderText = "罚款";
            this.Money.Name = "Money";
            // 
            // Identity
            // 
            this.Identity.DataPropertyName = "identity";
            this.Identity.HeaderText = "身份";
            this.Identity.Name = "Identity";
            // 
            // frmPersonQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 332);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            //this.Name = "frmPersonQuery";
            this.Text = "借阅查询";
            this.Load += new System.EventHandler(this.frmPersonQuery_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrdv1;
        private System.Windows.Forms.DataGridView dgrdv2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identity;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDtae;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
    }
}