using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace ROBOPROJECT
{
    internal class SerialPortManager
    {
        private static SerialPort _serialPort=new SerialPort();
        public static event Action<string> DataReceived;
        public static SerialPort mySerialPort //доступ к порту
            {
            get {return _serialPort;}
            }
        public static void OpenPort(string portName) //открытие порта
        {
           if (!_serialPort.IsOpen)
                {
                _serialPort.PortName = portName;
                _serialPort.BaudRate = 9600;
                _serialPort.DataBits = 8;
                _serialPort.StopBits = StopBits.One;
                _serialPort.Parity = Parity.None;
                mySerialPort.DataReceived += OnDataReceived;
                _serialPort.Open();
                }
        }
        public static void ClosePort() //закрытие порта
        {
            if (_serialPort.IsOpen)
            {
                mySerialPort.DataReceived -= OnDataReceived;
                _serialPort.Close();
            }
        }
        private static void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = mySerialPort.ReadLine();
                DataReceived?.Invoke(data);
            }
            catch
            {
            }
        }
    }
}