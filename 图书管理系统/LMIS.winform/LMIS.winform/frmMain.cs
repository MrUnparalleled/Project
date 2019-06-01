using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMIS.Winform
{

    public partial class frmMain : Form
    {
        public static frmMain f0 = null; 
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            f0 = this;
            this.FormClosing += (o, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = MessageBox.Show("确定退出该程序？", this.Text, MessageBoxButtons.OKCancel) != DialogResult.OK;
                }
            };
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser db = new frmAddUser();
            db.ShowDialog();
        }

        private void 浏览用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser db = new frmUser();
            db.ShowDialog();
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookOut db = new frmBookOut();
            db.ShowDialog();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookIn db = new frmBookIn();
            db.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmBookOut db = new frmBookOut();
            db.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmBookIn db = new frmBookIn();
            db.ShowDialog();
        }

        private void 浏览身份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdentity db = new frmIdentity();
            db.ShowDialog();
        }

        private void 浏览读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerson db = new frmPerson();
            db.ShowDialog();
        }

        private void 图书分类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType db = new frmType();
            db.ShowDialog();
        }

        private void 浏览图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook db = new frmBook();
            db.ShowDialog();
        }

        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookQuery db = new frmBookQuery();
            db.ShowDialog();
        }

        private void 借阅查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonQuery db = new frmPersonQuery();
            db.textBox1.Text = this.toolStripStatusLabel3.Text;
            db.ShowDialog();
        }

        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyCode db = new frmModifyCode();
            db.txtName.Text = this.toolStripStatusLabel3.Text;
            db.txt.Text = this.toolStripStatusLabel2.Text;
            this.Hide();
            db.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string y = DateTime.Now.Year.ToString();
            string m = DateTime.Now.Month.ToString();
            string d = DateTime.Now.Day.ToString();
            string h = DateTime.Now.Hour.ToString();
            string f = DateTime.Now.Minute.ToString();
            string s = DateTime.Now.Second.ToString();
            this.toolStripStatusLabel4.Text = y+"年"+m+"月"+d+"日"+h+"点"+f+"分"+s+"秒";  
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin db = new frmLogin();
            this.Hide();
            db.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmUser db = new frmUser();
            db.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmPerson db = new frmPerson();
            db.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmBookQuery db = new frmBookQuery();
            db.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmModifyCode db = new frmModifyCode();
            db.txtName.Text = this.toolStripStatusLabel3.Text;
            db.txt.Text = this.toolStripStatusLabel2.Text;
            this.Hide();
            db.ShowDialog();
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmSitManage db = new frmSitManage();
            db.txt1.Text = this.toolStripStatusLabel3.Text.Trim();
            db.ShowDialog();
            //MessageBox.Show(toolStripButton3.Text.Trim());
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmSay db = new frmSay();
            db.ShowDialog();
        }
    }
}
