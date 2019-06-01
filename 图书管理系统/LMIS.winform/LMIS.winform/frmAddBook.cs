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
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;
            string name = this.txtName.Text;
            string writer = this.txtWriter.Text;
            string date = this.dtp1.Text;
            string publish = this.txtPublish.Text;
            string type = this.cboType.Text;
            string num = this.txtNum.Text;
            string price = this.txtPrice.Text;
            string remark = this.txtRemark.Text;
            DateTime Date = Convert.ToDateTime(date);

            if (txtID.Text.Trim() == "" || txtName.Text.Trim() == "" || txtWriter.Text.Trim() == "" || txtPublish.Text.Trim() == "" || txtNum.Text.Trim() == "" || txtPrice.Text.Trim() == "" || txtRemark.Text.Trim() == "")
                MessageBox.Show("请填写完整信息", "提示");
            else
            {
                string sqltext = "SELECT * FROM Book WHERE BID = @id";
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@id", SqlDbType.NChar, 8);
                paras[0].Value = id;
                object result = SQLHelper.GetObject(sqltext, paras);
                if (result != null)
                {
                    MessageBox.Show("该图书已存在");
                    return;
                }
                sqltext = string.Format("insert into Book (BID,BName,BWriter,BPublish,BDate,BPrice,BNum,TID,BRemark) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", id, name, writer,publish,Date,price,num,type,remark);
                int n = SQLHelper.ExcuteSQL(sqltext);
                if (n > 0)
                {
                    MessageBox.Show("添加成功!");
                    return;
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }

            }
            this.Close();
        }
    }
}
