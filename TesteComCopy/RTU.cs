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
        public static void EscreveRegistro(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, ushort bitBobinas)
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
                ushort registers = bitBobinas;
                master.Transport.WriteTimeout = 150;

                //master.WriteMultipleRegisters(slaveId, startAddress, registers);
                master.WriteSingleRegister(slaveId, startAddress, bitBobinas);
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
                master.Transport.ReadTimeout = 150;

                leitura = master.ReadInputRegisters(slaveId, startAddress, bitBobinas);

                return leitura;
            }
        }

        public static void EscreveBobinas(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, int bitBobinas)
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

                // create modbus master
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);

                byte slaveId = bitID;
                ushort startAddress = bitEndereco;
                //bool[] bobinas = new bool[bitBobinas];
                bool auxiliar = bitBobinas == 1 ? true : false;

                //master.WriteMultipleCoils(slaveId, startAddress, bobinas);
                master.WriteSingleCoil(slaveId, startAddress, auxiliar);
            }
        }

        public static bool[] LeBobinas(string porta, int taxaTransferencia, int dataBits, string bitParidade, string bitParada, byte bitID, ushort bitEndereco, int bitBobinas)
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
                master.Transport.ReadTimeout = 150;

                ushort bobinas = Convert.ToUInt16(bitBobinas);

                bool[] registers = master.ReadCoils(bitID, bitEndereco, bobinas);

                return registers;
            }
        }
        public static string porta;
        public static int taxaTransferencia;
        public static int dataBits;
        public static string bitParidade;
        public static string bitParada;
        public static byte bitID;
        public static ushort bitEndereco;
        public static ushort bitBobinasEscreve;
        public static ushort bitBobinasLe;
        public static ushort[] registros;
        public static int tempo;
        public static bool flagOK = false;
        public static int totalContagens = 0;
        public static int totalContagens2 = 0;
        public static int modoBobinaRegistro = 0;
        public static bool[] Bobinas;
       

    }
}
