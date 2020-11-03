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
    /// Interaction logic for TelaMensagens.xaml
    /// </summary>
    public partial class TelaMensagens : Window
    {
        public TelaMensagens()
        {
            InitializeComponent();
        }

        private void btn_TrocaModo(object sender, RoutedEventArgs e)
        {
            ControleParar.Header = ControleParar.Header.ToString() == "Parar" ? "Continuar" : "Parar";     
        }

        private void btn_FechaTela(object sender, RoutedEventArgs e)
        {
            Window1 Principal = new Window1();
            this.Close();
            Principal.Show();
        }
    }
}
