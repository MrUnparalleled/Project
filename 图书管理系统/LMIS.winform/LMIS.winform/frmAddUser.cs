using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using ADO;

namespace LMIS.Winform
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string UserName = this.txtName.Text;
            string UserPassword = this.txtPassword.Text;
            string UserPassword2 = this.txtPasswordNew.Text;
            int i=0;
            if (checkBox1.CheckState==CheckState.Unchecked&&checkBox2.CheckState==CheckState.Unchecked&&checkBox3.CheckState==CheckState.Unchecked)
            {
                MessageBox.Show("请选择身份","提示");
            }
            if (txtName.Text == "" || txtPassword.Text == "" || txtPasswordNew.Text == "")
            {
                MessageBox.Show("请输入账户密码");
            }
            else
            {
                if (UserPassword != UserPassword2)
                {
                    MessageBox.Show("两次密码不相同，请重新输入");
                    return;
                }
                else
                {
                    string sqltext = "SELECT * FROM manager WHERE MName = @mname";
                    SqlParameter[] paras = new SqlParameter[1];
                    paras[0] = new SqlParameter("@mname", SqlDbType.NVarChar, 20);
                    paras[0].Value = UserName;
                    object result = SQLHelper.GetObject(sqltext, paras);
                    if (result != null)
                    {
                        MessageBox.Show("该用户已存在");
                        return;
                    }
                    else
                    {
                        if (checkBox1.CheckState == CheckState.Checked)
                        {
                            sqltext = string.Format("insert into manager (MName,MCode,manage) values ('{0}','{1}',1);", UserName, UserPassword);
                            int n = SQLHelper.ExcuteSQL(sqltext);
                            if (n > 0)
                            {
                                i++;
                            }
                            else
                            {
                                i = 0;
                            }
                        }

                        if (checkBox2.CheckState == CheckState.Checked)
                        {
                            if (i == 0)
                            {
                                sqltext = string.Format("insert into manager (MName,MCode,work) values ('{0}','{1}',1);", UserName, UserPassword);
                                int n = SQLHelper.ExcuteSQL(sqltext);
                                if (n > 0)
                                {
                                    i++;
                                }
                                else
                                {
                                    i = 0;
                                }
                            }
                            else
                            {
                                SqlParameter[] para = {new SqlParameter("@username", SqlDbType.NVarChar,20) ,
                                    };
                                para[0].Value = UserName;
                                string Sqltext = "UPDATE Manager SET work='true' WHERE  MName=@username";
                                int n = SQLHelper.ExcuteSQL(Sqltext, para);
                                if (n != 0)
                                {
                                    i++;
                                }
                                else
                                {
                                    i=0;
                                }
                            }
                        }
                        if (checkBox3.CheckState == CheckState.Checked)
                        {
                            if (i==0)
                            {
                            sqltext = string.Format("insert into manager (MName,MCode,query) values ('{0}','{1}',1);", UserName, UserPassword);
                            int n = SQLHelper.ExcuteSQL(sqltext);
                            if (n > 0)
                            {
                                i++;
                            }
                            else
                            {
                                i = 0;
                            }
                            }
                            else
                            {
                                SqlParameter[] para = {new SqlParameter("@username", SqlDbType.NVarChar,20) ,
                                    };
                                para[0].Value = UserName;
                                string Sqltext = "UPDATE Manager SET query='true'WHERE  MName=@username";
                                int n = SQLHelper.ExcuteSQL(Sqltext, para);
                                if (n != 0)
                                {
                                    i++;
                                }
                                else
                                {
                                    i=0;
                                }                                
                            }
                        }
                        if (checkBox1.CheckState == CheckState.Unchecked)
                        {
                            if (i==0)
                            {
                            sqltext = string.Format("insert into manager (MName,MCode,work) values ('{0}','{1}',0);", UserName, UserPassword);
                            int n = SQLHelper.ExcuteSQL(sqltext);
                            if (n > 0)
                            {
                                i++;
                            }
                            else
                            {
                                i = 0;
                            }
                            }
                            else
                            {
                                SqlParameter[] para = {new SqlParameter("@username", SqlDbType.NVarChar,20) ,
                                    };
                                para[0].Value = UserName;
                                string Sqltext = "UPDATE Manager SET manage='false' WHERE  MName=@username";
                                int n = SQLHelper.ExcuteSQL(Sqltext, para);
                                if (n != 0)
                                {
                                    i++;
                                }
                                else
                                {
                                    i=0;
                                }
                            }
                        } 
                        if (checkBox2.CheckState == CheckState.Unchecked)
                        {
                            if(i==0)
                            {
                            sqltext = string.Format("insert into manager (MName,MCode,work) values ('{0}','{1}',0);", UserName, UserPassword);
                            int n = SQLHelper.ExcuteSQL(sqltext);
                            if (n > 0)
                            {
                                i++;
                            }
                            else
                            {
                                i = 0;
                            }
                            }
                            else
                            {
                                SqlParameter[] para = {new SqlParameter("@username", SqlDbType.NVarChar,20) ,
                                    };
                                para[0].Value = UserName;
                                string Sqltext = "UPDATE Manager SET work='false' WHERE  MName=@username";
                                int n = SQLHelper.ExcuteSQL(Sqltext, para);
                                if (n != 0)
                                {
                                    i++;
                                }
                                else
                                {
                                    i=0;
                                }
                            }
                        } 
                    if (checkBox3.CheckState == CheckState.Unchecked)
                        {
                        if(i==0)
                        {
                            sqltext = string.Format("insert into manager (MName,MCode,query) values ('{0}','{1}',0);", UserName, UserPassword);
                            int n = SQLHelper.ExcuteSQL(sqltext);
                            if (n > 0)
                            {
                                i++;
                            }
                            else
                            {
                                i = 0;
                            }
                        }
                        else
                        {
                                SqlParameter[] para = {new SqlParameter("@username", SqlDbType.NVarChar,20) ,
                                    };
                                para[0].Value = UserName;
                                string Sqltext = "UPDATE Manager SET query='false' WHERE  MName=@username";
                                int n = SQLHelper.ExcuteSQL(Sqltext, para);
                                if (n != 0)
                                {
                                    i++;
                                }
                                else
                                {
                                    i=0;
                                }
                        }
                        }
                    }
                }
            }
            if (i!=0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            this.Close();
        }
    }
}
