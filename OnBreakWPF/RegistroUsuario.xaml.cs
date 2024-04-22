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
using OnBreakDatos;
using OnBreakNegocio;

namespace OnBreakWPF
{
    /// <summary>
    /// Lógica de interacción para RegistroUsuario.xaml
    /// </summary>
    public partial class RegistroUsuario : Window
    {
        //global
        cliente cli = new cliente();
        contrato con = new contrato();

        public RegistroUsuario()
        {
            InitializeComponent();
            CargarActividades();
            CargarTipoEmpresa();
        }
        private void CargarTipoEmpresa()
        {
            cbxTipoE.ItemsSource = new tipoEmpresa().Obtener();
            cbxTipoE.DisplayMemberPath = "Descripcion";
            cbxTipoE.SelectedValuePath = "IdTipoEmpresa";
            cbxTipoE.SelectedIndex = 0;
        }

        private void CargarActividades()
        {
            cbxActividad.ItemsSource = new actividadEmpresa().Obtener();
            cbxActividad.DisplayMemberPath = "Descripcion";
            cbxActividad.SelectedValuePath = "IdActividadEmpresa";
            cbxActividad.SelectedIndex = 0;

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {



            try
            {
                cli.RutCliente = txtRUT.Text;
                cli.RazonSocial = txtRazon.Text;
                cli.NombreContacto = txtNombre.Text;
                cli.MailContacto = txtEmail.Text;
                cli.Direccion = txtDireccion.Text;
                cli.Telefono = txtTelefono.Text;
                cli.ActividadEmpresa = new actividadEmpresa() { idActividadEmpresa = (int)cbxActividad.SelectedValue };
                cli.TipoEmpresa = new tipoEmpresa() { idTipoEmpresa = (int)cbxTipoE.SelectedValue };


                if (string.IsNullOrEmpty(txtRUT.Text) || string.IsNullOrEmpty(txtRazon.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text))
                {

                    MessageBox.Show("Debe completar la informacion");

                    return;
                }

                if (cli.agregarCliente() == true)
                {
                    MessageBox.Show("CLIENTE GRUARDADO");
                    txtRUT.Text = string.Empty;
                    txtRazon.Text = string.Empty;
                    txtNombre.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtDireccion.Text = string.Empty;
                    txtTelefono.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente");
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar cliente");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                cli.RutCliente = txtRUT.Text;

                if (cli.eliminarCliente() == true)

                {
                    MessageBox.Show("Se ha eliminado al cliente correctamente!");
                }
                else
                {
                   
                   
                    MessageBox.Show("No se ha podido eliminar al cliente!");
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al elinimar cliente");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaPrincipal = new MainWindow();
            VentanaPrincipal.Show();
            this.Close();
        }

        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cli.RutCliente = txtRUT.Text;
                cliente c = cli.BuscarCliente();

                if (c == null)
                {
                    MessageBox.Show("CLIENTE NO REGISTRADO");
                }
                else
                {
                    txtRUT.Text = c.RutCliente;
                    txtRazon.Text = c.RazonSocial;
                    txtNombre.Text = c.NombreContacto;
                    txtEmail.Text = c.MailContacto;
                    txtDireccion.Text = c.Direccion;
                    txtTelefono.Text = c.Telefono;

                    var lae = new actividadEmpresa().Obtener();
                    var oae = lae.Where(d => d.IdActividadEmpresa == c.ActividadEmpresa.idActividadEmpresa).First();
                    var indiceActividadEmpresa = lae.IndexOf(oae);
                    cbxActividad.SelectedIndex = indiceActividadEmpresa;

                    var lte = new tipoEmpresa().Obtener();
                    var ote = lte.Where(d => d.IdTipoEmpresa == c.TipoEmpresa.idTipoEmpresa).First();
                    var indiceTipoE = lte.IndexOf(ote);
                    cbxTipoE.SelectedIndex = indiceTipoE;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar");
            }
        }

        private void BtnContraste_Click(object sender, RoutedEventArgs e)
        {
            this.gridBlack.Visibility = Visibility.Visible;
            this.btnContraste.Visibility = Visibility.Hidden;
            this.btnContraste1.Visibility = Visibility.Visible;
            this.gridDown.Visibility = Visibility.Visible;
            this.btnBack1.Visibility = Visibility.Hidden;
            this.btnBack.Visibility = Visibility.Visible;
            this.lb1.Visibility = Visibility.Hidden;
            this.lb2.Visibility = Visibility.Hidden;
            this.lb3.Visibility = Visibility.Hidden;
            this.lb4.Visibility = Visibility.Hidden;
            this.lb5.Visibility = Visibility.Hidden;
            this.lb6.Visibility = Visibility.Hidden;
            this.lb7.Visibility = Visibility.Hidden;
            this.lb8.Visibility = Visibility.Hidden;
            this.lb9.Visibility = Visibility.Hidden;



        }

        private void BtnContraste_Click1(object sender, RoutedEventArgs e)
        {
            this.gridBlack.Visibility = Visibility.Hidden;
            this.btnContraste.Visibility = Visibility.Visible;
            this.gridDown.Visibility = Visibility.Hidden;
            this.btnBack1.Visibility = Visibility.Visible;
            this.lb1.Visibility = Visibility.Visible;
            this.lb2.Visibility = Visibility.Visible;
            this.lb3.Visibility = Visibility.Visible;
            this.lb4.Visibility = Visibility.Visible;
            this.lb5.Visibility = Visibility.Visible;
            this.lb6.Visibility = Visibility.Visible;
            this.lb7.Visibility = Visibility.Visible;
            this.lb8.Visibility = Visibility.Visible;
            this.lb9.Visibility = Visibility.Visible;




        }
    }
}

