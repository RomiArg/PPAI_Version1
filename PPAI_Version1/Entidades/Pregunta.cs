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
        /* Atributos de la clase Pregunta */
        private string pregunta;
        private List<RespuestaPosible> respuesta;

        /* Métodos constructores de la clase */
        public Pregunta() { }
        public Pregunta(string pregunta, List<RespuestaPosible> respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }

        /* Métodos de seteo de las propiedades */
        public string DescripcionPregunta { get; set; }
        public List<RespuestaPosible> Respuesta { get; set; }

        /* Este método convierte a los atributos en string para mostrarlos */
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

        /* Métodos que son utilizados en la implementación del CU */
        public string ListarRespuestasPosibles()
        {   
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Respuestas Posibles: ");
            foreach (RespuestaPosible respuestaPosible in respuesta)
            {
                sb.AppendLine(respuestaPosible.MostrarDatos());
                sb.AppendLine("");
            }
            return sb.ToString();
        }

        public bool EsEncuestaDeCliente(List<RespuestaDeCliente> rtas)
        {
            foreach (RespuestaDeCliente rta in rtas)
            {
                if (!TieneRtaPosible(rta))
                {
                    return false; 
                }
            }
            return true; 
        }

        public bool TieneRtaPosible(RespuestaDeCliente rta)
        {
            foreach (RespuestaPosible Resp in this.respuesta)
            {
                if (rta.RespuestaSeleccionada == Resp)
                { 
                    return true;
                }
            }
            return false;
        }
    }
}
