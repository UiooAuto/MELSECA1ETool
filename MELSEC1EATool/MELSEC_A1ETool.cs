using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MELSECA1ETool
{
    internal class MELSEC_A1ETool
    {
        public Socket socket;
        public IPAddress ipAddress;
        public int serverPort;
        public IPEndPoint ipEndPoint;
        public int ConnectTimeOut = 1000;
        public Ping ping;
        int times = 3;//重连次数
        int wait = 1000;//每次重连前等待多久

        public MELSEC_A1ETool(string serverIp, int serverPort)
        {
            this.ipAddress = IPAddress.Parse(serverIp);
            this.serverPort = serverPort;
            this.ipEndPoint = new IPEndPoint(ipAddress, serverPort);
            this.ping = new Ping();
        }

        public bool IpAddressPing()
        {
            PingReply pingReply = ping.Send(this.ipAddress, this.ConnectTimeOut);
            if (pingReply.Status == IPStatus.Success)
            {
                return true;
            }
            return false;
        }

        public bool ReConnect()
        {
            while (times > 0)
            {
                ConnectClose();
                Thread.Sleep(wait);
                if (ConnectServer())
                {
                    return true;
                }
                times--;
            }

            return false;
        }

        public bool ConnectServer()
        {
            try
            {
                if (IpAddressPing())
                {
                    this.socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    this.socket.SendTimeout = ConnectTimeOut;
                    this.socket.ReceiveTimeout = ConnectTimeOut;
                    this.socket.Connect(this.ipEndPoint);
                }
                else
                {
                    //MessageBox.Show("连接超时");
                    return false;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        public void ConnectClose()
        {
            if (socket != null)
            {
                try
                {
                    socket.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    socket.Close();
                }
                catch
                {
                }
            }
            try
            {
                ((IDisposable)this).Dispose();
                ping.Dispose();
            }
            catch
            {
            }
        }

        #region 读写底层
        public bool sendto(string cmd)
        {
            if (socket != null)
            {
                int i;
                if (string.IsNullOrWhiteSpace(cmd))
                {
                    return false;
                }
                byte[] buffer = new byte[1024 * 1024];
                buffer = Encoding.ASCII.GetBytes(cmd + "\r\n");
                try
                {
                    i = socket.Send(buffer);
                }
                catch
                {
                    return false;
                }
                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 从Socket对象中获取数据
        /// </summary>
        /// <param name="a">读取的数据长度</param>
        /// <returns>读取到的数据</returns>
        public byte[] Recivefrom(out int a)
        {
            if (socket != null)
            {
                byte[] recBytes = new byte[1024 * 1024];
                try
                {
                    a = socket.Receive(recBytes);
                }
                catch
                {
                    a = 0;
                    return null;
                }
                if (a == 0)
                {
                    return null;
                }

                return recBytes;
            }
            else
            {
                a = 0;
                return null;
            }

        }

        #endregion


        #region 写入PLC

        public bool Write(string address, ushort cmd)
        {
            int readLength;
            bool b = sendto("WR " + address + ".U " + cmd + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    string str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("错误信息" + str);
                        return false;
                    }
                }
            }
            return false;
        }

        public bool Write(string address, short cmd)
        {
            int readLength;
            bool b = sendto("WR " + address + ".S " + cmd + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    string str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("错误信息" + str);
                        return false;
                    }
                }
            }
            return false;
        }

        public bool Write(string address, ushort[] cmd)
        {
            string str = "";
            int readLength;
            for (int i = 0; i < cmd.Length; i++)
            {
                str = str + " " + cmd[i];
            }
            //MessageBox.Show("WRS " + address + ".U " + cmd.Length + str + "\r");
            bool b = sendto("WRS " + address + ".U " + cmd.Length + str + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(str);
                        return false;
                    }
                }
            }

            return b;
        }

        public bool Write(string address, short[] cmd)
        {
            string str = "";
            int readLength;
            for (int i = 0; i < cmd.Length; i++)
            {
                str = str + " " + cmd[i];
            }
            //MessageBox.Show("WRS " + address + ".U " + cmd.Length + str + "\r");
            bool b = sendto("WRS " + address + ".S " + cmd.Length + str + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(str);
                        return false;
                    }
                }
            }

            return b;
        }

        public bool Write(string address, uint cmd)
        {
            string str = "";
            int readLength;
            //MessageBox.Show("WR " + address + ".D " + cmd + "\r");
            bool b = sendto("WR " + address + ".D " + cmd + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(str);
                        return false;
                    }
                }
            }
            return b;
        }

        public bool Write(string address, int cmd)
        {
            string str = "";
            int readLength;
            //MessageBox.Show("WRS " + address + ".U " + ushorts.Length + str + "\r");
            bool b = sendto("WR " + address + ".L " + cmd + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(str);
                        return false;
                    }
                }
            }
            return b;
        }

        public bool Write(string address, uint[] cmd)
        {
            string cmdStr = "";
            int readLength;
            for (int i = 0; i < cmd.Length; i++)
            {
                cmdStr = cmdStr + " " + cmd[i];
            }
            bool b = sendto("WRS " + address + ".D " + cmd.Length + cmdStr + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    cmdStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(cmdStr))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(cmdStr);
                        return false;
                    }
                }
            }
            return false;
        }

        public bool Write(string address, int[] cmd)
        {
            string cmdStr = "";
            int readLength;
            for (int i = 0; i < cmd.Length; i++)
            {
                cmdStr = cmdStr + " " + cmd[i];
            }
            bool b = sendto("WRS " + address + ".L " + cmd.Length + cmdStr + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    cmdStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(cmdStr))
                    {
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show(cmdStr);
                        return false;
                    }
                }
            }
            return false;
        }

        public bool Write(string address, string cmd)
        {
            string str = "";
            ushort[] ushorts;
            byte[] strByteArr = Encoding.ASCII.GetBytes(cmd);
            if ((strByteArr.Length % 2) == 0)
            {
                ushorts = new ushort[strByteArr.Length / 2];
            }
            else
            {
                ushorts = new ushort[(strByteArr.Length / 2) + 1];
            }
            int readLength;

            for (int i = 0; i < ushorts.Length; i++)
            {
                ushorts[i] = 0x0000;
                ushorts[i] = (ushort)(ushorts[i] | strByteArr[i * 2]);
                ushorts[i] = (ushort)(ushorts[i] << 8);
                if (strByteArr.Length > (i * 2) + 1)
                {
                    ushorts[i] = (ushort)(ushorts[i] | strByteArr[(i * 2) + 1]);
                }

                str = str + " " + ushorts[i];
            }
            bool b = sendto("WRS " + address + ".U " + ushorts.Length + str + "\r");
            if (b)
            {
                byte[] bytes = Recivefrom(out readLength);
                if (bytes != null)
                {
                    str = Encoding.ASCII.GetString(bytes, 0, readLength);
                    if ("OK\r\n".Equals(str))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return b;
        }

        #endregion

        #region 读取PLC

        private bool TryRead(string cmd, out byte[] readResult, out int getLength)
        {
            bool b = false;
            byte[] bytes = null;
            bool loop = true;
            int readLength = 0;
            while (loop)
            {
                b = false;
                bytes = null;
                b = sendto(cmd);
                bytes = Recivefrom(out readLength);
                if (b && bytes != null)
                {
                    loop = false;
                }
                else
                {
                    if (!ReConnect())
                    {
                        getLength = 0;
                        readResult = null;
                        return false;
                    }
                }
            }
            getLength = readLength;
            readResult = bytes;
            return true;
        }

        /// <summary>
        /// 读取PLC的内容
        /// </summary>
        /// <param name="address">读取的地址</param>
        /// <returns>读取的结果</returns>
        public ReadResult<ushort> ReadUInt16(string address)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<ushort> result = new ReadResult<ushort>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RD " + address + ".U\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                ushort recShort = ushort.Parse(recStr);
                result.IsSuccess = true;
                result.Content = recShort;
            }
            return result;
        }

        /// <summary>
        /// 读取PLC的内容
        /// </summary>
        /// <param name="address">读取的地址</param>
        /// <returns>读取的结果</returns>
        public ReadResult<short> ReadInt16(string address)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<short> result = new ReadResult<short>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RD " + address + ".S\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                short recShort = short.Parse(recStr);
                result.IsSuccess = true;
                result.Content = recShort;
            }
            return result;
        }

        public ReadResult<ushort[]> ReadUInt16(string address, int length)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<ushort[]> result = new ReadResult<ushort[]>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RDS " + address + ".U " + length + "\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                var indexOf = recStr.IndexOf('\r');
                if (indexOf != -1)
                {
                    recStr = recStr.Substring(0, indexOf);
                }
                char[] chars = { ' ' };
                string[] strings = recStr.Split(chars); //按照空格分隔
                ushort[] ushorts = new ushort[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                {
                    ushorts[i] = ushort.Parse(strings[i]);
                }
                result.IsSuccess = true;
                result.Content = ushorts;
            }
            return result;
        }

        public ReadResult<short[]> ReadInt16(string address, int length)
        {
            int readLength = 0;
            string recStr;
            bool b = false;
            byte[] bytes = null;
            ReadResult<short[]> result = new ReadResult<short[]>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RDS " + address + ".S " + length + "\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                var indexOf = recStr.IndexOf('\r');
                if (indexOf != -1)
                {
                    recStr = recStr.Substring(0, indexOf);
                }
                char[] chars = { ' ' };
                string[] strings = recStr.Split(chars); //按照空格分隔
                short[] shorts = new short[length];
                for (int i = 0; i < strings.Length; i++)
                {
                    shorts[i] = short.Parse(strings[i]);
                }
                result.IsSuccess = true;
                result.Content = shorts;
            }
            return result;
        }

        public ReadResult<uint> ReadUInt32(string address)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<uint> result = new ReadResult<uint>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RD " + address + ".D\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                uint recShort = uint.Parse(recStr);
                result.IsSuccess = true;
                result.Content = recShort;
            }
            return result;
        }

        public ReadResult<int> ReadInt32(string address)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<int> result = new ReadResult<int>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RD " + address + ".L\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                int recInt = int.Parse(recStr);
                result.IsSuccess = true;
                result.Content = recInt;
            }
            return result;
        }

        public ReadResult<uint[]> ReadUInt32(string address, int length)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<uint[]> result = new ReadResult<uint[]>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RD " + address + ".L\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                var indexOf = recStr.IndexOf('\r');
                if (indexOf != -1)
                {
                    recStr = recStr.Substring(0, indexOf);
                }
                char[] chars = { ' ' };
                string[] strings = recStr.Split(chars); //按照空格分隔
                uint[] uints = new uint[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                {
                    uints[i] = uint.Parse(strings[i]);
                }
                result.IsSuccess = true;
                result.Content = uints;
            }
            return result;
        }

        public ReadResult<int[]> ReadInt32(string address, int length)
        {
            int readLength;
            string recStr;
            byte[] bytes = null;
            ReadResult<int[]> result = new ReadResult<int[]>();
            result.IsSuccess = false; //默认值为false，失败

            bool isSuccess = TryRead("RD " + address + ".L\r", out bytes, out readLength);

            if (isSuccess)
            {
                recStr = Encoding.ASCII.GetString(bytes, 0, readLength);
                var indexOf = recStr.IndexOf('\r');
                if (indexOf != -1)
                {
                    recStr = recStr.Substring(0, indexOf);
                }
                char[] chars = { ' ' };
                string[] strings = recStr.Split(chars); //按照空格分隔
                int[] ints = new int[strings.Length];
                for (int i = 0; i < strings.Length; i++)
                {
                    ints[i] = int.Parse(strings[i]);
                }
                result.IsSuccess = true;
                result.Content = ints;
            }
            return result;
        }

        public ReadResult<string> ReadString(string address, int length)
        {
            string recStr;
            byte[] bytes;
            ReadResult<string> result = new ReadResult<string>();
            result.IsSuccess = false; //默认值为false，失败
            ReadResult<ushort[]> readResult = ReadUInt16(address, length);
            if (readResult.IsSuccess)
            {
                try
                {
                    bytes = new byte[readResult.Content.Length * 2];
                    for (int i = 0; i < readResult.Content.Length; i++)
                    {
                        bytes[(i * 2) + 1] = (byte)(readResult.Content[i] & 0x00ff);
                        bytes[i * 2] = (byte)(readResult.Content[i] >> 8);
                    }
                    recStr = Encoding.ASCII.GetString(bytes);
                    result.Content = recStr;
                    result.IsSuccess = true;
                    return result;
                }
                catch
                {

                }

            }
            return result;
        }

        #endregion
    }

    public class ReadResult<T>
    {
        public bool IsSuccess;
        public T Content;
    }
}
