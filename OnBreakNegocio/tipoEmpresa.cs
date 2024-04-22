using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreakDatos;

namespace OnBreakNegocio
{
    public class tipoEmpresa
    {
        public int idTipoEmpresa { get; set; }
        public string Descripcion { get; set; }


        public tipoEmpresa()
        {
            Init();
        }

        private void Init()
        {
            idTipoEmpresa = 0;
            Descripcion = string.Empty;

        }

        /// <summary>
        /// Gets List the TipoE.
        /// </summary>
        /// <returns></returns>

        public List<OnBreakDatos.TipoEmpresa> Obtener()
        {
            List<OnBreakDatos.TipoEmpresa> TipoE = null;
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    TipoE = db.TipoEmpresa.ToList();
                }
                return TipoE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<object> filtrarTipoE(int IdTipoEmpresa)
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var listado = (from a in db.Cliente
                                   where a.IdTipoEmpresa == IdTipoEmpresa
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
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
