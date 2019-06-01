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
    public partial class frmAddType : Form
    {
        public frmAddType()
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
            string remark = this.txtRemark.Text;
            if (txtName.Text.Trim() == "" || txtRemark.Text.Trim() == "")
                MessageBox.Show("请填写完整信息", "提示");
            else
            {
                string sqltext = "SELECT * FROM Type WHERE typename = @name";
                SqlParameter[] paras = new SqlParameter[1];
                paras[0] = new SqlParameter("@name", SqlDbType.NVarChar, 20);
                paras[0].Value = name;
                object result = SQLHelper.GetObject(sqltext, paras);
                if (result != null)
                {
                    MessageBox.Show("该类型已存在");
                    return;
                }
                sqltext = string.Format("insert into Type (typename,tRemark) values ('{0}','{1}');", name, remark);
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
this.Close();
            }
            
        }
    }
}
