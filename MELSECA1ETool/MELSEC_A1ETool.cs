using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace MELSECA1ETool
{
    public class MELSEC_A1ETool
    {
        public Socket socket;
        public IPAddress ipAddress;
        public int serverPort;
        public IPEndPoint ipEndPoint;
        public int ConnectTimeOut = 1000;
        public Ping ping;
        int onceReconnectTimes = 3;
        int times;//重连次数
        int wait = 1000;//每次重连前等待多久
        static object lock1 = new object();

        /// <summary>
        /// 创建MC协议连接对象
        /// </summary>
        /// <param name="serverIp">目标IP</param>
        /// <param name="serverPort">目标端口</param>
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
                    times = onceReconnectTimes;
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
        public bool Sendto(byte[] cmd)
        {
            if (socket != null)
            {
                int i;
                if (cmd == null)
                {
                    return false;
                }
                try
                {
                    i = socket.Send(cmd);
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

        /*public byte[] SendAndRecivefrom(byte[] cmd, out bool ok)
        {
            byte[] recBytes = new byte[1024 * 1024];
            bool sendOK = Sendto(cmd);
            if (sendOK)
            {
                int revNum = socket.Receive(recBytes);
                if (revNum == 0)
                {
                    ok = false;
                }
                else
                {
                    ok = true;
                }
            }
            else
            {
                ok = false;
            }
            return recBytes;
        }*/

        /// <summary>
        /// 与服务器发起一次交互
        /// </summary>
        /// <param name="cmd">发送给服务器的命令</param>
        /// <returns>从服务器接收到的返回数据</returns>
        public byte[] SendAndRecivefrom(byte[] cmd)
        {
            int revNum = 0;
            lock (lock1)
            {
                byte[] recBytes = new byte[1024 * 1024];
                bool sendOK = Sendto(cmd);
                if (sendOK)
                {
                    recBytes = Recivefrom(out revNum);
                    if (revNum == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return recBytes;
                    }
                }
                else
                {
                    return null;
                }
            }            
        }

        #endregion


        #region 写入PLC

        public bool Write(string address, ushort cmd)
        {
            int readLength;
            ushort[] ushorts = new ushort[] { cmd };
            MELSEC_A1E_Request request = new MELSEC_A1E_Request(SubframeRequest.WRITEINT16, address, ushorts, ConnectTimeOut);

            byte[] bytes = SendAndRecivefrom(request.GetBytes());

            if (bytes != null)
            {
                MELSEC_A1E_Response response = new MELSEC_A1E_Response(bytes);

                if (response.endCode == EndCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool Write(string address, short cmd)
        {
            bool isSuccess = Write(address, (ushort)cmd);
            return isSuccess;
        }

        public bool Write(string address, ushort[] cmd)
        {
            int readLength;
            MELSEC_A1E_Request request = new MELSEC_A1E_Request(SubframeRequest.WRITEINT16, address, cmd, ConnectTimeOut);

            byte[] bytes = SendAndRecivefrom(request.GetBytes());

            if (bytes != null)
            {
                MELSEC_A1E_Response response = new MELSEC_A1E_Response(bytes);

                if (response.endCode == EndCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool Write(string address, short[] cmd)
        {
            ushort[] ushorts = new ushort[cmd.Length];
            for (int i = 0; i < cmd.Length; i++)
            {
                ushorts[i] = (ushort)cmd[i];
            }

            bool isSuccess = Write(address, ushorts);

            return isSuccess;
        }

        public bool Write(string address, uint cmd)
        {
            ushort[] ushorts = new ushort[2];
            ushorts[0] = (ushort)(cmd & 0x0000ffff);
            ushorts[1] = (ushort)((cmd & 0xffff0000)>>16);
            bool v = Write(address, ushorts);
            return v;
        }

        public bool Write(string address, int cmd)
        {
            ushort[] ushorts = new ushort[2];
            ushorts[0] = (ushort)(cmd & 0x0000ffff);
            ushorts[1] = (ushort)((cmd & 0xffff0000) >> 16);
            bool v = Write(address, ushorts);
            return v;
        }

        public bool Write(string address, uint[] cmd)
        {
            ushort[] ushorts = new ushort[cmd.Length * 2];

            for (int i = 0; i < cmd.Length; i++)
            {
                ushorts[2 * i] = (ushort)(cmd[i] & 0x0000ffff);
                ushorts[(2 * i) + 1] = (ushort)((cmd[i] & 0xffff0000) >> 16);
            }
            bool v = Write(address, ushorts);
            return v;
        }

        public bool Write(string address, int[] cmd)
        {
            ushort[] ushorts = new ushort[cmd.Length * 2];

            for (int i = 0; i < cmd.Length; i++)
            {
                ushorts[2 * i] = (ushort)(cmd[i] & 0x0000ffff);
                ushorts[(2 * i) + 1] = (ushort)((cmd[i] & 0xffff0000) >> 16);
            }
            bool v = Write(address, ushorts);
            return v;
        }

        /*public bool Write(string address, string cmd)
        {
            *//*string str = "";
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
            }*//*

            return false;
        }*/

        #endregion

        #region 读取PLC

        private bool TryRead(byte[] cmd, out byte[] readResult)
        {
            byte[] bytes = null;
            bool loop = true;
            while (loop)
            {
                bytes = SendAndRecivefrom(cmd);

                if (bytes != null)
                {
                    loop = false;
                }
                else
                {
                    if (!ReConnect())
                    {
                        readResult = null;
                        return false;
                    }
                }
            }
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
            int recLength;
            byte[] bytes = null;
            ReadResult<ushort> result = new ReadResult<ushort>();
            result.IsSuccess = false; //默认值为false，失败

            MELSEC_A1E_Request request = new MELSEC_A1E_Request(SubframeRequest.READINT16, address, 1, ConnectTimeOut);
            bool isSuccess = TryRead(request.GetBytes(), out bytes);

            //如果Socket通信失败，则返回失败
            if (!isSuccess)
            {
                return result;
            }

            MELSEC_A1E_Response response = new MELSEC_A1E_Response(bytes);

            //如果返回报文为失败，则返回失败和错误码
            if (response.endCode == EndCode.ERROR)
            {
                result.errorCode = response.errorCode;
                return result;
            }

            result.IsSuccess = true;

            result.Content = response.bytes[1];
            result.Content = (ushort)(result.Content << 8);
            result.Content = (ushort)(result.Content | response.bytes[0]);

            return result;
        }

        /// <summary>
        /// 读取PLC的内容
        /// </summary>
        /// <param name="address">读取的地址</param>
        /// <returns>读取的结果</returns>
        public ReadResult<short> ReadInt16(string address)
        {
            ReadResult<short> result = new ReadResult<short>();
            ReadResult<ushort> readResult = ReadUInt16(address);
            result.IsSuccess = readResult.IsSuccess;
            if (!readResult.IsSuccess)
            {
                result.errorCode = readResult.errorCode;
                return result;
            }

            result.Content = (short)readResult.Content;
            return result;
        }

        public ReadResult<ushort[]> ReadUInt16(string address, int length)
        {
            int recLength;
            byte[] bytes = null;
            ReadResult<ushort[]> result = new ReadResult<ushort[]>();
            result.IsSuccess = false; //默认值为false，失败

            MELSEC_A1E_Request request = new MELSEC_A1E_Request(SubframeRequest.READINT16, address, length, ConnectTimeOut);
            bool isSuccess = TryRead(request.GetBytes(), out bytes);

            //如果Socket通信失败，则返回失败
            if (!isSuccess)
            {
                return result;
            }

            MELSEC_A1E_Response response = new MELSEC_A1E_Response(bytes);

            //如果返回报文为失败，则返回失败和错误码
            if (response.endCode == EndCode.ERROR)
            {
                result.errorCode = response.errorCode;
                return result;
            }

            result.IsSuccess = true;

            result.Content = new ushort[length];
            for (int i = 0; i < length; i++)
            {
                result.Content[i] = response.bytes[(i * 2) + 1];
                result.Content[i] = (ushort)(result.Content[i] << 8);
                result.Content[i] = (ushort)(result.Content[i] | response.bytes[i * 2]);
            }

            return result;
        }

        public ReadResult<short[]> ReadInt16(string address, int length)
        {
            ReadResult<short[]> result = new ReadResult<short[]>();
            ReadResult<ushort[]> readResult = ReadUInt16(address, length);
            result.IsSuccess = readResult.IsSuccess;
            if (!readResult.IsSuccess)
            {
                result.errorCode = readResult.errorCode;
                return result;
            }

            result.Content = new short[length];
            for (int i = 0; i < result.Content.Length; i++)
            {
                result.Content[i] = (short)readResult.Content[i];
            }
            return result;
        }

        public ReadResult<uint> ReadUInt32(string address)
        {
            ReadResult<uint> result = new ReadResult<uint>();
            ReadResult<ushort[]> readResult = ReadUInt16(address, 2);

            result.IsSuccess = readResult.IsSuccess;
            if (!readResult.IsSuccess)
            {
                result.errorCode = readResult.errorCode;
                return result;
            }

            result.Content = readResult.Content[1];
            result.Content = result.Content << 16;
            result.Content = result.Content | readResult.Content[0];

            return result;
        }

        public ReadResult<int> ReadInt32(string address)
        {
            ReadResult<int> result = new ReadResult<int>();
            ReadResult<uint> readResult = ReadUInt32(address);

            result.IsSuccess = readResult.IsSuccess;
            if (!readResult.IsSuccess)
            {
                result.errorCode = readResult.errorCode;
                return result;
            }

            result.Content = (int)readResult.Content;

            return result;
        }

        public ReadResult<uint[]> ReadUInt32(string address, int length)
        {
            ReadResult<uint[]> result = new ReadResult<uint[]>();
            ReadResult<ushort[]> readResult = ReadUInt16(address, length * 2);

            result.IsSuccess = readResult.IsSuccess;
            if (!readResult.IsSuccess)
            {
                result.errorCode = readResult.errorCode;
                return result;
            }

            result.Content = new uint[length];
            for (int i = 0; i < length; i++)
            {
                result.Content[i] = readResult.Content[(i * 2) + 1];
                result.Content[i] = result.Content[i] << 16;
                result.Content[i] = result.Content[i] | readResult.Content[i * 2];
            }

            return result;
        }

        public ReadResult<int[]> ReadInt32(string address, int length)
        {
            ReadResult<int[]> result = new ReadResult<int[]>();
            ReadResult<uint[]> readResult = ReadUInt32(address, length);

            result.IsSuccess = readResult.IsSuccess;
            if (!readResult.IsSuccess)
            {
                result.errorCode = readResult.errorCode;
                return result;
            }

            result.Content = new int[length];
            for (int i = 0; i < length; i++)
            {
                result.Content[i] = (int)readResult.Content[i];
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

    /// <summary>
    /// 读取到的结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ReadResult<T>
    {
        public bool IsSuccess;
        public T Content;
        public byte errorCode;
    }

    #region 专用枚举

    /// <summary>
    /// 用于生成请求报文时指定操作类型的副帧头
    /// </summary>
    public enum SubframeRequest : byte
    {
        READBOOL = 0x00,
        READINT16 = 0x01,
        WRITEBOOL = 0x02,
        WRITEINT16 = 0x03
    }

    /// <summary>
    /// 用于处理响应报文时对照操作类型的副帧头响应
    /// </summary>
    public enum SubframeAck : byte
    {
        READBOOL = 0x80,
        READINT16 = 0x81,
        WRITEBOOL = 0x82,
        WRITEINT16 = 0x83
    }

    /// <summary>
    /// 用于处理响应报文时对照操作类型的副帧头响应
    /// </summary>
    public enum EndCode : byte
    {
        OK = 0x00,
        ERROR = 0x5b,
    }

    /// <summary>
    /// 用于生成请求报文时指定地址类型的枚举
    /// </summary>
    public enum MELSECAddressName : ushort
    {
        X = 0x5820,
        Y = 0x5920,
        M = 0x4D20,
        L = 0x4D20,
        S = 0x4D20,
        D = 0x4420,
    }

    #endregion

    #region 请求报文内容

    /// <summary>
    /// 三菱MC协议请求报文
    /// </summary>
    public class MELSEC_A1E_Request
    {
        /// <summary>
        /// 请求副帧头
        /// </summary>
        private SubframeRequest request;
        /// <summary>
        /// plc编号，一般默认为FF
        /// </summary>
        private byte plcNo;
        /// <summary>
        /// ACPU监视定时器
        /// • 0000H(0): 无限等待(处理完成之前继续等待。)
        /// • 0001H～FFFFH(1～65535) : 等待时间(单位: 250ms)
        /// 为了正常进行数据通信，建议根据通信目标在下表的设置范围内进行使用。
        /// 连接站(本站)监视定时器的建议值为1H～28H(0.25秒～10秒)
        /// </summary>
        private ushort acpuWatch;
        /// <summary>
        /// 请求数据
        /// </summary>
        private RequestData requestData;

        #region 读请求生成

        /// <summary>
        /// 生成读写PLC的请求报文
        /// </summary>
        /// <param name="request">请求类型</param>
        /// <param name="address">操作地址</param>
        /// <param name="length">操作数量</param>
        /// <param name="overTime">超时时间</param>
        public MELSEC_A1E_Request(SubframeRequest request, string address, int length, int overTime)
        {
            MELSECAddressName addressName;
            string addresstype = address.Substring(0, 1);
            string addressNumStr = address.Substring(1);
            int addressNum = int.Parse(addressNumStr);
            switch (addresstype)
            {
                case "X":
                case "x":
                    addressName = MELSECAddressName.X;
                    break;
                /*case "Y":
                    addressName = MELSECAddressName.Y;
                    break;
                case "M":
                    addressName = MELSECAddressName.M;
                    break;
                case "L":
                    addressName = MELSECAddressName.L;
                    break;
                case "S":
                    addressName = MELSECAddressName.S;
                    break;*/
                case "D":
                case "d":
                    addressName = MELSECAddressName.D;
                    break;
                default:
                    addressName = MELSECAddressName.D;
                    break;
            }
            this.request = request;
            this.plcNo = 0xff;
            this.acpuWatch = 0x0c;
            this.requestData = new RequestData(addressName, addressNum, length);
        }

        /// <summary>
        /// 生成读写PLC的请求报文
        /// </summary>
        /// <param name="request">请求类型</param>
        /// <param name="address">操作地址</param>
        /// <param name="length">操作数量</param>
        /// <param name="overTime">超时时间</param>
        public MELSEC_A1E_Request(SubframeRequest request, string address, ushort[] value, int overTime)
        {
            MELSECAddressName addressName;
            string addresstype = address.Substring(0, 1);
            string addressNumStr = address.Substring(1);
            int addressNum = int.Parse(addressNumStr);
            switch (addresstype)
            {
                case "X":
                case "x":
                    addressName = MELSECAddressName.X;
                    break;
                /*case "Y":
                    addressName = MELSECAddressName.Y;
                    break;
                case "M":
                    addressName = MELSECAddressName.M;
                    break;
                case "L":
                    addressName = MELSECAddressName.L;
                    break;
                case "S":
                    addressName = MELSECAddressName.S;
                    break;*/
                case "D":
                case "d":
                    addressName = MELSECAddressName.D;
                    break;
                default:
                    addressName = MELSECAddressName.D;
                    break;
            }
            this.request = request;
            this.plcNo = 0xff;
            this.acpuWatch = 0x0c;
            this.requestData = new RequestData(addressName, addressNum, value);
        }

        #endregion

        public byte[] GetBytes()
        {
            List<byte> byteList = new List<byte>();

            byteList.Add((byte)request);
            byteList.Add(plcNo);
            byteList.Add((byte)((acpuWatch & 0x0f)));
            byteList.Add((byte)((acpuWatch & 0xf0) >> 8));
            for (int i = 0; i < requestData.totalLength; i++)
            {
                byteList.Add(requestData.outBytes[i]);
            }
            return byteList.ToArray();
        }
    }

    /// <summary>
    /// 三菱MC协议1E帧的请求数据
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// 指定地址类型
        /// </summary>
        private MELSECAddressName addressName;

        /// <summary>
        /// 地址编号
        /// </summary>
        private int addressNum;

        /// <summary>
        /// 指定批量操作的数量
        /// </summary>
        private byte length;

        /// <summary>
        /// 固定值
        /// </summary>
        private byte endByte;

        /// <summary>
        /// 要操作的参数
        /// </summary>
        private byte[] value;

        /// <summary>
        /// 
        /// </summary>
        private ushort[] writeData;

        /// <summary>
        /// 请求数据总长
        /// </summary>
        public int totalLength;

        /// <summary>
        /// 用于输出的字节数组
        /// </summary>
        public byte[] outBytes;

        #region 批量读取请求数据

        /// <summary>
        /// 批量读取请求数据
        /// </summary>
        /// <param name="addresstype">地址类型(X、D)</param>
        /// <param name="addressNum">地址编号</param>
        /// <param name="length">读取长度</param>
        public RequestData(MELSECAddressName addressName, int addressNum, int length)
        {
            this.addressName = addressName;
            this.addressNum = addressNum;
            if (length >= 256)
            {
                this.length = 0x00;
            }
            else
            {
                this.length = (byte)length;
            }
            this.endByte = 0x00;

            value = new byte[8];

            outBytes = GetBytes();
            totalLength = outBytes.Length;
        }

        #endregion

        #region bool数据批量写入请求数据

        /*public RequestData(MELSECAddressName addressName, int addressNum, int length, bool[] value)
        {
            this.addressName = addressName;
            this.addressNum = addressNum;
            if (length >= 256)
            {
                this.length = 0x00;
            }
            this.endByte = 0x00;
        }*/

        #endregion

        #region 16位数据批量写入请求数据

        public RequestData(MELSECAddressName addressName, int addressNum, ushort[] value)
        {
            this.addressName = addressName;
            this.addressNum = addressNum;

            if (value.Length >= 256)
            {
                this.length = 0x00;
                this.value = new byte[8 + (256 * 2)];
            }
            else
            {
                this.length = (byte)value.Length;
                this.value = new byte[8 + (value.Length * 2)];
            }

            this.endByte = 0x00;
            this.writeData = value;

            outBytes = GetBytes();
            totalLength = outBytes.Length;
        }

        #endregion

        /// <summary>
        /// 获取对应的请求数据数组
        /// </summary>
        /// <returns></returns>
        private byte[] GetBytes()
        {
            if (writeData == null)
            {
                value[0] = (byte)((addressNum & 0x000000ff));
                value[1] = (byte)((addressNum & 0x0000ff00) >> 8);
                value[2] = (byte)((addressNum & 0x00ff0000) >> 16);
                value[3] = (byte)((addressNum & 0xff000000) >> 24);

                value[4] = (byte)(((ushort)addressName & 0x00ff));
                value[5] = (byte)(((ushort)addressName & 0xff00) >> 8);

                value[6] = length;

                value[7] = endByte;
            }
            else
            {
                value[0] = (byte)((addressNum & 0x000000ff));
                value[1] = (byte)((addressNum & 0x0000ff00) >> 8);
                value[2] = (byte)((addressNum & 0x00ff0000) >> 16);
                value[3] = (byte)((addressNum & 0xff000000) >> 24);

                value[4] = (byte)(((ushort)addressName & 0x00ff));
                value[5] = (byte)(((ushort)addressName & 0xff00) >> 8);

                value[6] = length;

                value[7] = endByte;

                for (int i = 0; i < length; i++)
                {
                    //ushort tempUshort = ushort.Parse(writeData[i].ToString(), NumberStyles.HexNumber);
                    ushort tempUshort = writeData[i];
                    value[8 + (i * 2)] = (byte)(tempUshort & 0x00ff);
                    value[9 + (i * 2)] = (byte)((tempUshort & 0xff00) >> 8);
                }
            }
            return value;
        }

    }

    #endregion

    #region 响应报文数据

    public class MELSEC_A1E_Response
    {
        public SubframeAck ack;
        public EndCode endCode;
        public byte errorCode;
        public byte[] bytes;

        public MELSEC_A1E_Response(byte[] value)
        {
            ack = (SubframeAck)value[0];
            endCode = (EndCode)value[1];
            if (value.Length > 2)
            {
                if (endCode == EndCode.ERROR)
                {
                    errorCode = (byte)value[2];
                }
                else if (endCode == EndCode.OK)
                {
                    bytes = new byte[value.Length - 2];
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        bytes[i] = value[i + 2];
                    }
                }
            }
        }
    }

    #endregion
}
