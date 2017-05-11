using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Com.Itrus.Crypto;
namespace KGC_client
{
    class client
    {

        #region 一些定义
        public static Socket sokClient = null;//将sokClient设置为静态成员，不然调用函数时会在函数体内出现 sokClien为空。出现“未将对象引用设置到对象的实例”异常     
        public static Thread threadClient = null;   //链接线程        
        public static string strMsg = "";//strMsg为服务器发给用户的消息        
        public static ecc ecc = new ecc();//ecc对象
        public static string name = "";//当前客户端用户name
        public static string cpuid = "";//获取本机CPU序列号
        public static string hdid = "";//获取本机
        public static string pripk = "";//私钥
        public static string ppk = "";//公钥
        public static string serverpk = "server.txt";//服务器公钥
        public static desKey des = new desKey();
        public static clientForm cl = new clientForm();
        public static loding lod = new loding();
        public static SM2 sm2 = SM2.Instance;
        public static Thread threadlog = null;   //链接线程
        // public static file file = new file();

        #endregion

        #region 建立与服务器连接
        /// <summary>
        /// 建立与服务器连接
        /// </summary>
        /// <param name="ip">IP</param>
        /// <param>端口</param>
        public static void Connecting(string ip, string port)
        {
            getID get = new getID();
            cpuid = get.cpuidstr();//获取本机CPUid
            hdid = get.hdstr();//获取本机硬盘id
            try
            {
                //初始化一个链接方式
                sokClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IP
                IPAddress address = IPAddress.Parse(ip);
                //套接字节点（包含 ip和端口）
                IPEndPoint endpoint = new IPEndPoint(address, int.Parse(port));
                //连接
                sokClient.Connect(endpoint);
                //向服务器发送用户名
                upmsg(name);
                //实例化一个线程
                threadClient = new Thread(ReciveMsg);
                //设置为后台线程随主线程的关闭而关闭
                threadClient.IsBackground = true;
                //启动线程
                threadClient.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("客户端“Form1”异常0：\r\n客户端初始化服务器连接失败！\r\n\r\n失败原因：" + ex.Message);
                Application.Restart();//连接服务器失败，重新登录
            }
        }
        #endregion

        #region 发送客户端基本信息，用于登录验证
        /// <summary>
        /// 发送客户端基本信息，用于登录验证
        /// </summary>
        public static void clientSER(string a)
        {
            //获取系统时间:
            name = a;
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            // MessageBox.Show(name + "#" + cpuid + "#" + hdid + "#" + dateTime);
            upmsg(name + "#" + cpuid + "#" + hdid + "#" + dateTime);
        }
        #endregion

