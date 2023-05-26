using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaDeCliente
    {
        private DateTime fechaDeEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        public RespuestaDeCliente(DateTime fechaDeEncuesta, RespuestaPosible respuestaSeleccionada)
        {
            this.fechaDeEncuesta = fechaDeEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;
        }
        
        public RespuestaDeCliente() { }
       
        public RespuestaPosible GetDescripcionRta()
        {
            return respuestaSeleccionada;
        }
        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fecha De Encuesta: ").Append(fechaDeEncuesta.ToString());
            sb.AppendLine("Respuesta Seleccionada: ").Append(respuestaSeleccionada.MostrarDatos());

            return sb.ToString();
        }
    }
}
