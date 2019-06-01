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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Type");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddType db = new frmAddType();
            db.ShowDialog();
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Type");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgrdv1.DataSource!=null)
            {
                frmModifyType db = new frmModifyType();
                db.txtName.Text = dgrdv1.CurrentRow.Cells[1].Value.ToString().Trim();
                db.txtRemark.Text = dgrdv1.CurrentRow.Cells[2].Value.ToString().Trim();
                db.ShowDialog();
                this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Type");
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgrdv1.DataSource != null)
            {
                string tid = dgrdv1.CurrentRow.Cells[0].Value.ToString().Trim();
                string tname = dgrdv1.CurrentRow.Cells[1].Value.ToString().Trim();
                string tremark = dgrdv1.CurrentRow.Cells[2].Value.ToString().Trim();
                SqlParameter[] paras = {new SqlParameter("@id", SqlDbType.NVarChar, 20) ,
                                    };
                paras[0].Value = tid;
                string sqltxt = "DELETE FROM Type WHERE TID = @id";
                int i =SQLHelper.ExcuteSQL(sqltxt, paras);
                if (i==0)
                {
                    MessageBox.Show("删除数据失败","提示");
                }
                else
                {
                    MessageBox.Show("删除数据成功","提示");
                }
                this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Type");

            }
            else
            {
                MessageBox.Show("请选择数据","错误");
            }
        }
    }
}
