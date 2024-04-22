using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreakDatos;

namespace OnBreakNegocio
{
    public class cliente
    {
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string MailContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public actividadEmpresa ActividadEmpresa { get; set; }
        public tipoEmpresa TipoEmpresa { get; set; }

        private OnBreakDBEntities conexion;


        public cliente()
        {
            this.Init();
        }

        private void Init()
        {
            RutCliente = string.Empty;
            RazonSocial = string.Empty;
            NombreContacto = string.Empty;
            MailContacto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            ActividadEmpresa = new actividadEmpresa();
            TipoEmpresa = new tipoEmpresa();
            conexion = new OnBreakDBEntities();
        }
        public bool agregarCliente()
        {
            try
            {
                Cliente Cli = new Cliente();
                Cli.RutCliente = this.RutCliente;
                Cli.RazonSocial = this.RazonSocial;
                Cli.NombreContacto = this.NombreContacto;
                Cli.MailContacto = this.MailContacto;
                Cli.Direccion = this.Direccion;
                Cli.Telefono = this.Telefono;
                Cli.IdActividadEmpresa = this.ActividadEmpresa.idActividadEmpresa;
                Cli.IdTipoEmpresa = this.TipoEmpresa.idTipoEmpresa;

                conexion.Cliente.Add(Cli);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public bool eliminarCliente()
        {
            try
            {
                conexion.Cliente.Remove(conexion.Cliente.Find(this.RutCliente));

                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public cliente BuscarCliente()
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    Cliente CLIENTE = db.Cliente.Find(this.RutCliente);


                    cliente cli = new cliente();
                    cli.RutCliente = CLIENTE.RutCliente;
                    cli.RazonSocial = CLIENTE.RazonSocial;
                    cli.NombreContacto = CLIENTE.NombreContacto;
                    cli.MailContacto = CLIENTE.MailContacto;
                    cli.Direccion = CLIENTE.Direccion;
                    cli.Telefono = CLIENTE.Telefono;
                    cli.ActividadEmpresa = new actividadEmpresa() { idActividadEmpresa = CLIENTE.ActividadEmpresa.IdActividadEmpresa, Descripcion = CLIENTE.ActividadEmpresa.Descripcion };
                    cli.TipoEmpresa = new tipoEmpresa() { idTipoEmpresa = CLIENTE.TipoEmpresa.IdTipoEmpresa, Descripcion = CLIENTE.TipoEmpresa.Descripcion };


                    return cli;
                }
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public IEnumerable<object> buscarPorRut(string RutCliente)
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var lista = (from a in db.Cliente
                                 where a.RutCliente.Contains(RutCliente)
                                 select new
                                 {
                                     RUT = a.RutCliente,
                                     RAZON = a.RazonSocial,
                                     NOMBRE = a.NombreContacto,
                                     EMAIL = a.MailContacto,
                                     DIRECCION = a.Direccion,
                                     TELEFONO = a.Telefono,
                                     ACTIVIDAD = a.ActividadEmpresa.Descripcion,
                                     TIPO = a.TipoEmpresa.Descripcion
                                 }).ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public IEnumerable<object> Obtener()
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                   var ListaClientes = (from a in db.Cliente
                                     select new
                                     {
                                         RUT =  a.RutCliente,
                                         RAZON = a.RazonSocial,
                                         NOMBRE = a.NombreContacto,
                                         EMAIL = a.MailContacto,
                                         DIRECCION = a.Direccion,
                                         TELEFONO = a.Telefono,
                                         ACTIVIDAD = a.ActividadEmpresa.Descripcion,
                                         TIPO = a.TipoEmpresa.Descripcion
                                     }
                                     ).ToList();
                    return ListaClientes;
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
