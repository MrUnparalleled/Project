namespace LMIS.Winform
{
    partial class frmBookIn
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.text = new System.Windows.Forms.Label();
            this.txtBigDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInDate1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutDate = new System.Windows.Forms.TextBox();
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
            this.dgrdv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPID);
            this.groupBox2.Controls.Add(this.btClose);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBID);
            this.groupBox2.Location = new System.Drawing.Point(18, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "还书";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(400, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "查询";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "图书证号";
            // 
            // txtPID
            // 
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPID.Location = new System.Drawing.Point(72, 24);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(120, 21);
            this.txtPID.TabIndex = 27;
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(320, 216);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 26;
            this.btClose.Text = "取消";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btnIn
            // 
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Location = new System.Drawing.Point(112, 216);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 23;
            this.btnIn.Text = "还书";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.text);
            this.groupBox4.Controls.Add(this.txtBigDay);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtNow);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMoney);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDay);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtInDate1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtOutDate);
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
            this.groupBox4.Size = new System.Drawing.Size(504, 152);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(16, 120);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(56, 16);
            this.text.TabIndex = 34;
            this.text.Text = "规定天数";
            // 
            // txtBigDay
            // 
            this.txtBigDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBigDay.Location = new System.Drawing.Point(72, 120);
            this.txtBigDay.Name = "txtBigDay";
            this.txtBigDay.ReadOnly = true;
            this.txtBigDay.Size = new System.Drawing.Size(100, 21);
            this.txtBigDay.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(336, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "今天日期";
            // 
            // txtNow
            // 
            this.txtNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNow.Location = new System.Drawing.Point(392, 88);
            this.txtNow.Name = "txtNow";
            this.txtNow.ReadOnly = true;
            this.txtNow.Size = new System.Drawing.Size(100, 21);
            this.txtNow.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(336, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "罚款金额";
            // 
            // txtMoney
            // 
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(392, 120);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(176, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "超出天数";
            // 
            // txtDay
            // 
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDay.Location = new System.Drawing.Point(232, 120);
            this.txtDay.Name = "txtDay";
            this.txtDay.ReadOnly = true;
            this.txtDay.Size = new System.Drawing.Size(100, 21);
            this.txtDay.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(176, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "应还日期";
            // 
            // txtInDate1
            // 
            this.txtInDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInDate1.Location = new System.Drawing.Point(232, 88);
            this.txtInDate1.Name = "txtInDate1";
            this.txtInDate1.ReadOnly = true;
            this.txtInDate1.Size = new System.Drawing.Size(100, 21);
            this.txtInDate1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "借出日期";
            // 
            // txtOutDate
            // 
            this.txtOutDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutDate.Location = new System.Drawing.Point(72, 88);
            this.txtOutDate.Name = "txtOutDate";
            this.txtOutDate.ReadOnly = true;
            this.txtOutDate.Size = new System.Drawing.Size(100, 21);
            this.txtOutDate.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(352, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "价格";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(392, 56);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(176, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "出版日期";
            // 
            // txtBDate
            // 
            this.txtBDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBDate.Location = new System.Drawing.Point(232, 56);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.ReadOnly = true;
            this.txtBDate.Size = new System.Drawing.Size(100, 21);
            this.txtBDate.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(352, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "类型";
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtType.Location = new System.Drawing.Point(392, 24);
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
            this.label7.Location = new System.Drawing.Point(208, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "图书编号";
            // 
            // txtBID
            // 
            this.txtBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBID.Location = new System.Drawing.Point(264, 24);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(120, 21);
            this.txtBID.TabIndex = 12;
            // 
            // dgrdv
            // 
            this.dgrdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgrdv.Location = new System.Drawing.Point(531, 12);
            this.dgrdv.Name = "dgrdv";
            this.dgrdv.RowTemplate.Height = 23;
            this.dgrdv.Size = new System.Drawing.Size(10, 10);
            this.dgrdv.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BName";
            this.Column1.HeaderText = "图书名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BWriter";
            this.Column2.HeaderText = "作者";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TID";
            this.Column3.HeaderText = "类型";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BPublish";
            this.Column4.HeaderText = "出版社";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BDate";
            this.Column5.HeaderText = "出版日期";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BPrice";
            this.Column6.HeaderText = "价格";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ODate";
            this.Column7.HeaderText = "借出日期";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "应还日期";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "今天日期";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "longTime";
            this.Column10.HeaderText = "规定天数";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "超出天数";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "罚款金额";
            this.Column12.Name = "Column12";
            // 
            // frmBookIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgrdv);
            this.Name = "frmBookIn";
            this.Text = "还书";
            this.Load += new System.EventHandler(this.frmBookIn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox txtBigDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInDate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutDate;
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
        private System.Windows.Forms.DataGridView dgrdv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}