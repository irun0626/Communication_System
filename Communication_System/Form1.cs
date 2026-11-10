
using Communication_System.ControlTool;
using Communication_System.TcpTestTool;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Communication_System
{
    public partial class Form1 : Form
    {
        // 发送模式
        private string sendMode = "文本形式";

        // 自动滚动
        private bool autoScrollEnable = false;

        // 窗口移动
        private Point p = new Point();
        private bool isMove = false;

        // 通讯统计
        public int SendCount { get; private set; }
        public int RecvCount { get; private set; }

        // 通讯时间统计
        private Stopwatch _stopwatch = new Stopwatch();

        // TCP 通讯对象
        private TcpClientHelper tcpHelper = new TcpClientHelper();

        public Form1()
        {
            InitializeComponent();

            cbo_SendContent.Items.AddRange(new string[]
            {
                "文本形式",
                "ASCII字符串",
                "HEX十六进制"
            });

            cbo_SendContent.SelectedIndex = 0;
            sendMode = cbo_SendContent.Text;
        }

        #region 窗体初始化

        private void Form1_Load(object sender, EventArgs e)
        {
            // 接收服务端数据
            tcpHelper.DataReceived += message =>
            {
                if (IsDisposed || !IsHandleCreated)
                    return;

                try
                {
                    BeginInvoke(new Action(() =>
                    {
                        RecvCount++;
                        lbl_RecvCount.Text = RecvCount.ToString();

                        AddLog($"接收：{message}");
                    }));
                }
                catch (InvalidOperationException)
                {
                    // 窗体关闭过程中忽略 UI 调用异常
                }
            };

            // 通讯日志
            tcpHelper.LogReceived += message =>
            {
                if (IsDisposed || !IsHandleCreated)
                    return;

                try
                {
                    BeginInvoke(new Action(() =>
                    {
                        AddLog(message);
                    }));
                }
                catch (InvalidOperationException)
                {
                    // 窗体关闭过程中忽略 UI 调用异常
                }
            };

            // 初始化界面
            lbl_SendCount.Text = "0";
            lbl_RecvCount.Text = "0";
            lbl_CommTime.Text = "00:00:00";

            btn_Disconnect.Enabled = false;
        }

        #endregion

        #region 通讯时间统计

        private void timerRunTime_Tick(object sender, EventArgs e)
        {
            lbl_CommTime.Text =
                _stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
        }

        #endregion

        #region TCP连接

        private async void tcpConnect_Clik(object sender, EventArgs e)
        {
            try
            {
                string ip = txt_IP.Text.Trim();

                int port;

                if (!int.TryParse(txt_Port.Text.Trim(), out port)
                    || port < 1 || port > 65535)
                {
                    MessageBox.Show("请输入有效的端口号！");
                    return;
                }

                if (string.IsNullOrWhiteSpace(ip))
                {
                    MessageBox.Show("请输入目标 IP 地址！");
                    return;
                }

                btn_Connect.Enabled = false;

                await tcpHelper.ConnectAsync(ip, port);

                // 重置并启动计时
                _stopwatch.Reset();
                _stopwatch.Start();

                timerRunTime.Start();

                tsl_ConnState.Text = $"已连接：{ip}:{port}";
                tslLight.Image = Properties.Resources.原点;

                btn_Disconnect.Enabled = true;
            }
            catch (Exception ex)
            {
                btn_Connect.Enabled = true;
                MessageBox.Show($"连接失败：{ex.Message}");
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            // 停止计时
            timerRunTime.Stop();
            _stopwatch.Stop();

            // 断开 TCP
            tcpHelper.Disconnect();

            // 更新状态栏
            tsl_ConnState.Text = "未连接";
            tslLight.Image = Properties.Resources.icon_dot;

            btn_Connect.Enabled = true;
            btn_Disconnect.Enabled = false;
        }

        #endregion

        #region 数据发送

        private async void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txt_SendBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("发送内容不能为空！");
                    return;
                }

                // 根据发送模式转换为字节数组
                byte[] sendBytes = ParseSendData(message);

                if (sendBytes == null || sendBytes.Length == 0)
                    return;

                // 发送数据
                await tcpHelper.SendAsync(sendBytes);

                // 更新发送次数
                SendCount++;
                lbl_SendCount.Text = SendCount.ToString();

                // 根据发送模式记录日志
                if (sendMode == "文本形式")
                {
                    AddLog($"发送【文本】：{message}");
                }
                else if (sendMode == "ASCII字符串")
                {
                    AddLog($"发送【ASCII】：{message}");
                }
                else if (sendMode == "HEX十六进制")
                {
                    AddLog(
                        $"发送【HEX】：{BitConverter.ToString(sendBytes).Replace("-", " ")}");
                }

                // 发送成功后清空输入框
                txt_SendBox.Clear();
                txt_SendBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发送失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 根据发送模式将文本转换为字节数组
        /// </summary>
        private byte[] ParseSendData(string inputText)
        {
            // UTF-8 文本
            if (sendMode == "文本形式")
            {
                return Encoding.UTF8.GetBytes(inputText);
            }

            // ASCII 字符串
            else if (sendMode == "ASCII字符串")
            {
                foreach (char c in inputText)
                {
                    if (c > 127)
                    {
                        MessageBox.Show(
                            "ASCII 模式不支持中文及非 ASCII 字符！");

                        return null;
                    }
                }

                return Encoding.ASCII.GetBytes(inputText);
            }

            // HEX 十六进制
            else if (sendMode == "HEX十六进制")
            {
                string hex = inputText.Replace(" ", "");

                if (hex.Length % 2 != 0)
                {
                    MessageBox.Show(
                        "HEX 错误：十六进制字符数量必须为偶数！");

                    return null;
                }

                byte[] buffer = new byte[hex.Length / 2];

                for (int i = 0; i < buffer.Length; i++)
                {
                    string sub = hex.Substring(i * 2, 2);

                    byte b;

                    if (!byte.TryParse(
                        sub,
                        NumberStyles.HexNumber,
                        CultureInfo.InvariantCulture,
                        out b))
                    {
                        MessageBox.Show(
                            $"HEX 解析失败，非法字符：{sub}");

                        return null;
                    }

                    buffer[i] = b;
                }

                return buffer;
            }

            return null;
        }

        #endregion

        #region 发送框清空

        private void btn_SendClear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SendBox.Text))
            {
                MessageBox.Show("发送文本目前没有内容！");
                return;
            }

            txt_SendBox.Clear();
            txt_SendBox.Focus();
        }

        #endregion

        #region 通讯日志

        /// <summary>
        /// 统一日志输出方法
        /// </summary>
        private void AddLog(string msg)
        {
            if (rtb_Log.InvokeRequired)
            {
                rtb_Log.BeginInvoke(
                    new Action(() => AddLog(msg)));

                return;
            }

            string line =
                $"{DateTime.Now:HH:mm:ss}  {msg}\r\n";

            rtb_Log.AppendText(line);

            if (autoScrollEnable)
            {
                rtb_Log.SelectionStart = rtb_Log.TextLength;
                rtb_Log.ScrollToCaret();
            }
        }

        private void btn_ClearLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtb_Log.Text))
            {
                MessageBox.Show("通讯日志目前没有内容！");
                return;
            }

            rtb_Log.Clear();
        }

        private void chk_AutoScroll_CheckedChanged(
            object sender, EventArgs e)
        {
            autoScrollEnable = chk_AutoScroll.Checked;

            if (autoScrollEnable)
            {
                rtb_Log.SelectionStart = rtb_Log.TextLength;
                rtb_Log.ScrollToCaret();
            }
        }

        #endregion

        #region 发送模式切换

        private void cbo_SendContent_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            sendMode = cbo_SendContent.Text;
        }

        #endregion

        #region 窗口移动

        private void titleBar1_MouseDown(
            object sender, MouseEventArgs e)
        {
            p = e.Location;
            isMove = true;
        }

        private void titleBar1_MouseMove(
            object sender, MouseEventArgs e)
        {
            if (isMove && e.Button == MouseButtons.Left)
            {
                this.Location += new Size(
                    e.Location.X - p.X,
                    e.Location.Y - p.Y);
            }
        }

        private void titleBar1_MouseUp(
            object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        #endregion

        #region 窗体控制

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "你确定要退出系统吗？",
                "退出提示",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                timerRunTime.Stop();
                _stopwatch.Stop();

                tcpHelper.Dispose();

                this.Close();
            }
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timerRunTime.Stop();
            _stopwatch.Stop();

            tcpHelper.Dispose();

            base.OnFormClosing(e);
        }
    }
}
