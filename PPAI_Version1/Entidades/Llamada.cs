using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private float duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private RespuestaDeCliente[] respuestasDeEncuesta;
        private Cliente cliente;
        private CambioEstado[] cambiosEstado;

        public Llamada() { }
        public Llamada(string descripcionOperador, string detalleAccionRequerida, float duracion, bool encuestaEnviada, string observacionAuditor, RespuestaDeCliente[] respuestasDeEncuesta, Cliente cliente, CambioEstado[] cambiosEstado)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestasDeEncuesta = respuestasDeEncuesta;
            this.cliente = cliente;
            this.cambiosEstado = cambiosEstado;
        }

        public string DescripcionOperador { get { return descripcionOperador; } set { descripcionOperador = value; } }
        public string DetalleAccionRequerida { get { return detalleAccionRequerida; } set { detalleAccionRequerida = value; } }
        public float Duracion { get { return duracion; } set { duracion = value; } }
        public bool EncuestaEnviada { get { return encuestaEnviada; } set { encuestaEnviada = value; } }
        public string ObservacionAuditor { get { return observacionAuditor; } set { observacionAuditor = value; } }
        public Cliente AsignarCliente { get { return cliente; } set { cliente = value; } }
        public RespuestaDeCliente[] RespuestasDeEncuesta { get { return respuestasDeEncuesta; } set { respuestasDeEncuesta = value; } }
        public CambioEstado[] CambioEstado { get { return cambiosEstado; } set { cambiosEstado = value; } }
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Descripcion del operador:").Append(DescripcionOperador);
            sb.AppendLine("Detalle de Acción Requerida:").Append(detalleAccionRequerida);
            sb.AppendLine("Datos del cliente:").AppendLine(cliente.MostrarDatos());
            sb.AppendLine("Encuesta:"); 
            sb.AppendLine("Observación del auditor:").Append(observacionAuditor);
            sb.AppendLine("Estado:").Append(GetEstadoActual().GetNombreEstado());

            return sb.ToString();
        }

        public string GetNombreCliente()
        {
            return cliente.NombreCompleto;
        }

        public CambioEstado GetEstadoActual()
        {
            CambioEstado ultimo = null;
            for (int i = 0; i < cambiosEstado.Length; i++)
            {
                if(i == 0)
                {
                    ultimo = cambiosEstado[i];
                }
                if (cambiosEstado[i].FechaHoraInicio > ultimo.FechaHoraInicio)
                {
                    ultimo = cambiosEstado[i];
                }
            }
            return ultimo;
        }

        public void CalcularDuracion()
        {
            CambioEstado inicial = null;
            CambioEstado final = null;
            for (int i = 0; i < cambiosEstado.Length; i++)
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
            for (int i = 0; i < cambiosEstado.Length; i++)
            {
                if (cambiosEstado[i].EsEstadoInicial())
                {
                    inicial = cambiosEstado[i];
                }
            }

            if (inicial != null)
            {
                if (inicial.FechaHoraInicio >= fechaInicio & inicial.FechaHoraInicio <= fechaFin)
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
    }
}
