﻿#pragma checksum "..\..\Window1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D3962A00C61B2D8D063657C711079ADC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9151
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TesteComCopy {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox txtID;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox txtEndereco;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox txtNumBobinas;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window1.xaml"
        internal System.Windows.Controls.GroupBox groupBox1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Window1.xaml"
        internal System.Windows.Controls.Grid grid1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton rdLeBobina;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Window1.xaml"
        internal System.Windows.Controls.RadioButton rdLeRegistro;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Window1.xaml"
        internal System.Windows.Controls.Menu menu1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Window1.xaml"
        internal System.Windows.Controls.MenuItem Registro;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Window1.xaml"
        internal System.Windows.Controls.MenuItem Bobina;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox txtTempoScan;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label5;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Window1.xaml"
        internal System.Windows.Controls.Button button1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label6;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label label7;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Window1.xaml"
        internal System.Windows.Controls.TextBox txtMostra;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lblTotal;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Window1.xaml"
        internal System.Windows.Controls.Label lblFalhas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TesteComCopy;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\Window1.xaml"
            ((TesteComCopy.Window1)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtID = ((System.Windows.Controls.TextBox)(target));
            
            #line 14 "..\..\Window1.xaml"
            this.txtID.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtID_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtEndereco = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtNumBobinas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.groupBox1 = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 9:
            this.grid1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.rdLeBobina = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.rdLeRegistro = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 12:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.menu1 = ((System.Windows.Controls.Menu)(target));
            return;
            case 14:
            
            #line 28 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click_1);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 29 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_AbriTela);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 30 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_FechaTela);
            
            #line default
            #line hidden
            return;
            case 17:
            this.Registro = ((System.Windows.Controls.MenuItem)(target));
            
            #line 33 "..\..\Window1.xaml"
            this.Registro.Click += new System.Windows.RoutedEventHandler(this.btn_mostraEscreveRegistros);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Bobina = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\Window1.xaml"
            this.Bobina.Click += new System.Windows.RoutedEventHandler(this.btn_mostraEscreveBobinas);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 35 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.btn_mostrarMensagens);
            
            #line default
            #line hidden
            return;
            case 20:
            this.txtTempoScan = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\Window1.xaml"
            this.txtTempoScan.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTempoScan_TextChanged);
            
            #line default
            #line hidden
            
            #line 39 "..\..\Window1.xaml"
            this.txtTempoScan.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnKeyDownHandler);
            
            #line default
            #line hidden
            return;
            case 21:
            this.label5 = ((System.Windows.Controls.Label)(target));
            return;
            case 22:
            this.button1 = ((System.Windows.Controls.Button)(target));
            return;
            case 23:
            this.label6 = ((System.Windows.Controls.Label)(target));
            return;
            case 24:
            this.label7 = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.txtMostra = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\Window1.xaml"
            this.txtMostra.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 26:
            this.lblTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 27:
            this.lblFalhas = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
