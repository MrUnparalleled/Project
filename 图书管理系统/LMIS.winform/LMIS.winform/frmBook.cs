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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
            this.dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM BOOK");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddBook db = new frmAddBook();
            db.ShowDialog();
            dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM BOOK");
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmModifyBook db = new frmModifyBook();
            db.txtID.Text = dgrdv.CurrentRow.Cells[0].Value.ToString().Trim();
            db.txtName.Text = dgrdv.CurrentRow.Cells[1].Value.ToString().Trim();
            db.txtNum.Text = dgrdv.CurrentRow.Cells[6].Value.ToString().Trim();
            db.txtPrice.Text = dgrdv.CurrentRow.Cells[5].Value.ToString().Trim();
            db.txtPublish.Text = dgrdv.CurrentRow.Cells[3].Value.ToString().Trim();
            db.txtRemark.Text = dgrdv.CurrentRow.Cells[8].Value.ToString().Trim();
            db.txtType.Text = dgrdv.CurrentRow.Cells[7].Value.ToString().Trim();
            db.txtWriter.Text = dgrdv.CurrentRow.Cells[2].Value.ToString().Trim();
            db.dtp1.Text = dgrdv.CurrentRow.Cells[4].Value.ToString().Trim();
            db.ShowDialog();
            dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM BOOK");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgrdv.DataSource != null)
            {
                string id = dgrdv.CurrentRow.Cells[0].Value.ToString().Trim();
                SqlParameter[] paras = {new SqlParameter("@id", SqlDbType.NVarChar, 20) ,
                                    };
                paras[0].Value = id;
                string sqltext = "DELETE FROM Book WHERE BID = @id";
                int i = SQLHelper.ExcuteSQL(sqltext, paras);
                if (i != 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
                dgrdv.DataSource = SQLHelper.GetTable("SELECT * FROM BOOK");
            }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {

        }
    }
}
