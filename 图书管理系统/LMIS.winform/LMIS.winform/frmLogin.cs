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
    public partial class frmLogin : Form
    {
        string connstr = "Server=PC-201705121654;DataBase=db_LMIS;Integrated Security=true";
        SqlConnection sqlconn;
        SqlCommand sqlcmd;
        public frmLogin()
        {
            InitializeComponent();
            sqlconn = new SqlConnection(connstr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtName.Text;
            string pwd = txtPassword.Text;

            if (txtName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入账户密码");
            }
            else
            {
                    if (rbtnManage.Checked)
                    {

                        string sqltext = "SELECT * FROM manager WHERE MName = @mname and Mcode = @pwd";
                        SqlParameter[] paras = new SqlParameter[2];
                        paras[0] = new SqlParameter("@mname", SqlDbType.NVarChar, 20);
                        paras[0].Value = id;
                        paras[1] = new SqlParameter("@pwd", SqlDbType.NChar, 32);
                        paras[1].Value = pwd;
                        object result = SQLHelper.GetObject(sqltext, paras);
                        if (result != null)
                        {
                            this.Hide();
                            MessageBox.Show("登录成功");
                            string Sqltext = string.Format("select manage,work,query from Manager where MName={0}", id);
                            DataTable dt;
                            dt = SQLHelper.GetTable(Sqltext);
                            string manage = dt.Rows[0][0].ToString();
                            string work = dt.Rows[0][1].ToString();
                            string query = dt.Rows[0][2].ToString();
                            frmMain db = new frmMain();
                            db.toolStripStatusLabel2.Text = "管理员 ";
                            db.toolStripStatusLabel3.Text =id.Trim();
                            if (manage == "True")
                            {
                                db.系统管理ToolStripMenuItem.Visible = true;
                                db.图书管理ToolStripMenuItem.Visible = true;
                                db.读者管理ToolStripMenuItem.Visible = true;
                                db.toolStripButton1.Visible = true;
                                db.toolStripButton2.Visible = true;

                            }
                            if (work == "True")
                            {
                                db.借还管理ToolStripMenuItem.Visible = true;
                                db.toolStripButton3.Visible = true;
                                db.toolStripButton4.Visible = true;
                            }
                            if (query=="True")
                            {
                                db.图书查询ToolStripMenuItem.Visible = true;
                                db.查询操作ToolStripMenuItem.Visible = true;
                            }
                            db.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("登录失败","警告");
                            this.txtName.Text = "";
                            this.txtPassword.Text= "";
                            return;
                        }
                    }
                    if (rbtnPerson.Checked)
                    {
                        string sqltext = "SELECT * FROM Person WHERE PID = @id and PCode = @pwd";
                        SqlParameter[] paras = new SqlParameter[2];
                        paras[0] = new SqlParameter("@id", SqlDbType.NChar, 10);
                        paras[0].Value = id;
                        paras[1] = new SqlParameter("@pwd", SqlDbType.NVarChar, 32);
                        paras[1].Value = pwd;
                        object result = SQLHelper.GetObject(sqltext, paras);
                        if (result != null)
                        {

                            this.Hide();
                            MessageBox.Show("登录成功");
                            frmMain db = new frmMain();
                            db.Tag = this.FindForm();
                            db.toolStripStatusLabel2.Text = "读者 ";
                            db.toolStripStatusLabel3.Text = id;
                            db.图书查询ToolStripMenuItem.Visible = true;
                            db.查询操作ToolStripMenuItem.Visible = true;
                            db.借阅查询ToolStripMenuItem.Visible = true;
                            db.toolStripButton7.Visible = true;
                            db.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("登录失败","警告");
                            this.txtName.Text = "";
                            this.txtPassword.Text = "";
                            return;
                        }
                    }
            }
            this.Close();
        }
    }
}
