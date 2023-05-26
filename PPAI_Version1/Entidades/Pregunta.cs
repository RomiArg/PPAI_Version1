using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PPAI_Version1.Entidades
{
    public class Pregunta
    {
        private string pregunta;
        private RespuestaPosible[] respuesta;

        public Pregunta(string pregunta, RespuestaPosible[] respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }

        public Pregunta() { }
        public string DescripcionPregunta { get { return pregunta; } set { pregunta = value; } }
        public RespuestaPosible[] Respuesta { get { return respuesta; } set {  respuesta = value; } }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(pregunta);
            foreach (RespuestaPosible rta in respuesta)
            {
                sb.AppendLine(rta.MostrarDatos());
            }
            return sb.ToString();
        }

        public void ListarRespuestasPosibles()
        {
            Console.WriteLine("Respuestas Posibles: ");
            foreach (RespuestaPosible respuestaPosible in respuesta)
            {
                Console.WriteLine(respuestaPosible.MostrarDatos());
            }
        }
    }
}
