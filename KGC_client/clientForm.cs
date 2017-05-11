using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;
using System.Runtime.InteropServices;
namespace KGC_client
{
    public partial class clientForm : SkinMain
    {
        public clientForm()
        {
            InitializeComponent();
        }
        string z = "";
        string rs = "";
        string[] c = { "" };
        private void clientForm_Load(object sender, EventArgs e)
        {
            file file = new file();
            name.Text = "当前用户：" + client.name;//将当前用户明显出来
            textBox1.Text = client.des.Decrypt(file.reader(client.ppk), "abcdefgh");//将当前用户公钥显示出来
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region 菜单指示
        private void 操作票管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qmcz.Visible = true;
            pkcz.Visible = false;

            操作票管理ToolStripMenuItem.BackColor = System.Drawing.ColorTranslator.FromWin32(16769218);
            公钥管理toolStripMenuItem2.BackColor = System.Drawing.ColorTranslator.FromWin32(16547877);
        }

        private void 公钥管理toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            qmcz.Visible = false;
            pkcz.Visible = true;
            操作票管理ToolStripMenuItem.BackColor = System.Drawing.ColorTranslator.FromWin32(16547877);
            公钥管理toolStripMenuItem2.BackColor = System.Drawing.ColorTranslator.FromWin32(16769218);
        }
        #endregion

