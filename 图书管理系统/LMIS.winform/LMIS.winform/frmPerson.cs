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
    public partial class frmPerson : Form
    {
        public frmPerson()
        {
            InitializeComponent();
            this.dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM Person");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPerson db = new frmAddPerson();
            db.ShowDialog();
            this.dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM Person");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgrdv.DataSource != null)
            {
                frmModifyPerson db = new frmModifyPerson();
                db.txtID.Text = dgrdv.CurrentRow.Cells[0].Value.ToString().Trim();
                db.txtiden.Text = dgrdv.CurrentRow.Cells[7].Value.ToString().Trim();
                db.txtCode.Text = dgrdv.CurrentRow.Cells[5].Value.ToString().Trim();
                db.txtMoney.Text = dgrdv.CurrentRow.Cells[6].Value.ToString().Trim();
                db.txtName.Text = dgrdv.CurrentRow.Cells[1].Value.ToString().Trim();
                db.txtPhone.Text = dgrdv.CurrentRow.Cells[3].Value.ToString().Trim();
                db.txtPN.Text = dgrdv.CurrentRow.Cells[4].Value.ToString().Trim();
                db.txtRemark.Text = dgrdv.CurrentRow.Cells[8].Value.ToString().Trim();
                db.cboSex.Text = dgrdv.CurrentRow.Cells[2].Value.ToString().Trim();
                db.ShowDialog();
                this.dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM Person");
            }
            else
            {
                MessageBox.Show("请选择数据");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = dgrdv.CurrentRow.Cells[0].Value.ToString().Trim();
            if (dgrdv.DataSource!=null)
            {
                SqlParameter[] paras = {new SqlParameter("@id", SqlDbType.NChar, 10) ,
                                    };
                paras[0].Value =id;
                //MessageBox.Show(id);
                string sqltxt = "DELETE FROM Person WHERE PID = @id";
                int i = SQLHelper.ExcuteSQL(sqltxt,paras);
                if (i!=0)
                {
                    MessageBox.Show("删除数据成功","提示");
                }
                else
                {
                    MessageBox.Show("删除数据失败","提示");
                }
                this.dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM Person");
            }
            else
            {
                MessageBox.Show("请选择数据","错误");
            }
        }
    }
}
