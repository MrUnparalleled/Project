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
    public partial class frmBookIn : Form
    {
        public frmBookIn()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBID.Text!=""&&txtPID.Text!="")
            {
                string bid = txtBID.Text;
                string pid = txtPID.Text;
                SqlParameter[] para = {new SqlParameter("@bid", SqlDbType.NChar, 8),
                                       new SqlParameter("@pid", SqlDbType.NChar, 10),
                                    };
                para[0].Value = bid;
                para[1].Value = pid;
                string Sqltxt = "SELECT * FROM BookOut WHERE BID=@bid AND PID=@pid AND isReturn=0";
                object i = SQLHelper.GetObject(Sqltxt,para);
                if (i == null)
                {
                    MessageBox.Show("借阅信息不存在", "提示");
                    txtBID.Text = "";
                    txtPID.Text = "";
                    txtBDate.Text = "";
                    txtBigDay.Text = "";
                    txtBName.Text = "";
                    txtDay.Text = "";
                    txtInDate1.Text = "";
                    txtMoney.Text = "";
                    txtNow.Text = "";
                    txtOutDate.Text = "";
                    txtPrice.Text = "";
                    txtPublish.Text = "";
                    txtType.Text = "";
                    txtWriter.Text = "";
                }
                else
                {
                    SqlParameter[] paras = {new SqlParameter("@bid", SqlDbType.NChar, 8),
                                       new SqlParameter("@pid", SqlDbType.NChar, 10),
                                    };
                    paras[0].Value = bid;
                    paras[1].Value = pid;
                    string sqltxt = "SELECT Book.BName,Book.BWriter,Book.TID,Book.BPublish,Book.BDate,Book.BPrice,BookOut.ODate,[Identity].longTime FROM Book,BookOut,[Identity],Person WHERE book.BID=@bid AND BookOut.PID=@pid and BookOut.BID=@bid and [Identity].[identity]=Person.[identity] and Person.PID=BookOut.PID and BookOut.isReturn=0";
                    dgrdv.DataSource = SQLHelper.GetTable(sqltxt, paras);
                    this.txtBName.Text = dgrdv.CurrentRow.Cells[4].Value.ToString().Trim();
                    this.txtWriter.Text = dgrdv.CurrentRow.Cells[5].Value.ToString().Trim();
                    this.txtType.Text = dgrdv.CurrentRow.Cells[6].Value.ToString().Trim();
                    this.txtPublish.Text = dgrdv.CurrentRow.Cells[7].Value.ToString().Trim();
                    this.txtPrice.Text = dgrdv.CurrentRow.Cells[9].Value.ToString().Trim();
                    this.txtBDate.Text = dgrdv.CurrentRow.Cells[8].Value.ToString().Trim();
                    this.txtOutDate.Text = dgrdv.CurrentRow.Cells[10].Value.ToString().Trim();
                    this.txtBigDay.Text = dgrdv.CurrentRow.Cells[11].Value.ToString().Trim();


                    DateTime Out = Convert.ToDateTime(txtOutDate.Text);

                    DateTime date = Convert.ToDateTime(txtNow.Text);
                    int bigday = int.Parse(txtBigDay.Text);
                    DateTime Sin = Out.AddDays(bigday);
                    txtInDate1.Text = Sin.ToString();
                    if (date>Sin)
                    {
                        TimeSpan a = date - Sin;
                        string b = a.Days.ToString();
                        txtDay.Text = b;
                        double money = double.Parse(txtDay.Text);
                        money = money * 2;
                        txtMoney.Text = Convert.ToString(money);
                    }
                    else
                    {
                        txtDay.Text = "0";
                        double money = double.Parse(txtDay.Text);
                        money = money * 2;
                        txtMoney.Text = Convert.ToString(money);
                    }



                }
            }
            else
            {
                MessageBox.Show("请输入完整信息","提示");
            }
        }

        private void frmBookIn_Load(object sender, EventArgs e)
        {
            txtNow.Text = System.DateTime.Now.ToShortDateString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (txtPID.Text == "" || txtBID.Text == "")
            {
                MessageBox.Show("请输入借书证号、图书编号", "提示");
            }
            else
            {
                SqlParameter[] Paras = {new SqlParameter("@money", SqlDbType.Float),
                                       new SqlParameter("@bid", SqlDbType.NChar, 10),
                                    };

                //Paras[0].Value = Convert.ToDouble(txtMoney.Text);
                Paras[0].Value = txtMoney.Text;
                Paras[1].Value = txtPID.Text;
                string sqltxt = "UPDATE Person SET PMoney= PMoney+@money WHERE PID='1629210070'";
                object m = SQLHelper.GetObject(sqltxt, Paras);
                SqlParameter[] Para = {new SqlParameter("@bid", SqlDbType.NChar, 8),
                                       new SqlParameter("@pid", SqlDbType.NChar, 10),
                                       new SqlParameter("@odate", SqlDbType.DateTime),
                                    };
                Para[0].Value = txtBID.Text;
                Para[1].Value = txtPID.Text;
                Para[2].Value = txtOutDate.Text;
                string txt = "UPDATE BookOut SET isReturn=1,isdelete=0 WHERE BID=@bid AND PID=@pid";
                object M = SQLHelper.ExcuteSQL(txt, Para);
                if (M == null)
                {
                    MessageBox.Show("还书失败", "提示");
                }
                else
                {
                    MessageBox.Show("还书成功", "提示");
                }
            }
        }
    }
}
