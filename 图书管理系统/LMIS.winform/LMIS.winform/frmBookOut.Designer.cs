namespace LMIS.Winform
{
    partial class frmBookOut
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrdv1 = new System.Windows.Forms.DataGridView();
            this.BID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BWriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrdv3 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgrdv2 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtIden = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtPSex = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bookwriter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv3)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrdv1);
            this.groupBox3.Location = new System.Drawing.Point(19, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 112);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "已借图书";
            // 
            // dgrdv1
            // 
            this.dgrdv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BID,
            this.BName,
            this.BWriter,
            this.BPublish,
            this.BDate,
            this.BPrice,
            this.BNum,
            this.BType,
            this.BRemark,
            this.ISBN});
            this.dgrdv1.Location = new System.Drawing.Point(18, 16);
            this.dgrdv1.Name = "dgrdv1";
            this.dgrdv1.RowTemplate.Height = 23;
            this.dgrdv1.Size = new System.Drawing.Size(526, 90);
            this.dgrdv1.TabIndex = 25;
            // 
            // BID
            // 
            this.BID.DataPropertyName = "BID";
            this.BID.HeaderText = "图书编号";
            this.BID.Name = "BID";
            this.BID.ReadOnly = true;
            // 
            // BName
            // 
            this.BName.DataPropertyName = "BName";
            this.BName.HeaderText = "图书名";
            this.BName.Name = "BName";
            this.BName.ReadOnly = true;
            // 
            // BWriter
            // 
            this.BWriter.DataPropertyName = "BWriter";
            this.BWriter.HeaderText = "作者";
            this.BWriter.Name = "BWriter";
            this.BWriter.ReadOnly = true;
            // 
            // BPublish
            // 
            this.BPublish.DataPropertyName = "BPublish";
            this.BPublish.HeaderText = "出版社";
            this.BPublish.Name = "BPublish";
            this.BPublish.ReadOnly = true;
            // 
            // BDate
            // 
            this.BDate.DataPropertyName = "BDate";
            this.BDate.HeaderText = "出版日期";
            this.BDate.Name = "BDate";
            this.BDate.ReadOnly = true;
            // 
            // BPrice
            // 
            this.BPrice.DataPropertyName = "BPrice";
            this.BPrice.HeaderText = "价格";
            this.BPrice.Name = "BPrice";
            this.BPrice.ReadOnly = true;
            // 
            // BNum
            // 
            this.BNum.DataPropertyName = "BNum";
            this.BNum.HeaderText = "数量";
            this.BNum.Name = "BNum";
            this.BNum.ReadOnly = true;
            // 
            // BType
            // 
            this.BType.DataPropertyName = "TID";
            this.BType.HeaderText = "类型";
            this.BType.Name = "BType";
            this.BType.ReadOnly = true;
            // 
            // BRemark
            // 
            this.BRemark.DataPropertyName = "BRemark";
            this.BRemark.HeaderText = "备注";
            this.BRemark.Name = "BRemark";
            this.BRemark.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrdv3);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnOut);
            this.groupBox2.Controls.Add(this.dtp);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBID);
            this.groupBox2.Location = new System.Drawing.Point(211, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借书";
            // 
            // dgrdv3
            // 
            this.dgrdv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.Bookwriter,
            this.Publish,
            this.Type,
            this.Date,
            this.Price});
            this.dgrdv3.Location = new System.Drawing.Point(342, 8);
            this.dgrdv3.Name = "dgrdv3";
            this.dgrdv3.RowTemplate.Height = 23;
            this.dgrdv3.Size = new System.Drawing.Size(10, 10);
            this.dgrdv3.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(256, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "请按回车";
            // 
            // btnOut
            // 
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOut.Location = new System.Drawing.Point(240, 223);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 23;
            this.btnOut.Text = "借出";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(80, 223);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(112, 21);
            this.dtp.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(24, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "借书日期";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtPrice);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtBDate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtType);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtPublish);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtWriter);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtBName);
            this.groupBox4.Location = new System.Drawing.Point(8, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(344, 160);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(18, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "查询";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(192, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "价格";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(232, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(16, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "出版日期";
            // 
            // txtBDate
            // 
            this.txtBDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBDate.Location = new System.Drawing.Point(72, 88);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.ReadOnly = true;
            this.txtBDate.Size = new System.Drawing.Size(100, 21);
            this.txtBDate.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(192, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "类型";
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Location = new System.Drawing.Point(232, 56);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(100, 21);
            this.txtType.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(16, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "出版社";
            // 
            // txtPublish
            // 
            this.txtPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPublish.Location = new System.Drawing.Point(72, 56);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.ReadOnly = true;
            this.txtPublish.Size = new System.Drawing.Size(100, 21);
            this.txtPublish.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(192, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "作者";
            // 
            // txtWriter
            // 
            this.txtWriter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWriter.Location = new System.Drawing.Point(232, 24);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.ReadOnly = true;
            this.txtWriter.Size = new System.Drawing.Size(100, 21);
            this.txtWriter.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "图书名";
            // 
            // txtBName
            // 
            this.txtBName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBName.Location = new System.Drawing.Point(72, 24);
            this.txtBName.Name = "txtBName";
            this.txtBName.ReadOnly = true;
            this.txtBName.Size = new System.Drawing.Size(100, 21);
            this.txtBName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(48, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "图书编号";
            // 
            // txtBID
            // 
            this.txtBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBID.Location = new System.Drawing.Point(104, 24);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(136, 21);
            this.txtBID.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgrdv2);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.txtIden);
            this.groupBox1.Controls.Add(this.txtPN);
            this.groupBox1.Controls.Add(this.txtPSex);
            this.groupBox1.Controls.Add(this.txtPName);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 252);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借阅者信息";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(84, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "查询";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgrdv2
            // 
            this.dgrdv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Sex,
            this.N,
            this.Identity,
            this.Money});
            this.dgrdv2.Location = new System.Drawing.Point(168, 8);
            this.dgrdv2.Name = "dgrdv2";
            this.dgrdv2.RowTemplate.Height = 23;
            this.dgrdv2.Size = new System.Drawing.Size(10, 10);
            this.dgrdv2.TabIndex = 25;
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
            // Identity
            // 
            this.Identity.DataPropertyName = "identity";
            this.Identity.HeaderText = "身份";
            this.Identity.Name = "Identity";
            // 
            // Money
            // 
            this.Money.DataPropertyName = "PMoney";
            this.Money.HeaderText = "罚款";
            this.Money.Name = "Money";
            // 
            // txtMoney
            // 
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(72, 192);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 11;
            // 
            // txtIden
            // 
            this.txtIden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIden.Location = new System.Drawing.Point(72, 160);
            this.txtIden.Name = "txtIden";
            this.txtIden.ReadOnly = true;
            this.txtIden.Size = new System.Drawing.Size(100, 21);
            this.txtIden.TabIndex = 10;
            // 
            // txtPN
            // 
            this.txtPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPN.Location = new System.Drawing.Point(72, 128);
            this.txtPN.Name = "txtPN";
            this.txtPN.ReadOnly = true;
            this.txtPN.Size = new System.Drawing.Size(100, 21);
            this.txtPN.TabIndex = 9;
            // 
            // txtPSex
            // 
            this.txtPSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPSex.Location = new System.Drawing.Point(72, 96);
            this.txtPSex.Name = "txtPSex";
            this.txtPSex.ReadOnly = true;
            this.txtPSex.Size = new System.Drawing.Size(100, 21);
            this.txtPSex.TabIndex = 8;
            // 
            // txtPName
            // 
            this.txtPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPName.Location = new System.Drawing.Point(72, 64);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(100, 21);
            this.txtPName.TabIndex = 7;
            // 
            // txtPID
            // 
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPID.Location = new System.Drawing.Point(72, 32);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(100, 21);
            this.txtPID.TabIndex = 6;
            this.txtPID.TextChanged += new System.EventHandler(this.txtPID_KeyDown);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "罚  款";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "身  份";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "身份证";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "性  别";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓  名";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "借书证号";
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BName";
            this.BookName.HeaderText = "图书名";
            this.BookName.Name = "BookName";
            // 
            // Bookwriter
            // 
            this.Bookwriter.DataPropertyName = "BWriter";
            this.Bookwriter.HeaderText = "作者";
            this.Bookwriter.Name = "Bookwriter";
            // 
            // Publish
            // 
            this.Publish.DataPropertyName = "BPublish";
            this.Publish.HeaderText = "出版社";
            this.Publish.Name = "Publish";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "TID";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "BDate";
            this.Date.HeaderText = "出版日期";
            this.Date.Name = "Date";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "BPrice";
            this.Price.HeaderText = "价格";
            this.Price.Name = "Price";
            // 
            // frmBookOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            //this.Name = "frmBookOut";
            this.Text = "借书";
            this.Load += new System.EventHandler(this.frmBookOut_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrdv1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtIden;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtPSex;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrdv3;
        private System.Windows.Forms.DataGridView dgrdv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BWriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bookwriter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}