using PPAI_Version1.Analisis;
using System;
using System.Collections;
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
            RespuestasDeEncuesta = new List<RespuestaDeCliente>();
        }
        public Llamada( float duracion, bool encuestaEnviada, Cliente cliente)
        {
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.cliente = cliente;
            this.cambiosEstado = new List<CambioEstado>();
            this.respuestasDeEncuesta = new List<RespuestaDeCliente>();
        }

        /* Métodos de seteo de las propiedades */
        public string DescripcionOperador { get { return descripcionOperador; } set { descripcionOperador = value; } }
        public string DetalleAccionRequerida { get { return detalleAccionRequerida; } set { detalleAccionRequerida = value; } }
        public float Duracion { get { return duracion; } set {  duracion = value; } }
        public bool EncuestaEnviada { get { return encuestaEnviada; } set { encuestaEnviada = value; } }
        public string ObservacionAuditor { get { return observacionAuditor; } set {  observacionAuditor = value; } }
        public Cliente Cliente { get { return cliente; } set {  cliente = value; } }
        public List<RespuestaDeCliente> RespuestasDeEncuesta { get { return respuestasDeEncuesta; } set {  respuestasDeEncuesta = value; } }
        public List<CambioEstado> CambiosEstado { get { return cambiosEstado; } set { cambiosEstado = value; } }

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

        public float GetDuracion()
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
            return diferencia.Minutes;
        }

        public bool EsDePeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            foreach(CambioEstado cambio in CambiosEstado)
            {
                if ((cambio.EsEstadoInicial()) && (cambio.FechaHoraInicio >= fechaInicio && cambio.FechaHoraInicio <= fechaFin))
                {
                    return true;
                }
            }
            return false;
        }

        public bool TieneEncuestaRespondida()
        {
            if (RespuestasDeEncuesta != null)
            {
                return true;
            }

            return false;
        }

        
        public List<string> GetNombreClienteYEstado()
        {
            string cliente = Cliente.NombreCompleto;
            string estado = CambioEstado.EsEstadoActual(CambiosEstado);
            List<string> lista = new List<string>();

            if (estado != null)
            {  
                lista.Add(cliente);
                lista.Add (estado);
                return lista;
            }
            lista.Add(cliente);
            lista.Add("No se encontro estado actual");
            return lista;
        }
    }  
}
