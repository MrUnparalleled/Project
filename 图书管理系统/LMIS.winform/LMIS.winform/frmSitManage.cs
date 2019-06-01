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
    public partial class frmSitManage : Form
    {
        public frmSitManage()
        {
            InitializeComponent();
            timer1.Interval = 4*3600*1000;
            timer1.Start();
        }

        private void frmSitManage_Load(object sender, EventArgs e)
        {
            ReLoadData();
        }

        private void ReLoadData()
        {
            listView1.Clear();
            string sqltxt = "SELECT * FROM Seat";
            DataTable dt = SQLHelper.GetTable(sqltxt);
            foreach (DataRow item in dt.Rows)
            {
                ListViewItem lvi;
                if (item["S_Status"].ToString() == "1")
                {
                    lvi = new ListViewItem(item["S_NO"].ToString(), 1);
                }
                else
                {
                    lvi = new ListViewItem(item["S_NO"].ToString(), 0);
                }
                listView1.Items.Add(lvi);
            }
        }

        private void 占该位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    SqlParameter[] para1 = { new SqlParameter("@id", SqlDbType.NVarChar, 15), };
                    para1[0].Value = listView1.SelectedItems[0].Text;
                    string sqltxt1 = "SELECT * FROM Seat WHERE S_NO=@id AND S_Status='1'";
                    object m1 = SQLHelper.GetObject(sqltxt1, para1);
                    if (m1 != null)
                    {
                        SqlParameter[] para2 = { new SqlParameter("@id", SqlDbType.NVarChar, 15),
                                           new SqlParameter("@name", SqlDbType.NChar, 10)};
                        para2[0].Value = listView1.SelectedItems[0].Text;
                        para2[1].Value = txt1.Text;
                        string sqltxt2 = "SELECT * FROM Seat WHERE S_NO=@id AND Sgy=@name";
                        object m2 = SQLHelper.GetObject(sqltxt2, para2);
                        if (m2 != null)
                        {
                            MessageBox.Show("您已占该位", "提示");
                        }
                        else
                        {
                            MessageBox.Show("该位置已被人占了", "提示");
                        }
                    }
                    else
                    {
                        SqlParameter[] para = { new SqlParameter("@id", SqlDbType.NVarChar, 15),
                                      new SqlParameter("@name", SqlDbType.NChar, 10)};
                        para[0].Value = listView1.SelectedItems[0].Text;
                        para[1].Value = txt1.Text;
                        string Sqltxt = "SELECT * FROM Seat WHERE S_ID=@name";
                        object m = SQLHelper.GetObject(Sqltxt, para);
                        if (m != null)
                        {
                            MessageBox.Show("一个账户只能占一个位置", "提示");
                            return;
                        }
                        else
                        {
                            if (listView1.SelectedItems[0] != null)
                            {
                                SqlParameter[] para3 = { new SqlParameter("@id", SqlDbType.NVarChar, 15),
                                      new SqlParameter("@name", SqlDbType.NChar, 10)};
                                para3[0].Value = listView1.SelectedItems[0].Text;
                                para3[1].Value = txt1.Text;
                                string sqltxt3 = "UPDATE Seat SET S_Status='1',S_ID=@name WHERE S_NO=@id";
                                SQLHelper.ExcuteSQL(sqltxt3, para3);
                            }
                        }
                    }

                    ReLoadData();
                }
                else
                {
                    MessageBox.Show("请选择座位", "提示");
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void 取消站位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0] != null)
                {
                    SqlParameter[] para1 = { new SqlParameter("@id", SqlDbType.NVarChar, 15), };
                    para1[0].Value = listView1.SelectedItems[0].Text;
                    string sqltxt1 = "SELECT * FROM Seat WHERE S_NO=@id AND S_Status='0'";
                    object m1 = SQLHelper.GetObject(sqltxt1, para1);
                    if (m1 != null)
                    {

                    }
                    else
                    {
                        SqlParameter[] para = { new SqlParameter("@id", SqlDbType.NVarChar, 15),
                                      new SqlParameter("@name", SqlDbType.NChar, 10)};
                        para[0].Value = listView1.SelectedItems[0].Text;
                        para[1].Value = txt1.Text;
                        string sqltxt = "SELECT * FROM Seat WHERE S_NO=@id AND S_ID=@name";
                        SqlParameter[] para10 = { new SqlParameter("@id", SqlDbType.NVarChar, 15),
                                      new SqlParameter("@name", SqlDbType.NChar, 10)};
                        para10[0].Value = listView1.SelectedItems[0].Text;
                        para10[1].Value = txt1.Text;
                        object m = SQLHelper.GetObject(sqltxt, para10);
                        if (m != null)
                        {
                            sqltxt = "UPDATE Seat SET S_Status='0',S_ID=NULL WHERE S_NO=@id AND S_ID=@name";
                            object n = SQLHelper.GetObject(sqltxt, para);
                            MessageBox.Show("已取消", "提示");
                        }
                        else
                        {
                            MessageBox.Show("不是您的位置，无法取消占位", "提示");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请选择座位", "提示");
                }
                ReLoadData();
            }
            catch (Exception)
            {
                
                return;
            }
        }

        private void 座位信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt;
                SqlParameter[] para = { new SqlParameter("@id", SqlDbType.NVarChar, 15) };
                para[0].Value = listView1.SelectedItems[0].Text;
                string sqltxt = "SELECT * FROM Seat WHERE S_NO=@id";
                dt = SQLHelper.GetTable(sqltxt, para);
                string no = dt.Rows[0][0].ToString();
                string remark = dt.Rows[0][3].ToString();
                string name = dt.Rows[0][4].ToString();
                frmSeatMessage db = new frmSeatMessage();
                db.label4.Text = no;
                db.label5.Text = remark;
                db.label6.Text = name;
                db.ShowDialog();
            }
            catch (Exception)
            {
                
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //SqlParameter[] para3 = { new SqlParameter("@id", SqlDbType.NVarChar, 15),
            //                          new SqlParameter("@name", SqlDbType.NChar, 10)};
            //para3[0].Value = listView1.SelectedItems[0].Text;
            //para3[1].Value = txt1.Text;
            string sqltxt3 = "UPDATE Seat SET S_Status='0',S_ID=NULL";
            SQLHelper.ExcuteSQL(sqltxt3);
            ReLoadData();
        }
    }
}
