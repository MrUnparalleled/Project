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
    public partial class frmBookQuery : Form
    {
        public frmBookQuery()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string writer = txtWriter.Text;
            if (id==""&&name==""&&writer=="")
            {
                MessageBox.Show("请输入图书编号或图书名或作者");
            }
            else
            {
                if (id != ""&&name==""&&writer=="")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BID = @id";
                    SqlParameter[] para = new SqlParameter[1];
                    para[0] = new SqlParameter("@id", SqlDbType.NChar, 8);
                    para[0].Value = id;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
                else if (id == "" && name != "" && writer == "")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BName = @name";
                    SqlParameter[] para = new SqlParameter[1];
                    para[0] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                    para[0].Value = name;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
                else if (id == "" && name == "" && writer != "")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BWriter = @writer";
                    SqlParameter[] para = new SqlParameter[1];
                    para[0] = new SqlParameter("@writer", SqlDbType.NVarChar, 50);
                    para[0].Value = writer;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
                else if (id == "" && name != "" && writer != "")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BName = @name AND BWriter=@writer";
                    SqlParameter[] para = new SqlParameter[2];
                    para[0] = new SqlParameter("@writer", SqlDbType.NVarChar, 50);
                    para[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                    para[0].Value = writer;
                    para[1].Value = name;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
                else if (id != "" && name == "" && writer != "")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BID = @id AND BWriter=@writer";
                    SqlParameter[] para = new SqlParameter[2];
                    para[0] = new SqlParameter("@id", SqlDbType.NChar, 8);
                    para[1] = new SqlParameter("@writer", SqlDbType.NVarChar, 50);
                    para[0].Value = id;
                    para[1].Value = writer;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
                else if (id != "" && name != "" && writer == "")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BID = @id AND BName=@name";
                    SqlParameter[] para = new SqlParameter[2];
                    para[0] = new SqlParameter("@id", SqlDbType.NChar, 8);
                    para[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                    para[0].Value = id;
                    para[1].Value = name;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
                else if (id != "" && name != "" && writer != "")
                {
                    string Sqltext = "SELECT * FROM Book WHERE BID = @id AND BName=@name AND BWriter=@writer";
                    SqlParameter[] para = new SqlParameter[3];
                    para[0] = new SqlParameter("@id", SqlDbType.NChar, 8);
                    para[1] = new SqlParameter("@name", SqlDbType.NVarChar, 100);
                    para[1] = new SqlParameter("@writer", SqlDbType.NVarChar, 50);
                    para[0].Value = id;
                    para[1].Value = name;
                    para[2].Value = writer;
                    this.dgrdv1.DataSource = SQLHelper.GetTable(Sqltext, para);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgrdv1.DataSource = null;
            txtID.Text = "";
            txtName.Text = "";
            txtWriter.Text = "";
        }
    }
}
