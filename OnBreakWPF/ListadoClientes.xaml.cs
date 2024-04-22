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
using System.Windows.Shapes;
using OnBreakNegocio;
using OnBreakDatos;

namespace OnBreakWPF
{
    /// <summary>
    /// Lógica de interacción para ListadoClientes.xaml
    /// </summary>
    public partial class ListadoClientes : Window
    {
        public ListadoClientes()
        {
            InitializeComponent();
            CargarLista();
            CargarActividadE();
            CargarTipoE();
        }

        private void CargarTipoE()
        {
            cbxTipoE.ItemsSource = new tipoEmpresa().Obtener();
            cbxTipoE.DisplayMemberPath = "Descripcion";
            cbxTipoE.SelectedValuePath = "idTipoEmpresa";
        }

        private void CargarActividadE()
        {
            cbxActividadE.ItemsSource = new actividadEmpresa().Obtener();
            cbxActividadE.DisplayMemberPath = "Descripcion";
            cbxActividadE.SelectedValuePath = "idActividadEmpresa";
        }

        private void CargarLista()
        {
            dgListaClientes.ItemsSource = new cliente().Obtener();
            dgListaClientes.Items.Refresh();
        }

        private void CbxActividadE_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var indice = cbxActividadE.SelectedIndex;
            var p = cbxActividadE.SelectedItem;
            var id = ((OnBreakDatos.ActividadEmpresa)p).IdActividadEmpresa;
            dgListaClientes.ItemsSource = new actividadEmpresa().filtrarActividad(id);
            dgListaClientes.Items.Refresh();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaPrincipal = new MainWindow();
            VentanaPrincipal.Show();
            this.Close();
        }

        private void TxtBuscarRut_KeyUp(object sender, KeyEventArgs e)
        {
            dgListaClientes.ItemsSource = new cliente().buscarPorRut(txtBuscarRut.Text);
            dgListaClientes.Items.Refresh();
        }

        private void DgListaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CbxTipoE_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = cbxTipoE.SelectedItem;
            var id = ((OnBreakDatos.TipoEmpresa)p).IdTipoEmpresa;
            dgListaClientes.ItemsSource = new tipoEmpresa().filtrarTipoE(id);
            dgListaClientes.Items.Refresh();
        }

        private void BtnBack_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaPrincipal = new MainWindow();
            VentanaPrincipal.Show();
            this.Close();
        }

        private void BtnContraste_Click(object sender, RoutedEventArgs e)
        {
            this.gridBlack.Visibility = Visibility.Visible;
            this.btnContraste.Visibility = Visibility.Hidden;
            this.btnContraste1.Visibility = Visibility.Visible;
            this.btnBack1.Visibility = Visibility.Hidden;
            this.btnBack.Visibility = Visibility.Visible;
            this.lb1.Visibility = Visibility.Hidden;
            this.lb2.Visibility = Visibility.Hidden;
            this.lb3.Visibility = Visibility.Hidden;
            this.lb4.Visibility = Visibility.Hidden;
            this.lb5.Visibility = Visibility.Hidden;



        }

        private void BtnContraste_Click1(object sender, RoutedEventArgs e)
        {
            this.gridBlack.Visibility = Visibility.Hidden;
            this.btnContraste.Visibility = Visibility.Visible;
            this.btnBack1.Visibility = Visibility.Visible;
            this.lb1.Visibility = Visibility.Visible;
            this.lb2.Visibility = Visibility.Visible;
            this.lb3.Visibility = Visibility.Visible;
            this.lb4.Visibility = Visibility.Visible;
            this.lb5.Visibility = Visibility.Visible;


        }
    }
}
