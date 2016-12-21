using System;
using System.IO.Ports;
using System.Threading;

namespace CallForHelp
{
    public class ArduinoControllerMain {

        SerialPort _currentPort;
        bool _portFound;
        
        private void SetComPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    _currentPort = new SerialPort(port, 9600);
                    if (DetectArduino())
                    {
                        _portFound = true;
                        break;
                    }
                    else
                    {
                        _portFound = false;
                    }
                }
            }
            catch (Exception e)
            {
            }
        }


        private bool DetectArduino()
        {
            try
            {
                //The below setting are for the Hello handshake
                var buffer = new byte[5];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                buffer[4] = Convert.ToByte(4);
                int intReturnAscii = 0;
                var charReturnValue = (Char)intReturnAscii;
                _currentPort.Open();
                _currentPort.Write(buffer, 0, 5);
                Thread.Sleep(1000);
                int count = _currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnAscii = _currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnAscii);
                    count--;
                }
                //ComPort.name = returnMessage;
                _currentPort.Close();
                if (returnMessage.Contains("HELLO FROM ARDUINO"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}