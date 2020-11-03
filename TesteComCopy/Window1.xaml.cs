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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace TesteComCopy
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        public Window1()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_AbriTela(object sender, RoutedEventArgs e)
        {
            try
            {
                RTU.bitID = Convert.ToByte(txtID.Text);
                RTU.bitEndereco = Convert.ToUInt16(txtEndereco.Text);
                RTU.bitBobinasLe = Convert.ToUInt16(txtNumBobinas.Text);
               


                TelaConectar Conectar = new TelaConectar();
                this.Hide();
                Conectar.Show();
            }
            catch 
            {
                MessageBox.Show("Dados inválidos");
                return;
            }
        }
        private void btn_FechaTela(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_mostrarMensagens(object sender, RoutedEventArgs e)
        {
            TelaMensagens telaMensagens = new TelaMensagens();
            this.Hide();
            telaMensagens.Show();
        }

        private void btn_TrocaModo(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (RTU.flagOK)
            {
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, RTU.tempo);
                dispatcherTimer.Start();
            }
            else 
            {
                dispatcherTimer.Stop();
            }
        }

        private void richTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            
            int total = RTU.totalContagens++;
            lblTotal.Content = total.ToString();

            if (rdLeRegistro.IsChecked)
            {
                RTU.registros = RTU.LeRegistro(RTU.porta, RTU.taxaTransferencia, RTU.dataBits, RTU.bitParidade, RTU.bitParada, RTU.bitID, RTU.bitEndereco, RTU.bitBobinasLe);
                txtMostra.Clear();

                for (int i = 0; i < RTU.registros.Length; i++)
                {
                    ushort aux = RTU.registros[i];
                    if (aux > 60000)
                    {
                        int temp = 65545 - (int)aux - 9;
                        aux = Convert.ToUInt16(temp);
                    }
                    txtMostra.Text += "<" + aux.ToString() + ">" + Environment.NewLine;
                }
            }
            else
            {

            }

            
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                try
                {
                    dispatcherTimer.Stop();
                    RTU.flagOK = false;
                    RTU.tempo = 0;
                    RTU.tempo = Convert.ToInt32(txtTempoScan.Text);
                    RTU.flagOK = true;
                    dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, RTU.tempo);
                    dispatcherTimer.Start();
                   
                }
                catch
                {
                    MessageBox.Show("Scan inválido!");
                    return;
                }
            }
        }
        private void txtTempoScan_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
