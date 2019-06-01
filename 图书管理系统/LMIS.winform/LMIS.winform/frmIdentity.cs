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
    public partial class frmIdentity : Form
    {
        public frmIdentity()
        {
            InitializeComponent();
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM [Identity]");

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddIdentity db = new frmAddIdentity();
            db.ShowDialog();
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM [Identity]");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgrdv1.DataSource!=null)
            {
                frmModifyIdentity db = new frmModifyIdentity();
                db.txtId.Text = dgrdv1.CurrentRow.Cells[0].Value.ToString().Trim();
                db.cboDate.Text = dgrdv1.CurrentRow.Cells[1].Value.ToString().Trim();
                db.cboNum.Text = dgrdv1.CurrentRow.Cells[2].Value.ToString().Trim();
                db.textBox1.Text = dgrdv1.CurrentRow.Cells[0].Value.ToString().Trim();
                db.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择数据","提示");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string identity = dgrdv1.CurrentRow.Cells[0].Value.ToString().Trim();
            string time = dgrdv1.CurrentRow.Cells[1].Value.ToString().Trim();
            string num = dgrdv1.CurrentRow.Cells[2].Value.ToString().Trim();
            if (dgrdv1.DataSource!=null)
            {
                SqlParameter[] paras = {new SqlParameter("@identity", SqlDbType.NVarChar, 50) ,
                                    };
                paras[0].Value = identity;
                string sqltxt = "DELETE FROM [Identity] WHERE [identity]=@identity";
                int i = SQLHelper.ExcuteSQL(sqltxt,paras);
                if (i!=0)
                {
                    MessageBox.Show("删除数据成功","提示");
                }
                else
                {
                    MessageBox.Show("删除数据失败","提示");
                }
            }
            else
            {
                MessageBox.Show("请选择数据","提示");
            }
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM [Identity]");

        }
    }
}
