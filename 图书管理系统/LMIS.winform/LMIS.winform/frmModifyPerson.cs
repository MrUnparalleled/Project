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
    public partial class frmModifyPerson : Form
    {
        public frmModifyPerson()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = this.txtName.Text;
            string sex = this.cboSex.Text;
            string pn = this.txtPN.Text;
            string phone = this.txtPhone.Text;
            string pwd = this.txtCode.Text;
            string money = this.txtMoney.Text;
            string remark = this.txtRemark.Text;
            float Money = float.Parse(money);
            if (name == "" || sex == "" || pn == "" || phone == "" || pwd == "" || money == "")
            {
                MessageBox.Show("请输入完整信息");
            }
            else
            {
                SqlParameter[] paras = {new SqlParameter("@name", SqlDbType.NVarChar, 20) ,
                                   new SqlParameter("@sex", SqlDbType.NChar,2) ,
                                   new SqlParameter("@pn", SqlDbType.NChar, 18) ,
                                   new SqlParameter("@phone", SqlDbType.NChar,11) ,
                                   new SqlParameter("@pwd", SqlDbType.NVarChar, 32) ,
                                   new SqlParameter("@money", SqlDbType.Float) ,
                                   new SqlParameter("@remark", SqlDbType.NVarChar, 200) ,
                                   new SqlParameter("@id", SqlDbType.NChar, 10) ,
                                   new SqlParameter("@identity", SqlDbType.NChar, 2) ,
                                   };
                paras[0].Value = name;
                paras[1].Value = sex;
                paras[2].Value = pn;
                paras[3].Value = phone;
                paras[4].Value = pwd;
                paras[5].Value = Money;
                paras[6].Value = remark;
                paras[7].Value = txtID.Text;
                paras[8].Value = txtiden.Text;
                string sqltext = "UPDATE Person SET PName=@name,PSex=@sex,PN=@pn,PPhone=@phone,PCode=@pwd,PMoney=@money,PRemark=@remark WHERE  PID=@id AND [identity]=@identity";
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
