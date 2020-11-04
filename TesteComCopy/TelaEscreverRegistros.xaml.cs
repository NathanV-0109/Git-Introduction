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

namespace TesteComCopy
{
    /// <summary>
    /// Interaction logic for TelaEscreverRegistros.xaml
    /// </summary>
    public partial class TelaEscreverRegistros : Window
    {
        public TelaEscreverRegistros()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RTU.EscreveRegistro(RTU.porta, RTU.taxaTransferencia, RTU.dataBits, RTU.bitParidade, RTU.bitParada, RTU.bitID, Convert.ToUInt16(txtNumRegistro.Text), Convert.ToUInt16(txtValorRegistro.Text));
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }
    }
}
