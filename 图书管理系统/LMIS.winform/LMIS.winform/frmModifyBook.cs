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
    public partial class frmModifyBook : Form
    {
        public frmModifyBook()
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
            string num = this.txtNum.Text;
            string writer = this.txtWriter.Text;
            string date = this.dtp1.Text;
            string publish = this.txtPublish.Text;
            string price = this.txtPrice.Text;
            string type = this.txtType.Text;
            string remark = this.txtRemark.Text;
            int Num =int.Parse(num);
            float Price = float.Parse(price);
            DateTime Date=Convert.ToDateTime(date);
            if (id == "" || name == "" || num == "" || writer == "" || date == "" || publish == "" || price == "" || type == "" || remark == "")
            {
                MessageBox.Show("请输入完整信息");
            }
            else
            {
                SqlParameter[] paras = { new SqlParameter("@id", SqlDbType.NChar, 8) ,
                                   new SqlParameter("@name", SqlDbType.NVarChar, 100) ,
                                   new SqlParameter("@num", SqlDbType.Int) ,
                                   new SqlParameter("@writer", SqlDbType.NVarChar, 50) ,
                                   new SqlParameter("@date", SqlDbType.DateTime) ,
                                   new SqlParameter("@publish", SqlDbType.NVarChar, 30) ,
                                   new SqlParameter("@price", SqlDbType.Float) ,
                                   new SqlParameter("@type", SqlDbType.NVarChar, 20) ,
                                   new SqlParameter("@remark", SqlDbType.NVarChar, 200) ,
                                   };
                paras[0].Value = id;
                paras[1].Value = name;
                paras[3].Value = writer;
                paras[5].Value = publish;
                paras[4].Value = Date;
                paras[6].Value = Price;
                paras[2].Value = Num;
                paras[7].Value = type;
                paras[8].Value = remark;
                string sqltext = "UPDATE Book SET BID=@id,BName=@name,BNum=@num,BWriter=@writer,BDate=@date,BPublish=@publish,BPrice=@price,TID=@type,BRemark=@remark WHERE  BID=@id";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
           this.Close();
        }
    }
}
