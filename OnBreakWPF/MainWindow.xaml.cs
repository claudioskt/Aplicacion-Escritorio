using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OnBreakWPF;

namespace OnBreakWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        
        private void BtnRegistroCli_Click(object sender, RoutedEventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Close();
        }

        private void BtnListaClientes_Click(object sender, RoutedEventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {

            this.gridSalir.Visibility = Visibility.Visible;
        }

        private void BtnCrearContrato_Click_1(object sender, RoutedEventArgs e)
        {
            AgregarContrato agregar = new AgregarContrato();
            agregar.Show();
            this.Close();
        }

        private void BtnListaContratos_Click_1(object sender, RoutedEventArgs e)
        {
            ListadoContratos listadoContratos = new ListadoContratos();
            listadoContratos.Show();
            this.Close();
        }

        private void GridBlack_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }



        private void BtnContraste_Click(object sender, RoutedEventArgs e)
        {
            this.gridToHide.Visibility = Visibility.Visible;
            this.btnContraste.Visibility = Visibility.Hidden;
            this.btnContraste1.Visibility = Visibility.Visible;
            this.header1.Visibility = Visibility.Visible;
            this.btnSalir.Visibility = Visibility.Hidden;
            this.btnSalir1.Visibility = Visibility.Visible;

        }

        private void BtnContraste_Click1(object sender, RoutedEventArgs e)
        {
            this.gridToHide.Visibility = Visibility.Hidden;
            this.btnContraste.Visibility = Visibility.Visible;
            this.header1.Visibility = Visibility.Hidden;
            this.btnSalir.Visibility = Visibility.Visible;



        }

        private void BtnSis_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnNos_Click(object sender, RoutedEventArgs e)
        {
            this.gridSalir.Visibility = Visibility.Hidden;
        }
    }
}
