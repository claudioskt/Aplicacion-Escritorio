using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreakDatos;
using OnBreakNegocio;

namespace OnBreakNegocio
{
    public class modalidadServicio
    {
        public string idModalidad { get; set; }
        public tipoEvento idTipoEvento { get; set; }
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public string PersonalBase { get; set; }

        public modalidadServicio()
        {
            Init();
        }

        private void Init()
        {
            idModalidad = string.Empty;
            idTipoEvento = new tipoEvento();
            Nombre = string.Empty;
            ValorBase = 0;
            PersonalBase = string.Empty;
        }

        public IEnumerable<object> ListModalidad(int idTipoEvento)
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var listado = (from a in db.ModalidadServicio
                                   where a.IdTipoEvento == idTipoEvento
                                   select a).ToList();
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public IEnumerable<object> filtrarModalidad(string IdModalidad)
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var listado = (from a in db.Contrato
                                   where a.IdModalidad == IdModalidad
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

                                   }).ToList();
                    return listado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<OnBreakDatos.ModalidadServicio> Obtener()
        {
            List<OnBreakDatos.ModalidadServicio> Mod = null;
            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    Mod = db.ModalidadServicio.ToList();
                }
                return Mod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
