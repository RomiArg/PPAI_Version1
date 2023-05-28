using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaDeCliente
    {
        /* Atributos de la clase RespuestaDeCliente */
        private DateTime fechaDeEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        /* Métodos constructores de la clase */
        public RespuestaDeCliente() { }

        public RespuestaDeCliente(DateTime fechaDeEncuesta, RespuestaPosible respuestaSeleccionada)
        {
            this.fechaDeEncuesta = fechaDeEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;
        }

        /* Métodos de seteo de las propiedades */
        public DateTime FechaDeEncuesta { get { return fechaDeEncuesta; } set { fechaDeEncuesta = value; } } 
        public RespuestaPosible RespuestaSeleccionada { get { return respuestaSeleccionada; } set { respuestaSeleccionada = value; } }    

        /* Este método convierte a los atributos en string para mostrarlos */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fecha De Encuesta: ").Append(fechaDeEncuesta.ToString());
            sb.AppendLine("Respuesta Seleccionada: ").Append(respuestaSeleccionada.MostrarDatos());

            return sb.ToString();
        }

        /* Método que se utiliza en la implementación del CU */
        public string GetDescripcionRta()
        {
            return respuestaSeleccionada.GetDescripcionRta();
        }
    }
}
