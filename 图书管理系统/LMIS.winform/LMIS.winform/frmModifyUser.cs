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
    public partial class frmModifyUser : Form
    {
        public frmModifyUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int m = 0;
            if (checkmanage.CheckState == CheckState.Checked)
            {
                SqlParameter[] paras = {new SqlParameter("@manage", SqlDbType.Bit) ,
                                        new SqlParameter("@name", SqlDbType.NVarChar,20) ,
                                    };
                paras[0].Value = true;
                paras[1].Value = txtName.Text;
                string sqltext = "UPDATE Manager SET manage=@manage WHERE  MName=@name";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    m++;
                }
                else
                {
                    m = 0;
                }
            }
            if (checkwork.CheckState == CheckState.Checked)
            {
                SqlParameter[] paras = {new SqlParameter("@work", SqlDbType.Bit) ,
                                        new SqlParameter("@name", SqlDbType.NVarChar,20) ,
                                    };
                paras[0].Value = true;
                paras[1].Value = txtName.Text;
                string sqltext = "UPDATE Manager SET [work]=@work WHERE  MName=@name";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    m++;
                }
                else
                {
                    m = 0;
                }
            }
            if (checkmanage.CheckState==CheckState.Unchecked)
            {
                SqlParameter[] paras = {new SqlParameter("@manage", SqlDbType.Bit) ,
                                        new SqlParameter("@name", SqlDbType.NVarChar,20) ,
                                    };
                paras[0].Value = false;
                paras[1].Value = txtName.Text;
                string sqltext = "UPDATE Manager SET manage=@manage WHERE  MName=@name";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    m++;
                }
                else
                {
                    m = 0;
                }
            }
            if (checkwork.CheckState==CheckState.Unchecked)
            {
                SqlParameter[] paras = {new SqlParameter("@work", SqlDbType.Bit) ,
                                        new SqlParameter("@name", SqlDbType.NVarChar,20) ,
                                    };
                paras[0].Value = false;
                paras[1].Value = txtName.Text;
                string sqltext = "UPDATE Manager SET [work]=@work WHERE  MName=@name";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    m++;
                }
                else
                {
                    m = 0;
                }
            }
            if (checkBox1.CheckState == CheckState.Checked)
            {
                SqlParameter[] paras = {new SqlParameter("@work", SqlDbType.Bit) ,
                                        new SqlParameter("@name", SqlDbType.NVarChar,20) ,
                                    };
                paras[0].Value = true;
                paras[1].Value = txtName.Text;
                string sqltext = "UPDATE Manager SET [query]=@work WHERE  MName=@name";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    m++;
                }
                else
                {
                    m = 0;
                }
            }
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                SqlParameter[] paras = {new SqlParameter("@work", SqlDbType.Bit) ,
                                        new SqlParameter("@name", SqlDbType.NVarChar,20) ,
                                    };
                paras[0].Value = false;
                paras[1].Value = txtName.Text;
                string sqltext = "UPDATE Manager SET query=@work WHERE  MName=@name";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    m++;
                }
                else
                {
                    m = 0;
                }
            }
            if (m==0)
            {
                MessageBox.Show("修改失败","提示");
            }
            else
            {
                MessageBox.Show("修改成功","提示");
            }
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
