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
    public partial class frmAddIdentity : Form
    {
        public frmAddIdentity()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = this.txtId.Text;
            string time = this.cboDate.Text;
            string num = this.cboNum.Text;
            if (txtId.Text.Trim() == "" || cboNum.Text.Trim() == "" || cboDate.Text.Trim() == "")
                MessageBox.Show("请填写完整信息", "提示");
            else
            {
                string sqltext = "SELECT * FROM [Identity] WHERE [identity] = @identity";
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@identity", SqlDbType.NVarChar, 2);
                paras[0].Value = id;
                object result = SQLHelper.GetObject(sqltext, paras);
                if (result != null)
                {
                    MessageBox.Show("该用户已存在");
                    return;
                }
                sqltext = string.Format("insert into [Identity] ([identity],longTime,bigNum) values ('{0}','{1}','{2}');", id, time,num);
                int n = SQLHelper.ExcuteSQL(sqltext);
                if (n > 0)
                {
                    MessageBox.Show("添加成功!");
                    return;
                }
                MessageBox.Show("添加失败！");
            }
        }

    }
}
