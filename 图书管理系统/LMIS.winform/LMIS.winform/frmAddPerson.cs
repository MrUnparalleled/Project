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
    public partial class frmAddPerson : Form
    {
        public frmAddPerson()
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
            string sex = this.cboSex.Text;
            string pn = this.txtPN.Text;
            string phone = this.txtPhone.Text;
            string identity = this.cboId.Text;
            string code = this.txtCode.Text;
            string money = this.txtMoney.Text;
            string remark = this.txtRemark.Text;

            if (txtID.Text.Trim() == "" || txtName.Text.Trim() == "" || txtPN.Text.Trim() == "" || txtPhone.Text.Trim() == "" || txtCode.Text.Trim() == "" || txtMoney.Text.Trim() == "" || txtRemark.Text.Trim() == "")
                MessageBox.Show("请填写完整信息", "提示");
            else
            {
                string sqltext = "SELECT * FROM Person WHERE PID = @id";
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@id", SqlDbType.NChar, 8);
                paras[0].Value = id;
                object result = SQLHelper.GetObject(sqltext, paras);
                if (result != null)
                {
                    MessageBox.Show("该借阅者已存在");
                    return;
                }
                sqltext = string.Format("insert into Person (PID,PName,PSex,PPhone,PN,PCode,PMoney,[identity],PRemark) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');", id, name, sex, phone, pn, code, money, identity, remark);
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
