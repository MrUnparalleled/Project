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
    public partial class frmPersonQuery : Form
    {
        public frmPersonQuery()
        {
            InitializeComponent();
        }

        private void frmPersonQuery_Load(object sender, EventArgs e)
        {
            string pid = this.textBox1.Text;

            SqlParameter[] paras1 = {new SqlParameter("@pid", SqlDbType.NChar, 10) ,
                                    };
            paras1[0].Value = pid;
            SqlParameter[] paras2 = {new SqlParameter("@pid", SqlDbType.NChar, 10) ,
                                    };
            paras2[0].Value = pid;

            dgrdv2.DataSource = SQLHelper.GetTable("SELECT * FROM BookOut,Book WHERE Book.BID=BookOut.BID AND BookOut.isReturn='False' AND BookOut.PID=@pid", paras1);
            dgrdv1.DataSource = SQLHelper.GetTable("SELECT * FROM Person WHERE PID=@Pid", paras2);
            
        }
    }
}
