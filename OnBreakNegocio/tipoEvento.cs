using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreakDatos;

namespace OnBreakNegocio
{
    public class tipoEvento
    {
        public int idTipoEvento { get; set; }
        public string Descripcion { get; set; }


        public tipoEvento()
        {
            Init();
        }

        private void Init()
        {
            idTipoEvento = 0;
            Descripcion = string.Empty;
        }

        public List<OnBreakDatos.TipoEvento> Obtener()
        {
            List<OnBreakDatos.TipoEvento> Tipoev = null;
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    Tipoev = db.TipoEvento.ToList();
                }
                return Tipoev;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public IEnumerable<object> filtrarEvento(int IdTipoEvento)
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var listado = (from a in db.Contrato
                                   where a.IdTipoEvento == IdTipoEvento
                                   select new
                                   {
                                       NUMERO = a.Numero,
                                       CREACION = a.Creacion,
                                       TERMINO = a.Termino,
                                       RUT = a.RutCliente,
                                       MODALIDAD = a.ModalidadServicio.Nombre,
                                       TIPOEVENTO = a.ModalidadServicio.TipoEvento.Descripcion,
                                       HORAINICIO = a.FechaHoraInicio,
                                       HORATERMINO = a.FechaHoraTermino,
                                       ASISTENTES = a.Asistentes,
                                       PERSONAL = a.PersonalAdicional,
                                       REALIZADO = a.Realizado,
                                       VALORTOTAL = a.ValorTotalContrato,
                                       OBSERVACIONES = a.Observaciones

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
