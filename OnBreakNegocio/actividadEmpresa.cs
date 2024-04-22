using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreakDatos;

namespace OnBreakNegocio
{
    public class actividadEmpresa
    {
        public int idActividadEmpresa { get; set; }
        public string Descripcion { get; set; }



        public actividadEmpresa()
        {
            Init();
        }

        private void Init()
        {
            idActividadEmpresa = 0;
            Descripcion = string.Empty;

        }
        /// <summary>
        /// Gets List the ActividadE.
        /// </summary>
        /// <returns></returns>

        public List<OnBreakDatos.ActividadEmpresa> Obtener()
        {
            List<OnBreakDatos.ActividadEmpresa> ActividadE = null;
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    ActividadE = db.ActividadEmpresa.ToList();
                }
                return ActividadE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Gets List the filtrarActividad.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> filtrarActividad(int IdActividadEmpresa)
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var listado = (from a in db.Cliente
                                   where a.IdActividadEmpresa == IdActividadEmpresa
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
                                   }
                                         ).ToList();
                    return  listado;
                }  
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

