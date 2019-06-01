namespace LMIS.Winform
{
    partial class frmPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.dgrdv = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(163, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "借 阅 者 信 息";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(483, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "添加";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(483, 252);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "退出";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Location = new System.Drawing.Point(483, 188);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "删除";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.ForeColor = System.Drawing.Color.Black;
            this.btnModify.Location = new System.Drawing.Point(483, 124);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 28;
            this.btnModify.Text = "修改";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dgrdv
            // 
            this.dgrdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.PName,
            this.PSex,
            this.PPhone,
            this.PN,
            this.PCode,
            this.PMoney,
            this.Identity,
            this.PRemark,
            this.sys});
            this.dgrdv.Location = new System.Drawing.Point(12, 51);
            this.dgrdv.Name = "dgrdv";
            this.dgrdv.RowTemplate.Height = 23;
            this.dgrdv.Size = new System.Drawing.Size(457, 237);
            this.dgrdv.TabIndex = 33;
            // 
            // PID
            // 
            this.PID.DataPropertyName = "PID";
            this.PID.HeaderText = "借书证编号";
            this.PID.Name = "PID";
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.HeaderText = "姓名";
            this.PName.Name = "PName";
            // 
            // PSex
            // 
            this.PSex.DataPropertyName = "PSex";
            this.PSex.HeaderText = "性别";
            this.PSex.Name = "PSex";
            // 
            // PPhone
            // 
            this.PPhone.DataPropertyName = "PPhone";
            this.PPhone.HeaderText = "电话";
            this.PPhone.Name = "PPhone";
            // 
            // PN
            // 
            this.PN.DataPropertyName = "PN";
            this.PN.HeaderText = "身份证";
            this.PN.Name = "PN";
            // 
            // PCode
            // 
            this.PCode.DataPropertyName = "PCode";
            this.PCode.HeaderText = "密码";
            this.PCode.Name = "PCode";
            // 
            // PMoney
            // 
            this.PMoney.DataPropertyName = "PMoney";
            this.PMoney.HeaderText = "罚款";
            this.PMoney.Name = "PMoney";
            // 
            // Identity
            // 
            this.Identity.DataPropertyName = "identity";
            this.Identity.HeaderText = "身份";
            this.Identity.Name = "Identity";
            // 
            // PRemark
            // 
            this.PRemark.DataPropertyName = "PRemark";
            this.PRemark.HeaderText = "备注";
            this.PRemark.Name = "PRemark";
            // 
            // sys
            // 
            this.sys.DataPropertyName = "sys";
            this.sys.HeaderText = "权限";
            this.sys.Name = "sys";
            // 
            // frmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 314);
            this.Controls.Add(this.dgrdv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Name = "frmPerson";
            this.Text = "借阅者信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dgrdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn sys;

    }
}