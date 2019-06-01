using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace LMIS.Winform
{
    public partial class frmSay : Form
    {
        public frmSay()
        {
            InitializeComponent();
        }
        private IPAddress myIP;
        private IPEndPoint MyServer;
        private Socket socket;
        private bool threadHalt;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myIP = IPAddress.Parse(textBox1.Text);
            }
            catch 
            {
                MessageBox.Show("您输入的IP地址格式不对，请重新输入！");
            }
            try
            {
                MyServer = new IPEndPoint(myIP, Int32.Parse(textBox2.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Bind(MyServer);
                socket.Listen(1);
                toolStripStatusLabel1.Text = "主机" + textBox1.Text + "端口" + textBox2.Text + "开始监听....";
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button2.Enabled = true;
                socket = socket.Accept();
                threadHalt = false;
                Thread thread = new Thread(new ThreadStart(targett));
                thread.Start();
            }
            catch 
            {
                MessageBox.Show("不能进入监听状态，可能是端口已经被占用！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                threadHalt = true;
                socket.Close();
                toolStripStatusLabel1.Text = "主机" + textBox1.Text + "，端口" + textBox2.Text + "监听停止!";
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button2.Enabled = false;
            }
            catch 
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                myIP = IPAddress.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("您输入的IP地址格式不正确，请重新输入！");
            }
            try
            {
                MyServer = new IPEndPoint(myIP, Int32.Parse(textBox2.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = true;
                socket.Connect(MyServer);
                toolStripStatusLabel1.Text = "  与主机" + textBox1.Text + "  端口" + textBox2.Text + "连接成功！";
                threadHalt = false;
                Thread thread = new Thread(new ThreadStart(targett));
                thread.Start();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                threadHalt = true;
                socket.Close();
                toolStripStatusLabel1.Text = "与主机的连接已断开";
                button1.Enabled = true;
                button3.Enabled = true;
                button2.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = textBox3.Text + "->" + richTextBox2.Text + "\r\n";
                Byte[] bya = System.Text.Encoding.Default.GetBytes(msg.ToCharArray());
                socket.Send(bya, bya.Length, SocketFlags.None);
            }
            catch 
            {
                MessageBox.Show("连接尚未建立！无法发送！");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                //threadHalt = true;
                //socket.Close();

            this.Close();
        }
        private void targett()
        {
            while (!threadHalt)
            {
                int n = socket.Available;
                if (n>0)
                {
                    try
                    {
                        Byte[] bya = new Byte[n];
                        socket.Receive(bya, n, 0);
                        string s = System.Text.Encoding.Default.GetString(bya);
                        richTextBox1.AppendText(s);
                    }
                    catch
                    {
                    }
                }
                Thread.Sleep(300);
            }
        }

        private void frmSay_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

    }
}
