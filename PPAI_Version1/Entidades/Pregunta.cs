using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PPAI_Version1.Entidades
{
    public class Pregunta
    {
        /* Atributos de la clase Pregunta */
        private string pregunta;
        private List<RespuestaPosible> respuestaPosibles;

        /* Métodos constructores de la clase */
        public Pregunta() { respuestaPosibles = new List<RespuestaPosible>(); }
        public Pregunta(string pregunta)
        {
            this.pregunta = pregunta;
            this.respuestaPosibles = new List<RespuestaPosible>();
        }

        /* Métodos de seteo de las propiedades */
        public string DescripcionPregunta { get { return pregunta; } set { pregunta = value; } }
        public List<RespuestaPosible> RespuestaPosibles { get { return respuestaPosibles; } set { respuestaPosibles = value; } }

        /* Este método convierte a los atributos en string para mostrarlos */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(pregunta);
            foreach (RespuestaPosible rta in respuestaPosibles)
            {
                sb.AppendLine(rta.MostrarDatos());
            }
            return sb.ToString();
        }

        /* Métodos que son utilizados en la implementación del CU */
        public string ListarRespuestasPosibles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Respuestas Posibles: ");
            foreach (RespuestaPosible respuestaPosible in respuestaPosibles)
            {
                sb.AppendLine(respuestaPosible.MostrarDatos());
                sb.AppendLine("");
            }
            return sb.ToString();
        }

        public bool EsEncuestaDeCliente(List<RespuestaPosible> respuestas)
        {
            foreach (RespuestaPosible respuesta in respuestas)
            {
                if (TieneRtaPosible(respuesta))
                {
                    return true;
                }
            }
            return false;
        }

        public bool TieneRtaPosible(RespuestaPosible respuesta)
        {
            foreach (RespuestaPosible respuestaPosible in respuestaPosibles)
            {
                if (respuesta.Descripcion == respuestaPosible.Descripcion)
                {
                    return true;
                }
            }
            return false;
        }
    }
}