        /// <summary>
        /// 新建一个委托
        /// </summary>
        public static void ShowMsgForm()
        {
            cl.ShowDialog();
        }
        #region 从socket中读取数据
        /// <summary>
        /// 从socket中读取数据
        /// </summary>
        public static void ReciveMsg()
        {
            try
            {
                //循环读取
                while (true)
                {
                    pripk = name + "pri.txt";//当前用户的私钥
                    ppk = name + "pk.txt";//当前用户的公钥
                    int length = 0;
                    //字节数组
                    byte[] byteMsg = new byte[1024 * 1024 * 4];
                    //获取字节数组大小                   
                    length = sokClient.Receive(byteMsg);
                    //获取有用的从0~length个
                    strMsg = Encoding.UTF8.GetString(byteMsg, 0, length);
                    // MessageBox.Show(strMsg);
                    Thread thread2 = new Thread(new ThreadStart(ShowMsgForm));//创建新线程 
                    thread2.IsBackground = true;
                    string[] sstr = strMsg.Split('#');//利用“#”作为消息的分割

                    //数组长度
                    int x = sstr.Length;
                    //标记数据类型，当falg>1是为用户登录信息
                    //falg为数组中消息的个数
                    int msnumber = 0;
                    for (int j = 0; j < x; j++)
                    {
                        if (sstr[j] != "")
                        {
                            msnumber++;
                        }
                    }
                    if (sstr[0] == name)
                    {
                        cl.label10.ForeColor = Color.Red;
                        cl.label10.Text = "当前序列中有你！";
                        cl.tslang.Text = "正在进行签名任务,暂时无法重新生成公私钥！";
                        cl.button1.Enabled = false;
                    }

                    #region 一系列的登录检测
                    if (sstr[0] == "正在登录！")
                    {
                        //Thread.Sleep(100);

                        //MessageBox.Show(sstr[0] + "\r\n" + sstr[1]);
                        file file = new file();
                        desKey des = new desKey();


                        //进过des加密后写入本地server.txt文件下
                        file.writer("server.txt", des.Encrypt(sstr[1], "abcdefgh"));

                        thread2.Start();
                    }
                    if (strMsg == "用户名尚未注册！")
                    {

                        // MessageBox.Show(

                        sokClient.Shutdown(SocketShutdown.Both);
                        sokClient.Disconnect(true);
                        //用户没有注册，从新启动客户端
                        Application.Restart();
                    }

                    //首次登陆关键信息的注册
                    //     添加进度提示
                    //1.提交cpu、硬盘的序列号
                    //2.生成公钥对、和私钥（都为16进制64位）
                    if (strMsg == "系统检测到用户首次登陆，正在注册关键信息请稍等！")//加入进度条指示！
                    {
                        //生成公私钥，存入指定的文件夹下
                        ecc.Creatkey(sm2, pripk, ppk);//创建密钥
                        //根据公私钥生成rs
                        string gykey = "";
                        ecc.Test_sm2_sign(sm2, pripk, ppk, name);
                        file file = new file();
                        try
                        {
                            gykey = des.Decrypt(file.reader(ppk), "abcdefgh");//读取客户端公钥，记着des解密
                        }
                        catch (Exception dd)
                        {
                            MessageBox.Show(dd.ToString());
                        }

                        Form1 ff = new Form1();
                        client.upmsg("重新生成用户公钥对" + "#" + gykey + "#" + client.name + "#@#@#@");//将用户公钥发给服务器

                        fistLog fist = new fistLog();
                        fist.ShowDialog();

                        thread2.Start();

                    }
                    if (strMsg == "服务器检测到，当前配置与注册不符")
                    {
                        MessageBox.Show("服务器检测到，当前电脑配置与注册信息不符\n\n无法完成登录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Restart();
                    }
                    #endregion

                    //利用#作为分隔符，
                    /* sstr[0]位用户名,
                     * sstr[1]位服务器的R,
                     * sstr[2]位服务器的S ,
                     * sstr[3]为Z,
                     * sstr[4]为c1
                     * sstr[5]位c2,
                     * sstr[6]位c3,
                     * sstr[7]为时间,
                     * sstr[8]位签名发起人标记
                     */
                    if (msnumber == 9)
                    {
                        // MessageBox.Show(sstr[0] + "\r\n" + sstr[1] + "\r\n" + sstr[2] + "\r\n" + sstr[3] + "\r\n" + sstr[4] + "\r\n" + sstr[5] + "\r\n" + sstr[6] + "\r\n" + sstr[7] + "\r\n" + sstr[8] + "\r\n");

                        //设置签名消息
                        file file = new file();
                        //ecc ecc = new ecc();
                        string pk = des.Decrypt(file.reader(serverpk), "abcdefgh");//读取并解密des加密的服务器公钥
                        //签名验证
                        if (client.ecc.Signature_Check(sm2, pk, sstr[3], sstr[1], sstr[2]) == true)
                        {
                            if (sstr[0] == name)
                            {
                                cl.noSignBut.Text = "拒绝签名";
                                cl.noSignBut.Enabled = true;
                                cl.button2.Enabled = true;
                            }

                            string jmxx = client.ecc.deciphering(sm2, pripk, sstr[4], sstr[5], sstr[6]);
                            if (jmxx != "0")
                            {//倒计时设置
                                cl.waitBut.Text = jmxx;
                                if (sstr[7].StartsWith("时间") == true)
                                {
                                    //MessageBox.Show("时间：\r\n"+sstr[7].ToString());
                                    int len = sstr[7].Length;
                                    string s = "";
                                    if (len == 0)
                                        s += sstr[7].Trim()[2];
                                    if (2 <= len)
                                        s += sstr[7].Trim()[2];
                                    cl.time1 = Int32.Parse(s) - 1;
                                    cl.ss = 59;
                                }
                            }
                            else
                            {
                                MessageBox.Show("数据校验失败！");
                            }

                        }
                        else
                        {
                            MessageBox.Show("验证不通过！！");
                        }
                    }
                    #region 第一次接受签名
                    if (msnumber == 4)
                    {
                        //利用'|'做分割符，sstr[0]为用户名，sstr[1]为签名消息，sstr[2]为时间，sstr[3]代表是否为发起签名的人
                        //MessageBox.Show(sstr[0] + "\n\n" + sstr[1]);

                        if (sstr[0] == name)
                        {
                            cl.noSignBut.Text = "拒绝签名";
                            cl.noSignBut.Enabled = true;
                            cl.button2.Enabled = true;
                        }
                        //设置签名消息
                        cl.waitBut.Text = sstr[1].ToString();
                        //倒计时设置
                        if (sstr[2].StartsWith("时间") == true)
                        {
                            int len = sstr[2].Length;
                            string s = "";
                            if (len == 0)
                                s += sstr[2].Trim()[2];
                            if (2 <= len)
                                s += sstr[2].Trim()[2];
                            cl.time1 = Int32.Parse(s) - 1;
                            cl.ss = 59;
                        }
                        //sstr[3]代表此用户是否为签名的第一个人，由他填写签名内容。“1”代表是签名发起者
                        if (sstr[3] == "1")
                        {
                            //设置为可写
                            cl.waitBut.ReadOnly = false;
                        }

                    }
                    #endregion

                }
            }
            catch (SocketException)//服务器离线异常捕获
            {
                //回报服务器下线
                cl.label7.ForeColor = Color.Red;
                cl.label7.Text = "离线";
                if (MessageBox.Show("服务器关闭了链接！！\n\n\n是否重新登录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Restart();//服务器关闭后，从新回到登录页面
                }
                else
                    return;

            }
            catch (Exception e)
            {
                MessageBox.Show("客户端“Form1”异常 2：" + e.Message);
                return;
            }
        }
        #endregion



        #region 将数据发送到服务器
        /// <summary>
        /// 将数据发送到服务器
        /// </summary>
        /// <param name="ms">要发送的数据</param>
        public static void upmsg(string ms)
        {
            try
            {
                string strMsg = ms.Trim();
                byte[] byteMsg = Encoding.UTF8.GetBytes(strMsg);
                sokClient.Send(byteMsg);
            }
            catch (Exception ss)
            {

                MessageBox.Show("客户端“Form1”异常 3：" + ss.Message);
            }
        }
        #endregion

    }

}