        #region 鼠标拖动窗体
        Point mouse_offset;
        private void bt_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void bt_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }


            //取消窗体顶栏闪烁
            fromTop.Enabled = false;
            bt.BackColor = Color.FromArgb(41, 124, 252);
            label6.BackColor = Color.FromArgb(41, 124, 252);
            label8.BackColor = Color.FromArgb(41, 124, 252);

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int RandKey = ran.Next(30, 50);
            //进度条的最小最大范围
            progressBar1.Minimum = 1;
            progressBar1.Maximum = RandKey;
            daojs.Stop();
            noSignBut.BackColor = System.Drawing.ColorTranslator.FromWin32(14737632);
            button2.BackColor = System.Drawing.ColorTranslator.FromWin32(14737632);
            jdtiao.Enabled = true;

            if (waitBut.ReadOnly == false)
            {
                //MessageBox.Show("我是第一个签名的");
            }
            try
            {
               
                noSignBut.Text = "等待发起者";
                waitBut.ReadOnly = true;
                noSignBut.Enabled = false;
                button2.Enabled = false;
            }
            catch (Exception th)
            {

                MessageBox.Show("客户端“client窗体”异常 1：" + th.Message);
            }

        }

        private void jdtiao_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                //label3.Text = progressBar1.Maximum.ToString();
                double f = Math.Round((((double)progressBar1.Value / (double)progressBar1.Maximum) * 100), 0);

                if (f < 50)
                {
                    label2.Text = "正在加密";
                }
                if (f < 65 && f > 55)
                {
                    label2.Text = "加密完成";
                }
                if (f >= 85)
                {
                    label2.Text = "正在发送！";
                }
                if (f == 100)
                {
                    Form1 ff = new Form1();

                    //ecc ecc = new ecc();
                    file file = new file();
                    desKey des = new desKey();
                    //公钥加密：利用服务器的公钥加密
                    c = client.ecc.Test_sm2_cipher(client.sm2, waitBut.Text.Trim(), "server.txt");

                    //数字签名算法：利用公私钥和自己的身份标识进行生成签名
                    z = client.ecc.Test_sm2_sign(client.sm2, client.pripk, client.ppk, client.name);

                    rs = file.reader(client.name + "rs.txt");

                    client.upmsg("*#*#" + c[0] + "#" + c[1] + "#" + c[2] + "#" + z + "#" + rs + "#" + client.name + "#" + DateTime.Now.ToString());

                }
                label1.Text = f.ToString() + "%";
            }
        }

        private void noSignBut_Click(object sender, EventArgs e)
        {
            noSignBut.Text = "等待发起者";
            noSignBut.Enabled = false;
            button2.Enabled = false;
            noSignBut.BackColor = System.Drawing.ColorTranslator.FromWin32(14737632);
            button2.BackColor = System.Drawing.ColorTranslator.FromWin32(14737632);
            client.upmsg("*#&" + "#" + name);
        }
        int yyy = 0;
        public int time1 = -1, ss = 0;
        public int tt, s;
        #region 有效签名时间倒计时功能
        private void js_Tick(object sender, EventArgs e)
        {
            if (tt >= 0)
            {
                if (tt < 1 && yyy == 0)
                {
                    yyy = 1;
                    mlab.ForeColor = Color.Red;
                    slab.ForeColor = Color.Red;
                }
                s--;

                if (s == 0)
                {

                    tt--;

                    mlab.Text = tt.ToString().Trim() + "分";

                    s = 59;

                }
                slab.Text = s.ToString().Trim() + "秒";

            }
            if (tt < 0)
            {
                mlab.Text = 0 + "分";
                slab.Text = 0 + "秒";

                daojs.Stop();
                MessageBox.Show("签名时间结束！");

            }

        }
        #endregion

        #region 客户端当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString();
        }
        #endregion

        private void timer2_Tick_1(object sender, EventArgs e)
        {
           
            if (time1 >= 0)
            {//7135852in32(7135852);
                fromTop.Enabled = true;
                button2.BackColor = System.Drawing.ColorTranslator.FromWin32(7135852);
                noSignBut.BackColor = System.Drawing.ColorTranslator.FromWin32(7135852); 
                // MessageBox.Show(time1.ToString()+);
                mlab.Text = time1 + "分";
                slab.Text = ss + "秒";
                tt = time1;
                s = ss;
                daojs.Start();
                upt.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //生成公私钥，存入指定的文件夹下

            client.ecc.Creatkey(client.sm2, client.pripk, client.ppk);//创建密钥
            //根据公私钥生成rs
            string gykey = "";
            client.ecc.Test_sm2_sign(client.sm2, client.pripk, client.ppk, client.name);

            file file = new file();
            try
            {

                gykey = client.des.Decrypt(file.reader(client.ppk), "abcdefgh");//des解密算法
            }
            catch (Exception dd)
            {
                MessageBox.Show(dd.ToString());
            }

            Form1 ff = new Form1();
            client.upmsg("重新生成用户公钥对" + "#" + gykey + "#" + client.name + "#@#@#@");
            textBox1.Text = gykey;
            //MessageBox.Show("");
            button1.Enabled = false;
            timer1.Enabled = true;
        }
        //设置再次生成公钥对和私钥的时间 间隔
        //i为需要等待的时间
        int i = 10;
        int f = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (i == 0)
            {
                timer1.Stop();
                button1.Enabled = true;
                //还原生成公钥对和私钥的时间 间隔
                i = 10;
                button1.Text = "重新生成公私钥";
                f = 1;
            }
            if (f != 1)
                button1.Text = "等待(" + i-- + ")秒后，再试";
            f = 0;
        }
        [DllImport("user32")]//调用Windows API函数
        private static extern long FlashWindow(IntPtr handle, bool bInvert);
        private void fromTop_Tick(object sender, EventArgs e)
        {
            FlashWindow(this.Handle, true);
            if (bt.BackColor == Color.FromArgb(41, 124, 252))
            {
                bt.BackColor = Color.FromArgb(240, 240, 240);
                label6.BackColor = Color.FromArgb(240, 240, 240);
                label8.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                bt.BackColor = Color.FromArgb(41, 124, 252);
                label6.BackColor = Color.FromArgb(41, 124, 252);
                label8.BackColor = Color.FromArgb(41, 124, 252);
            }
        }

 
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            //取消窗体顶栏闪烁
            fromTop.Enabled = false;
            bt.BackColor = Color.FromArgb(41, 124, 252);
            label6.BackColor = Color.FromArgb(41, 124, 252);
            label8.BackColor = Color.FromArgb(41, 124, 252);
        }

        private void qmcz_MouseMove(object sender, MouseEventArgs e)
        {
            //取消窗体顶栏闪烁
            fromTop.Enabled = false;
            bt.BackColor = Color.FromArgb(41, 124, 252);
            label6.BackColor = Color.FromArgb(41, 124, 252);
            label8.BackColor = Color.FromArgb(41, 124, 252);
        }

    }
}
