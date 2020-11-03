using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO.Ports;

namespace TesteComCopy
{
    /// <summary>
    /// Interaction logic for TelaConectar.xaml
    /// </summary>
    public partial class TelaConectar : Window
    {
        public TelaConectar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RTU.porta = cbPortas.Text;
                RTU.taxaTransferencia = Convert.ToUInt16(cbTaxa.Text);
                if (rdSem.IsChecked == true)
                    RTU.bitParidade = "Sem";
                else if (rdImpar.IsChecked == true)
                    RTU.bitParidade = "Ímpar";
                else
                    RTU.bitParidade = "Par";

                if (rd7b.IsChecked == true)
                    RTU.dataBits = 7;
                else
                    RTU.dataBits = 8;

                if (rd1.IsChecked == true)
                    RTU.bitParada = "1";
                else
                    RTU.bitParada = "2";

                RTU.registros = RTU.LeRegistro(RTU.porta, RTU.taxaTransferencia, RTU.dataBits, RTU.bitParidade, RTU.bitParada, RTU.bitID, RTU.bitEndereco, RTU.bitBobinasLe);
                RTU.flagOK = true;
            }
            catch
            {
                RTU.flagOK = false;
                MessageBox.Show("Algo deu errado!");
            }

            Window1 Principal = new Window1();
            this.Close();
            Principal.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 Principal = new Window1();
            this.Close();
            Principal.Show();
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] portas = SerialPort.GetPortNames();

            foreach (string porta in portas)
                cbPortas.Items.Add(porta);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] portas = SerialPort.GetPortNames();

            foreach (string porta in portas)
                cbPortas.Items.Add(porta);
        }

    }
}
