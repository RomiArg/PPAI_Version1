using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Llamada
    {
        /* Atributos de la clase Llamada */
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private float duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private List<RespuestaDeCliente> respuestasDeEncuesta;
        private Cliente cliente;
        private List<CambioEstado> cambiosEstado;

        /* Métodos constructores de la clase */
        public Llamada() 
        {
            CambiosEstado = new List<CambioEstado>();
        }
        public Llamada( float duracion, bool encuestaEnviada, List<RespuestaDeCliente> respuestasDeEncuesta, Cliente cliente, List<CambioEstado> cambiosEstado)
        {
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.respuestasDeEncuesta = respuestasDeEncuesta;
            this.cliente = cliente;
            this.cambiosEstado = cambiosEstado;
        }

        /* Métodos de seteo de las propiedades */
        public string DescripcionOperador { get; set; }
        public string DetalleAccionRequerida { get; set; }
        public float Duracion { get; set; }
        public bool EncuestaEnviada { get; set; }
        public string ObservacionAuditor { get; set; }
        public Cliente Cliente { get; set; }
        public List<RespuestaDeCliente> RespuestasDeEncuesta { get; set; }
        public List<CambioEstado> CambiosEstado { get; set; }

        /* Este método convierte a los atributos en string para mostrarlos */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Descripcion del operador:").Append(DescripcionOperador);
            sb.AppendLine("Detalle de Acción Requerida:").Append(detalleAccionRequerida);
            sb.AppendLine("Datos del cliente:").AppendLine(cliente.MostrarDatos());
            sb.AppendLine("Encuesta:"); 
            sb.AppendLine("Observación del auditor:").Append(observacionAuditor);
            sb.AppendLine("Estado:").Append(GetNombreClienteYEstado());

            return sb.ToString();
        }

        // COMENTADO POR SI ACASO
        //public string GetNombreCliente()
        //{
        //    return cliente.NombreCompleto;
        //}

        //public CambioEstado GetEstadoActual()
        //{
        //    CambioEstado ultimo = null;
        //    for (int i = 0; i < cambiosEstado.Count; i++)
        //    {
        //        if(i == 0)
        //        {
        //            ultimo = cambiosEstado[i];
        //        }
        //        if (cambiosEstado[i].FechaHoraInicio > ultimo.FechaHoraInicio)
        //        {
        //            ultimo = cambiosEstado[i];
        //        }
        //    }
        //    return ultimo;
        //}

        /* Métodos que son utilizados en la implementación del CU */
        public void CalcularDuracion()
        {
            CambioEstado inicial = null;
            CambioEstado final = null;
            for (int i = 0; i < cambiosEstado.Count; i++)
            {
                if (cambiosEstado[i].EsEstadoInicial())
                {
                    inicial = cambiosEstado[i];
                }
                if (cambiosEstado[i].EsEstadoFinal())
                {
                    final = cambiosEstado[i];
                }
            }

            TimeSpan diferencia = final.FechaHoraInicio - inicial.FechaHoraInicio;
            this.duracion = diferencia.Minutes;
        }

        public bool EsDePeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            CambioEstado inicial = null;
            for (int i = 0; i < CambiosEstado.Count; i++)
            {
                if (CambiosEstado[i].EsEstadoInicial())
                {
                    inicial = CambiosEstado[i];
                }
            }

            if (inicial != null)
            {
                if (inicial.FechaHoraInicio >= fechaInicio && inicial.FechaHoraInicio <= fechaFin)
                { 
                    return true;
                }
            }
            return false;
        }

        public bool TieneEncuestaRespondida()
        {
            return respuestasDeEncuesta != null;
        }

        public string GetNombreClienteYEstado()
        {
            string nombreCliente = Cliente.NombreCompleto;
            string ultimoCambioEstado = CambioEstado.EsEstadoActual(CambiosEstado);

            if (ultimoCambioEstado != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Cliente:").Append(nombreCliente);
                sb.AppendLine("Estado:").Append(ultimoCambioEstado);
                return sb.ToString();
            }
            return "";
        }
    }
}
