
using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Communication_System.TcpTestTool
{
    public class TcpClientHelper : IDisposable
    {
        // TCP客户端
        private TcpClient tcpClient;

        // 网络数据流
        private NetworkStream networkStream;

        // 接收任务取消令牌
        private CancellationTokenSource receiveCts;

        // 防止多个发送任务同时写入数据流
        private readonly SemaphoreSlim sendLock =
            new SemaphoreSlim(1, 1);

        // 防止重复释放
        private bool disposed = false;

        // 接收数据事件
        public event Action<string> DataReceived;

        // 日志事件
        public event Action<string> LogReceived;

        // 当前连接状态
        public bool IsConnected
        {
            get
            {
                return tcpClient != null &&
                       tcpClient.Connected &&
                       networkStream != null;
            }
        }

        /// <summary>
        /// 连接TCP服务器
        /// </summary>
        public async Task ConnectAsync(string ip, int port)
        {
            if (disposed)
                throw new ObjectDisposedException("TcpClientHelper");

            if (string.IsNullOrWhiteSpace(ip))
                throw new ArgumentException("IP地址不能为空！");

            if (port < 1 || port > 65535)
                throw new ArgumentOutOfRangeException("port", "端口范围必须是1~65535！");

            // 如果已经连接，先断开旧连接
            Disconnect();

            tcpClient = new TcpClient();
            receiveCts = new CancellationTokenSource();

            try
            {
                // 异步连接服务器
                await tcpClient.ConnectAsync(ip, port);

                // 获取网络数据流
                networkStream = tcpClient.GetStream();

                LogReceived?.Invoke(
                    $"成功连接服务器：{ip}:{port}");

                // 启动后台接收任务
                Task receiveTask = ReceiveAsync(receiveCts.Token);
            }
            catch
            {
                Disconnect();
                throw;
            }
        }

        /// <summary>
        /// 发送字节数据
        /// </summary>
        public async Task SendAsync(byte[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentException("发送数据不能为空！");

            if (!IsConnected)
                throw new InvalidOperationException("当前未连接服务器！");

            await sendLock.WaitAsync();

            try
            {
                if (!IsConnected)
                    throw new InvalidOperationException("TCP连接已经断开！");

                // 异步发送数据
                await networkStream.WriteAsync(
                    data, 0, data.Length);

                await networkStream.FlushAsync();
            }
            catch (Exception ex)
            {
                LogReceived?.Invoke("发送异常：" + ex.Message);
                throw;
            }
            finally
            {
                sendLock.Release();
            }
        }

        /// <summary>
        /// 发送字符串
        /// </summary>
        public Task SendAsync(string message)
        {
            if (message == null)
                throw new ArgumentNullException("message");

            byte[] data = Encoding.UTF8.GetBytes(message);

            return SendAsync(data);
        }

        /// <summary>
        /// 后台持续接收数据
        /// </summary>
        private async Task ReceiveAsync(CancellationToken token)
        {
            byte[] buffer = new byte[1024];

            try
            {
                while (!token.IsCancellationRequested)
                {
                    NetworkStream stream = networkStream;

                    if (stream == null)
                        break;

                    // 异步读取数据
                    int bytesRead = await stream.ReadAsync(
                        buffer, 0, buffer.Length, token);

                    // 返回0代表对方正常关闭连接
                    if (bytesRead == 0)
                    {
                        LogReceived?.Invoke("服务器已关闭连接。");
                        break;
                    }

                    // 只转换本次实际接收到的字节
                    byte[] receivedBytes = new byte[bytesRead];

                    Array.Copy(
                        buffer,
                        0,
                        receivedBytes,
                        0,
                        bytesRead);

                    // UTF-8解码
                    string message = Encoding.UTF8.GetString(
                        receivedBytes);

                    DataReceived?.Invoke(message);
                }
            }
            catch (OperationCanceledException)
            {
                // 主动断开连接时，属于正常情况
            }
            catch (ObjectDisposedException)
            {
                // 数据流关闭时，属于正常退出
            }
            catch (Exception ex)
            {
                if (!token.IsCancellationRequested)
                {
                    LogReceived?.Invoke(
                        "接收异常：" + ex.Message);
                }
            }
            finally
            {
                LogReceived?.Invoke("接收任务结束。");
            }
        }

        /// <summary>
        /// 断开TCP连接
        /// </summary>
        public void Disconnect()
        {
            // 取消接收任务
            if (receiveCts != null)
            {
                try
                {
                    receiveCts.Cancel();
                }
                catch
                {
                }
            }

            // 关闭网络数据流
            if (networkStream != null)
            {
                try
                {
                    networkStream.Close();
                    networkStream.Dispose();
                }
                catch
                {
                }

                networkStream = null;
            }

            // 关闭TCP客户端
            if (tcpClient != null)
            {
                try
                {
                    tcpClient.Close();
                    tcpClient.Dispose();
                }
                catch
                {
                }

                tcpClient = null;
            }

            // 释放取消令牌
            if (receiveCts != null)
            {
                receiveCts.Dispose();
                receiveCts = null;
            }
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            if (disposed)
                return;

            Disconnect();

            sendLock.Dispose();

            disposed = true;
        }
    }
}
