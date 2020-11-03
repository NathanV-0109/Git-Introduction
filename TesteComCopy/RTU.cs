using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FtdAdapter;
using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TesteComCopy
{
    class RTU
    {
        public static void EscreveRegistro(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, ushort[] bitBobinas)
        {
            using (SerialPort port = new SerialPort(porta))
            {
                // configure serial port
                port.BaudRate = taxaTransferencia;
                port.DataBits = dataBits;
                if (bitParidade == "Sem")
                    port.Parity = Parity.None;
                else if (bitParidade == "Ímpar")
                    port.Parity = Parity.Odd;
                else
                    port.Parity = Parity.Even;

                if (bitParada == "1")
                    port.StopBits = StopBits.One;
                else
                    port.StopBits = StopBits.Two;

                port.Open();

                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                byte slaveId = bitID;
                ushort startAddress = bitEndereco;
                ushort[] registers = bitBobinas;
                master.Transport.WriteTimeout = 550;

                master.WriteMultipleRegisters(slaveId, startAddress, registers);
            }
        }

        public static ushort[] LeRegistro(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, ushort bitBobinas)
        {
            using (SerialPort port = new SerialPort(porta))
            {
                // configure serial port
                port.BaudRate = taxaTransferencia;
                port.DataBits = dataBits;
                if (bitParidade == "Sem")
                    port.Parity = Parity.None;
                else if (bitParidade == "Ímpar")
                    port.Parity = Parity.Odd;
                else
                    port.Parity = Parity.Even;

                if (bitParada == "1")
                    port.StopBits = StopBits.One;
                else
                    port.StopBits = StopBits.Two;

                port.Open();

                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                byte slaveId = bitID;
                ushort startAddress = bitEndereco;
                ushort[] leitura;
                master.Transport.ReadTimeout = 550;

                leitura = master.ReadInputRegisters(slaveId, startAddress, bitBobinas);

                return leitura;
            }
        }

        public static void EscreveBobinas(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, int bitBobinas)
        {
            using (FtdUsbPort port = new FtdUsbPort())
            {
                // configure usb port
                port.BaudRate = taxaTransferencia;
                port.DataBits = dataBits;

                if (bitParidade == "Sem")
                    port.Parity = FtdParity.None;
                else if (bitParidade == "Ímpar")
                    port.Parity = FtdParity.Odd;
                else
                    port.Parity = FtdParity.Even;

                if (bitParada == "1")
                    port.StopBits = FtdStopBits.One;
                else
                    port.StopBits = FtdStopBits.Two;

                port.OpenByIndex(0);

                // create modbus master
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                byte slaveId = bitID;
                ushort startAddress = bitEndereco;
                bool[] bobinas = new bool[bitBobinas];
                

                master.WriteMultipleCoils(slaveId, startAddress, bobinas);
            }
        }

        public static void LeBobinas(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, int bitBobinas)
        {
            using (FtdUsbPort port = new FtdUsbPort())
            {
                // configure usb port
                port.BaudRate = taxaTransferencia;
                port.DataBits = dataBits;

                if (bitParidade == "Sem")
                    port.Parity = FtdParity.None;
                else if (bitParidade == "Ímpar")
                    port.Parity = FtdParity.Odd;
                else
                    port.Parity = FtdParity.Even;

                if (bitParada == "1")
                    port.StopBits = FtdStopBits.One;
                else
                    port.StopBits = FtdStopBits.Two;

                port.OpenByIndex(0);

                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                bool[] bobinas = new bool[bitBobinas];

                ushort[] registers = master.ReadCoils(bitID, bitEndereco, bobinas);
            }
        }
        public static string porta;
        public static int taxaTransferencia;
        public static int dataBits;
        public static string bitParidade;
        public static string bitParada;
        public static byte bitID;
        public static ushort bitEndereco;
        public static ushort[] bitBobinasEscreve;
        public static ushort bitBobinasLe;
        public static ushort[] registros;
        public static int tempo;
        public static bool flagOK = false;
        public static int totalContagens = 0;

    }
}
