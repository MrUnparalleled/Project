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
    public partial class frmModifyIdentity : Form
    {
        public frmModifyIdentity()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string id1 = textBox1.Text.Trim();
            string id2 = txtId.Text.Trim();
            string time=cboDate.Text;
            string num=cboNum.Text;
            if (id2 != null && time != null && num != null)
            {
                SqlParameter[] paras = {new SqlParameter("@id1", SqlDbType.NVarChar, 50),
                                       new SqlParameter("@id2", SqlDbType.NVarChar, 50),
                                       new SqlParameter("@time", SqlDbType.Int),
                                       new SqlParameter("@num", SqlDbType.TinyInt),
                                    };
                paras[0].Value = id1;
                paras[1].Value = id2;
                paras[2].Value = time;
                paras[3].Value = num;
                string sqltxt = "UPDATE [Identity] SET [identity]=@id2,longTime=@time,bigNum=@num WHERE  [identity]=@id1";
                int i = SQLHelper.ExcuteSQL(sqltxt, paras);
                if (i != 0)
                {
                    MessageBox.Show("修改成功", "提示");
                }
                else
                {
                    MessageBox.Show("修改失败", "提示");
                }
            }
            else
            {
                MessageBox.Show("请填写完整信息","提示");
            }
        }

        private void frmModifyIdentity_Load(object sender, EventArgs e)
        {

            
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
