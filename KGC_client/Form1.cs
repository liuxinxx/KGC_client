using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Threading;
namespace KGC_client
{
    public partial class Form1 : SkinMain
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region 鼠标拖动点击标题拖动窗体
        Point mouse_offset;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        } 
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setBut_Click(object sender, EventArgs e)
        {
            setIP setip = new setIP();
            setip.ShowDialog();
        }

        private void regBut_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                file file = new file();
                string f = file.reader("ipMsg.txt");//读取保存在本地的ＩＰ
                string[] sstr = f.Split(':');//利用":"分割IP和端口
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                client.Connecting(sstr[0], sstr[1]);//启动服务器
                client.clientSER(textBox1.Text.Trim());//发送登录消息
                client.lod.ShowDialog();//弹出来个虚假的登录提示条
                
            }
            else
            {
                MessageBox.Show("错误！\r\n\r\n账号不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
