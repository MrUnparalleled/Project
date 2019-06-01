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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Manager");
        }
        //关闭按钮
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //删除按钮
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgrdv1.DataSource != null)
            {
                string id = dgrdv1.CurrentRow.Cells[0].Value.ToString().Trim();
                string pwd = dgrdv1.CurrentRow.Cells[1].Value.ToString().Trim();
                string manage = dgrdv1.CurrentRow.Cells[2].Value.ToString().Trim();
                string work = dgrdv1.CurrentRow.Cells[3].Value.ToString().Trim();
                string person = dgrdv1.CurrentRow.Cells[4].Value.ToString().Trim();
                SqlParameter[] paras = {new SqlParameter("@id", SqlDbType.NVarChar, 20) ,
                                   new SqlParameter("@pwd", SqlDbType.VarChar,200) ,
                                    };
                paras[0].Value = id;
                paras[1].Value = pwd;
                //MessageBox.Show(manage);
                if (manage=="True"||work=="True"||person=="True")
                {
                    string sqltext = "DELETE FROM Manager WHERE MName = @id AND MCode = @pwd";
                    int i = SQLHelper.ExcuteSQL(sqltext, paras);
                    if (i != 0)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
            }
            this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Manager");
        }


        //修改按钮
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgrdv1.DataSource != null)
            {
                frmModifyUser db = new frmModifyUser();
                db.txtName.Text=dgrdv1.CurrentRow.Cells[0].Value.ToString().Trim();
                db.ShowDialog();
                this.dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Manager");
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

    }
}
