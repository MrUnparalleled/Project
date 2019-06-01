namespace LMIS.Winform
{
    partial class frmModifyCode
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtPasswordNew2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 64;
            this.label4.Text = "新 密 码";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswordNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordNew.Location = new System.Drawing.Point(93, 87);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(120, 21);
            this.txtPasswordNew.TabIndex = 57;
            // 
            // txtPasswordNew2
            // 
            this.txtPasswordNew2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordNew2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswordNew2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPasswordNew2.Location = new System.Drawing.Point(93, 119);
            this.txtPasswordNew2.Name = "txtPasswordNew2";
            this.txtPasswordNew2.PasswordChar = '*';
            this.txtPasswordNew2.Size = new System.Drawing.Size(120, 21);
            this.txtPasswordNew2.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "密码确认";
            // 
            // txtPWD
            // 
            this.txtPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWD.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPWD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPWD.Location = new System.Drawing.Point(93, 55);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(120, 21);
            this.txtPWD.TabIndex = 56;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(93, 23);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(120, 21);
            this.txtName.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "密    码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "用户名称";
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(136, 159);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 60;
            this.btClose.Text = "返回";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(32, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "确定";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(13, 189);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(10, 21);
            this.txt.TabIndex = 65;
            this.txt.Visible = false;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // frmModifyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 213);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordNew);
            this.Controls.Add(this.txtPasswordNew2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btnSave);
            this.Name = "frmModifyCode";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtPasswordNew2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txt;
    }
}