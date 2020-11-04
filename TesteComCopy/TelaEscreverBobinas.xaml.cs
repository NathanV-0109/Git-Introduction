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
    /// Interaction logic for TelaEscreverBobinas.xaml
    /// </summary>
    public partial class TelaEscreverBobinas : Window
    {
        public TelaEscreverBobinas()
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
                if (rdSelec0.IsChecked == true) RTU.bitBobinasEscreve = 0;
                else RTU.bitBobinasEscreve = 1;
                RTU.EscreveBobinas(RTU.porta, RTU.taxaTransferencia, RTU.dataBits, RTU.bitParidade, RTU.bitParada, RTU.bitID, Convert.ToUInt16(txtBobina.Text), RTU.bitBobinasEscreve);
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
                return;
            }
        }
    }
}
