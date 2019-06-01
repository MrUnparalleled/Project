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
    public partial class frmModifyType : Form
    {
        public frmModifyType()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifyType_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string remark = txtRemark.Text;
            if (name == "" || remark == "")
            {
                MessageBox.Show("请输入完整信息");
            }
            else
            {
                SqlParameter[] paras = {new SqlParameter("@name", SqlDbType.NVarChar, 20) ,
                                   new SqlParameter("@remark", SqlDbType.VarChar,200) ,
                                    };
                paras[0].Value = name;
                paras[1].Value = remark;
                string sqltext = "UPDATE Type SET tRemark=@remark,typename=@name WHERE  typename=@name";
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
