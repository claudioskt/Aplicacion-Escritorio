using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreakDatos;


namespace OnBreakNegocio
{
    public class contrato
    {
        public string NumeroCon { get; set; }
        public DateTime Fcreacion { get; set; }
        public DateTime Ftermino { get; set; }
        public cliente RutCliente { get; set; }
        public modalidadServicio Modalidad { get; set; }
        public tipoEvento TipoEvento { get; set; }
        public string FechaHoraIn { get; set; }
        public string FechaHoraTer { get; set; }
        public int asistentes { get; set; }
        public int personalAdicional { get; set; }
        public Boolean realizado { get; set; }
        public double ValorContrato { get; set; }
        public string observaciones { get; set; }
        private OnBreakDBEntities conexion;

       

        public double calcular_contrato( string idmodalidad, int idtipoevento, int cantpersonal, int cantasistentes)
        {     
           try
            {

                double resultado;
                using (var db = new OnBreakDBEntities())
                {
                    var Lista_Recargo_Asistentes = db.RecargoAsistentes.Where(c => c.IdTipoEvento == idtipoevento);
                    var valoruf_recargo_asistente = Lista_Recargo_Asistentes.Where(c => cantasistentes >= c.Min && cantasistentes <= c.Max).First().Recargo;

                    var Lista_Recargo_Personal = db.RecargoPersonal.Where(c => c.IdTipoEvento == idtipoevento);
                    var valoruf_recargo_personal = Lista_Recargo_Personal.Where(c => cantpersonal >= c.Min && cantpersonal <= c.Max).First().Recargo;

                    var valoruf_modalidad_servicio = db.ModalidadServicio.Where(c => c.IdModalidad == idmodalidad).First().ValorBase;
                    resultado = valoruf_modalidad_servicio + valoruf_recargo_asistente + valoruf_recargo_personal;

                    return resultado;
                }

            }
            catch (Exception ex)
                {

                    return 0;
                }
            }

        public contrato()
        {
            Init();
        }

        private void Init()
        {
            NumeroCon = string.Empty;
            Fcreacion = new DateTime();
            Ftermino = new DateTime();
            RutCliente = new cliente();
            Modalidad = new modalidadServicio();
            TipoEvento = new tipoEvento();
            FechaHoraIn = string.Empty;
            FechaHoraTer = string.Empty;
            asistentes = 0;
            personalAdicional = 0;
            realizado = new bool();
            ValorContrato = 0;
            observaciones = string.Empty;
            conexion = new OnBreakDBEntities();



        }

        public bool agregarContrato()
        {
            try
            {
                using (var db = new OnBreakDBEntities())
                {

                    var Lista_Recargo_Asistentes = db.RecargoAsistentes.Where(c => c.IdTipoEvento == this.TipoEvento.idTipoEvento);
                    var valoruf_recargo_asistente = Lista_Recargo_Asistentes.Where(c => this.asistentes >= c.Min && this.asistentes <= c.Max).First().Recargo;

                    var Lista_Recargo_Personal = db.RecargoPersonal.Where(c => c.IdTipoEvento == this.TipoEvento.idTipoEvento);
                    var valoruf_recargo_personal = Lista_Recargo_Personal.Where(c => this.personalAdicional >= c.Min && this.personalAdicional <= c.Max).First().Recargo;

                    var valoruf_modalidad_servicio = db.ModalidadServicio.Where(c => c.IdModalidad == this.Modalidad.idModalidad).First().ValorBase;

                    Contrato Con = new Contrato();
                    Con.Numero = this.NumeroCon;
                    Con.Creacion = this.Fcreacion;
                    Con.Termino = this.Ftermino;
                    Con.RutCliente = this.RutCliente.RutCliente;
                    Con.IdModalidad = this.Modalidad.idModalidad;
                    Con.IdTipoEvento = this.TipoEvento.idTipoEvento;
                    Con.FechaHoraInicio = this.FechaHoraIn;
                    Con.FechaHoraTermino = this.FechaHoraTer;
                    Con.Asistentes = this.asistentes;
                    Con.PersonalAdicional = this.personalAdicional;
                    Con.Realizado = this.realizado;
                    Con.ValorTotalContrato = valoruf_modalidad_servicio + valoruf_recargo_asistente + valoruf_recargo_personal;
                    Con.Observaciones = this.observaciones;

                    db.Contrato.Add(Con);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

       

        public IEnumerable BuscarContratoRut(string RutCliente)
        {

            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var lista = (from a in db.Contrato
                                 where a.RutCliente.Contains(RutCliente)
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
                    return lista;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public IEnumerable BuscarContratoNro(string NumeroCon)
        {

            try
            {
                using (var db = new OnBreakDBEntities())
                {
                    var lista = (from a in db.Contrato
                                 where a.Numero.Contains(NumeroCon)
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
                    var ListaContrato = (from a in db.Contrato
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
                    return ListaContrato;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}
