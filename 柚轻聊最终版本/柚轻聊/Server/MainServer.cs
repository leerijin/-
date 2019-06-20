﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using BLL;
using MODEL;

namespace Server
{
    public partial class MainServer : Form
    {
        public MainServer()
        {
            InitializeComponent();
        }
      //服务器监听套接字
        Socket sokServer = null;
        //监听线程
        Thread thrServer = null;
        //创建客户端管理类对象
        ClientManager clientManage = null;
        BLL.UsersBLL userBll = new BLL.UsersBLL();
        private void btnSerStar_Click(object sender, EventArgs e)
        {
            //网络操作是很容易断开连接，所以一般要try catch
            try
            {
                //创建一个Socket实例
                //第一个参数表示使用ipv4
                //第二个参数表示发送的是数据流
                //第三个参数表示使用的协议是Tcp协议
                 sokServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                 //获取ip地址局域网使用 ipv4，广域网使用外网IP
                IPAddress ip = IPAddress.Parse(txtSerIP.Text.Trim());
                //创建一个网络通信节点，这个通信节点包含了ip地址，跟端口号。
                //这里的端口我们设置为1029，这里设置大于1024，为什么自己查一下端口号范围使用说明。我默认为51111
                IPEndPoint point = new IPEndPoint(ip, int.Parse(txtSerPort.Text.Trim()));
                //Socket绑定网路通信节点
                sokServer.Bind(point);
                //    //设置监听队列 同一时间最多连几个   （对应界面的系统负荷）
                sokServer.Listen(Convert.ToInt32(cmbSerMax.SelectedItem));
                //sokServer.Accept()这个接收消息的方法会使线程卡死，所以要开启新线程
                thrServer = new Thread(WatchConnection);
                thrServer.IsBackground = true;
                thrServer.Start();
                //管理类对象实例化传入好友列表ListBox控件和消息委托
                clientManage = new ClientManager(listChat, AppendMsg);
                AppendMsg("开始监听~~~~！" + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message + DateTime.Now.ToString());
                AppendMsg("异常：" + ex.Message + "1" + DateTime.Now.ToString());
            }
        }
        bool isWatching = true;
        void WatchConnection()
        {
            try
            {
                while (isWatching)  //注意该循环,服务端要持续监听,要不然一个客户端链接过后就无法链接第二个客户端了。
                {
                    //开始监听客户端的消息
                    //负责通信的socket
                    Socket sokMsg = sokServer.Accept();
                    //加入通信管理类
                   // MessageBox.Show(sokMsg.RemoteEndPoint.ToString());
                    clientManage.AddClient(sokMsg);
                    txtOnlineCount.Text = listChat.Items.Count.ToString();
                }
            }
            catch (SocketException ex1)
            {
                AppendMsg("异常：" + ex1.Message + "2"+DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                AppendMsg("异常：" + ex.Source + "@" + ex.Message + "@" + ex.TargetSite + "@" + ex.InnerException + "@" + ex.Data + "3" + DateTime.Now.ToString());
            }
        }
        void AppendMsg(string strMsg)
        {
            txtSetting.AppendText(strMsg + "\r\n" );
        }

        private void btnSerClose_Click(object sender, EventArgs e)
        {
            isWatching = false;
            sokServer.Close();
        }

        private void MainServer_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
           int x= Convert.ToInt32(cmbSerMax.SelectedItem);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataUsers.DataSource = userBll.GetAll();
        }

        private void btnSetClear_Click(object sender, EventArgs e)
        {
            txtSetting.Text = "";
        }

        private void btnSetSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsm = new FileStream(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\"  + "服务器日志.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] newbuffer = Encoding.UTF8.GetBytes(txtSetting.Text);
                fsm.Write(newbuffer, 0, newbuffer.Length);
            }
        }

        private void btnsearchByIp_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = userBll.SelectByIpTable(txtSetIP.Text.Trim());
        }
        //每分钟刷新在线人数
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtOnlineCount.Text = listChat.Items.Count.ToString();
        }
    }
}
