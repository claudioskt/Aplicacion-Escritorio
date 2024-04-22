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
using System.Globalization;


namespace OnBreakWPF
{
    /// <summary>
    /// Lógica de interacción para AgregarContrato.xaml
    /// </summary>
    public partial class AgregarContrato : Window
    {
        //global
        contrato con = new contrato();
        cliente cli = new cliente();


        public AgregarContrato()
        {
            InitializeComponent();
            CargarTipoEvento();


        }
        private void CargarTipoEvento()
        {
            cbxTipoEvento.ItemsSource = new tipoEvento().Obtener();
            cbxTipoEvento.DisplayMemberPath = "Descripcion";
            cbxTipoEvento.SelectedValuePath = "IdTipoEvento";
            cbxTipoEvento.SelectedIndex = 0;
        }

        private void CbxTipoEvento_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow VentanaPrincipal = new MainWindow();
            VentanaPrincipal.Show();
            this.Close();
        }

        private void BtnGuardar_Click_2(object sender, RoutedEventArgs e)
        {
           
            DateTime d = DateTime.Now;
            string date = d.ToString("yyyyMMddHHmm");


            try
            {
                con.NumeroCon = date;
                con.Fcreacion = DateTime.Today;
                con.Ftermino = Convert.ToDateTime(txtFecTer.Text);
                con.RutCliente = new cliente() { RutCliente = txtRUT.Text };
                con.Modalidad = new modalidadServicio() { idModalidad = (string)cbxModalidadServicio1.SelectedValue };
                con.TipoEvento = new tipoEvento() { idTipoEvento = (int)cbxTipoEvento.SelectedValue };
                con.FechaHoraIn = tpInicio.Text;
                con.FechaHoraTer = tpTerm.Text;
                con.asistentes = int.Parse(txtNasistentes.Text);
                con.personalAdicional = int.Parse(txtPersonalAdicional.Text);

                if (chbxRealizado.IsChecked == true)
                {
                    con.realizado = true;
                }
                else
                {
                    con.realizado = false;
                }


                //con.ValorContrato = int.Parse(txtValor.Text);
                con.observaciones = txtObservaciones.Text;


                if (con.agregarContrato() == true)
                {
                    MessageBox.Show("CONTRATO AGREGADO");
                    txtRUT.Text = string.Empty;
                    //dpTxtInicio.Text = string.Empty;
                    //dpTxtTerm.Text = string.Empty;
                    txtNasistentes.Text = string.Empty;
                    txtPersonalAdicional.Text = string.Empty;
                    txtObservaciones.Text = string.Empty;
                    
                }
                else
                {
                    MessageBox.Show("NO SE PUDO AGREGAR EL CONTRATO");
                }



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void BtnVerListado_Click(object sender, RoutedEventArgs e)
        {
            ListadoContratos listadoContratos = new ListadoContratos();
            listadoContratos.Show();
            this.Close();
        }

        private void CbxTipoEvento_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            cbxModalidadServicio1.ItemsSource = new modalidadServicio().ListModalidad((int)cbxTipoEvento.SelectedValue);
            cbxModalidadServicio1.DisplayMemberPath = "Nombre";
            cbxModalidadServicio1.SelectedValuePath = "IdModalidad";
            cbxModalidadServicio1.SelectedIndex = 0;
        //    cbxModalidadServicio1.ItemsSource = new modalidadServicio().ListModalidad((int)cbxTipoEvento.SelectedValue);
        //    cbxModalidadServicio1.DisplayMemberPath = "Nombre";
        //    cbxModalidadServicio1.SelectedValuePath = "IdModalidad";
        //    cbxModalidadServicio1.SelectedIndex = 0;

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
            this.lb10.Visibility = Visibility.Hidden;
            this.lb11.Visibility = Visibility.Hidden;




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
            this.lb10.Visibility = Visibility.Visible;
            this.lb11.Visibility = Visibility.Visible;



        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            var stridModalidad = (string)cbxModalidadServicio1.SelectedValue ;
            var intidTipoEvento = (int)cbxTipoEvento.SelectedValue ;

           txtValor.Text = "UF "+con.calcular_contrato(stridModalidad, intidTipoEvento, int.Parse(txtPersonalAdicional.Text), int.Parse(txtNasistentes.Text)).ToString();

        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
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
                    txtRazon.Text = c.RazonSocial;
                  

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar");
            }
        }

        private void TxtNasistentes_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void TxtFecTer_Error(object sender, ValidationErrorEventArgs e)
        {

        }
    }
}
