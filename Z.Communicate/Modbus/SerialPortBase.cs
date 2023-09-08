using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;

namespace Z.Communicate.Modbus
{
    public class SerialPortBase : ModbusBase
    {
        SerialPort serialPort = null;//串口对象

        /// <summary>
        ///    9600 8 N 1
        /// </summary>
        /// <param name="portName">串口名称 COM1</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="stopBits">停止位</param>
        /// <param name="parity">校验位</param>
        public SerialPortBase(string portName, int baudRate, int dataBits, StopBits stopBits, Parity parity)
        {
            if (serialPort == null)
            {
                serialPort = new SerialPort();
            }
            serialPort.PortName = portName;
            serialPort.BaudRate = baudRate;
            serialPort.DataBits = dataBits;
            serialPort.StopBits = stopBits;
            serialPort.Parity = parity;
            serialPort.Encoding = Encoding.ASCII;
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        /// <returns></returns>
        public override bool Open()
        {
            try
            {
                if (serialPort == null)
                {
                    throw new Exception("串口对象未实例化");
                }
                serialPort.Open();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public override void Close()
        {
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }

        public override async Task<List<byte>> Send(List<byte> command, int len)
        {
            serialPort.Write(command.ToArray(), 0, command.Count);
            //稍微等待一下
            await Task.Delay(100);
            //读取串口缓存数据
            //延时处理
            if (serialPort.BytesToRead == 0)
            {
                await Task.Delay(20);
            }
            if (serialPort.BytesToRead == 0)
            {
                await Task.Delay(40);
            }
            if (serialPort.BytesToRead == 0)
            {
                await Task.Delay(60);
            }
            if (serialPort.BytesToRead == 0)
            {
                return new List<byte>();
            }

            //读取串口数据
            byte[] buffer = new byte[serialPort.BytesToRead];
            var length = serialPort.Read(buffer, 0, buffer.Length);//读取数据
            serialPort.DiscardInBuffer();
            return new List<byte>(buffer);
        }
    }
}
