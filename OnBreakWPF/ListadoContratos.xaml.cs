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
    /// Lógica de interacción para ListadoContratos.xaml
    /// </summary>
    public partial class ListadoContratos : Window
    {
        public ListadoContratos()
        {
            InitializeComponent();
            CargarTipoEve();
            CargarLista();
            CargarModalidad();

        }

        

        private void CargarTipoEve()
        {
            cbxTipoEve.ItemsSource = new tipoEvento().Obtener();
            cbxTipoEve.DisplayMemberPath = "Descripcion";
            cbxTipoEve.SelectedValuePath = "IdTipoEvento";
        }

        private void CargarModalidad()
        {
            cbxModalidad.ItemsSource = new modalidadServicio().Obtener();
            cbxModalidad.DisplayMemberPath = "Nombre";
            cbxModalidad.SelectedValuePath = "IdModalidad";
        }

        private void CbxModalidad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var p = cbxModalidad.SelectedItem;
            var id = ((OnBreakDatos.ModalidadServicio)p).IdModalidad;
            dgListaContratos.ItemsSource = new modalidadServicio().filtrarModalidad(id);
            dgListaContratos.Items.Refresh();
        }

        private void CargarLista()
        {
            dgListaContratos.ItemsSource = new contrato().Obtener();
            dgListaContratos.Items.Refresh();
        }

        private void CbxTipoEve_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //cbxModalidad.ItemsSource = new modalidadServicio().ListModalidad((int)cbxTipoEve.SelectedValue);
            //cbxModalidad.DisplayMemberPath = "Nombre";
            //cbxModalidad.SelectedValuePath = "IdModalidad";
            //cbxModalidad.SelectedIndex = 0;

            var p = cbxTipoEve.SelectedItem;
            var id = ((OnBreakDatos.TipoEvento)p).IdTipoEvento;
            dgListaContratos.ItemsSource = new tipoEvento().filtrarEvento(id);
            dgListaContratos.Items.Refresh();
        }

        private void TxtBuscarNro_KeyUp(object sender, KeyEventArgs e)
        {
            dgListaContratos.ItemsSource = new contrato().BuscarContratoNro(txtBuscarNro.Text);
            dgListaContratos.Items.Refresh();
        }

        private void TxtBuscarRut_KeyUp(object sender, KeyEventArgs e)
        {
            dgListaContratos.ItemsSource = new contrato().BuscarContratoRut(txtBuscarRut.Text);
            dgListaContratos.Items.Refresh();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
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
            this.lb6.Visibility = Visibility.Hidden;




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
            this.lb6.Visibility = Visibility.Visible;



        }
    }
}
