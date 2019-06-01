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
    public partial class frmBookOut : Form
    {
        public frmBookOut()
        {
            InitializeComponent();
        }

        private void frmBookOut_Load(object sender, EventArgs e)
        {

        }

        private void txtPID_KeyDown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pid = txtPID.Text;
            SqlParameter[] para = { new SqlParameter("@pid", SqlDbType.NChar, 10) };
            para[0].Value = pid;
            string SQLtxt="SELECT * FROM Person WHERE PID=@pid";
            object i = SQLHelper.GetObject(SQLtxt, para);
            if (i == null)
            {
                MessageBox.Show("借书证编号不存在", "提示");
                txtPID.Text = "";
            }
            else
            {
                //MessageBox.Show("借书证编号不存在", "提示");
                SqlParameter[] para1 = { new SqlParameter("@pid", SqlDbType.NChar, 10) };
                para1[0].Value = pid;
                dgrdv2.DataSource = SQLHelper.GetTable("SELECT * FROM person WHERE PID=@pid", para1);
                string name = dgrdv2.CurrentRow.Cells[1].Value.ToString().Trim();
                string sex = dgrdv2.CurrentRow.Cells[2].Value.ToString().Trim();
                string pn = dgrdv2.CurrentRow.Cells[4].Value.ToString().Trim();
                string identity = dgrdv2.CurrentRow.Cells[7].Value.ToString().Trim();
                string money = dgrdv2.CurrentRow.Cells[6].Value.ToString().Trim();
                txtPName.Text = name;
                txtPSex.Text = sex;
                txtPN.Text = pn;
                txtIden.Text = identity;
                txtMoney.Text = money;
                SqlParameter[] paras = { new SqlParameter("@pid", SqlDbType.NChar, 10), };
                paras[0].Value = pid;
                string Sqltxt = "SELECT * FROM Book WHERE BID IN (SELECT BID FROM BookOut WHERE PID=@pid AND isReturn=0)";
                dgrdv1.DataSource = SQLHelper.GetTable(Sqltxt, paras);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bid = txtBID.Text;
            SqlParameter[] para = { new SqlParameter("@bid", SqlDbType.NChar, 8) };
            para[0].Value = bid;
            string sqltxt = "SELECT * FROM book WHERE BID=@bid";
            object m = SQLHelper.GetObject(sqltxt,para);
            if (m == null)
            {
                MessageBox.Show("图书不存在，请重新输入", "提示");
                txtBID.Text = "";
            }
            else
            {
                SqlParameter[] para2 = { new SqlParameter("@bid", SqlDbType.NChar, 8) };
                para2[0].Value = bid;
                dgrdv3.DataSource = SQLHelper.GetTable("SELECT * FROM book WHERE BID=@bid", para2);
                //dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM book WHERE BID=@bid", para);
                string name = dgrdv3.CurrentRow.Cells[1].Value.ToString().Trim();
                string writer = dgrdv3.CurrentRow.Cells[2].Value.ToString().Trim();
                string publish = dgrdv3.CurrentRow.Cells[3].Value.ToString().Trim();
                string data = dgrdv3.CurrentRow.Cells[4].Value.ToString().Trim();
                string price = dgrdv3.CurrentRow.Cells[5].Value.ToString().Trim();
                string tid = dgrdv3.CurrentRow.Cells[7].Value.ToString().Trim();
                txtBName.Text = name;
                txtBDate.Text = data;
                txtPrice.Text = price;
                txtPublish.Text = publish;
                txtWriter.Text = writer;
                txtType.Text = tid;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            string date =dtp.Text;
            string pid=txtPID.Text;
            string bid=txtBID.Text;
            SqlParameter[] paras = {new SqlParameter("@bid", SqlDbType.NChar, 8),
                                       new SqlParameter("@pid", SqlDbType.NChar, 10),
                                    };
            paras[0].Value = bid;
            paras[1].Value = pid;
            string Sqltxt = "SELECT * FROM BookOut WHERE BID=@bid AND isReturn=0 AND PID=@pid";
            object m = SQLHelper.GetObject(Sqltxt,paras);
            if (m == null)
            {
                DateTime Date = Convert.ToDateTime(date);
                string sqltxt = string.Format("insert into BookOut (PID,BID,ODate,isReturn,isdelete) values ('{0}','{1}','{2}',0,0);", pid, bid, Date);
                int i = SQLHelper.ExcuteSQL(sqltxt);
                if (i != 0)
                {
                    MessageBox.Show("借书成功", "提示");
                    SqlParameter[] pas = { new SqlParameter("@pid", SqlDbType.NChar, 10), };
                    pas[0].Value = pid;
                    string txt = "SELECT * FROM Book WHERE BID IN (SELECT BID FROM BookOut WHERE PID=@pid AND isReturn=0)";
                    dgrdv1.DataSource = SQLHelper.GetTable(txt, pas);
                }
                else
                {
                    MessageBox.Show("借书失败", "提示");
                }
            }
            else
            {
                MessageBox.Show("这本书你已借，未还。不允许重复借书","提示");
            }
        }
    }
}
