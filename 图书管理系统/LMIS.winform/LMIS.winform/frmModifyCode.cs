using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADO;
using System.IO;
using System.Data.SqlClient;

namespace LMIS.Winform
{
    public partial class frmModifyCode : Form
    {
        public frmModifyCode()
        {
            InitializeComponent();
            this.FormClosing += (o, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = MessageBox.Show("确定退出该程序？", this.Text, MessageBoxButtons.OKCancel) != DialogResult.OK;
                }
            };
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain.f0.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pwd1 = txtPasswordNew.Text;
            string pwd2 = txtPasswordNew2.Text;
            string pwd = txtPWD.Text;
            if (pwd==""||pwd1==""||pwd2=="")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            if (pwd1!=pwd2)
            {
                MessageBox.Show("两次输入密码不一致");
                txtPasswordNew.Text = "";
                txtPasswordNew2.Text = "";
                return;
            }
            else
            {

                    if (txt.Text == "管理员 ")
                    {
                        string Sqltext = "SELECT * FROM Manager WHERE MName = @id AND MCode=@pwd";
                        SqlParameter[] para = new SqlParameter[2];
                        para[0] = new SqlParameter("@id", SqlDbType.NVarChar, 20);
                        para[1] = new SqlParameter("@pwd", SqlDbType.NChar, 32);
                        para[0].Value = txtName.Text;
                        para[1].Value = pwd;
                        object result = SQLHelper.GetObject(Sqltext, para);
                        //检查密码真确与否
                        if (result == null)
                        {
                            MessageBox.Show("密码错误");
                            this.txtPWD.Text = "";
                            this.txtPasswordNew.Text = "";
                            this.txtPasswordNew2.Text = "";
                        }
                        else
                        {
                                SqlParameter[] paras = { new SqlParameter("@id", SqlDbType.NVarChar, 20) ,
                                        new SqlParameter("@pwd", SqlDbType.NChar, 32) ,
                                        };
                                paras[0].Value = txtName.Text;
                                paras[1].Value = pwd1;
                            string sqltext = "UPDATE Manager SET MCode=@pwd WHERE  MName=@id";
                            int i = SQLHelper.ExcuteSQL(sqltext, paras);
                            if (i == 0)
                            {
                                MessageBox.Show("更新失败","错误");
                                this.txtPWD.Text = "";
                                this.txtPasswordNew.Text = "";
                                this.txtPasswordNew2.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("更新成功，请重新登录","提示");
                                this.txtPWD.Text = "";
                                this.txtPasswordNew.Text = "";
                                this.txtPasswordNew2.Text = "";
                                this.Hide();
                                frmLogin db = new frmLogin();
                                db.ShowDialog();
                            }
                        }
                    }
                    else if (txt.Text == "读者 ")
                    {
                        string Sqltext = "SELECT * FROM Person WHERE PID = @id AND PCode=@pwd";
                        SqlParameter[] para = new SqlParameter[2];
                        para[0] = new SqlParameter("@id", SqlDbType.NChar, 10);
                        para[1] = new SqlParameter("@pwd", SqlDbType.NVarChar, 32);
                        para[0].Value = txtName.Text;
                        para[1].Value = pwd;
                        object result = SQLHelper.GetObject(Sqltext, para);
                        //检查密码真确与否
                        if (result == null)
                        {
                            MessageBox.Show("密码错误");
                            this.txtPWD.Text = "";
                            this.txtPasswordNew.Text = "";
                            this.txtPasswordNew2.Text = "";
                        }
                        else
                        {
                            SqlParameter[] paras = { new SqlParameter("@id", SqlDbType.NVarChar, 20) ,
                                        new SqlParameter("@pwd", SqlDbType.NChar, 32) ,
                                        };
                            paras[0].Value = txtName.Text;
                            paras[1].Value = pwd1;
                            string sqltext = "UPDATE Person SET PCode=@pwd WHERE  PID=@id";
                            int i = SQLHelper.ExcuteSQL(sqltext, paras);
                            if (i == 0)
                            {
                                MessageBox.Show("更新失败","错误");
                                this.txtPWD.Text = "";
                                this.txtPasswordNew.Text = "";
                                this.txtPasswordNew2.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("更新成功，请重新登录", "提示");
                                this.txtPWD.Text = "";
                                this.txtPasswordNew.Text = "";
                                this.txtPasswordNew2.Text = "";
                                this.Hide();
                                frmLogin db = new frmLogin();
                                db.ShowDialog();
                            }
                        }
                    }
                }
            //this.Close();
            }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }

