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
        public Pregunta() { respuesta = new List<RespuestaPosible>(); }
        public Pregunta(string pregunta)
        {
            this.pregunta = pregunta;
            this.respuesta = new List<RespuestaPosible>();
        }

        /* Métodos de seteo de las propiedades */
        public string DescripcionPregunta { get { return pregunta; } set { pregunta = value; } }
        public List<RespuestaPosible> Respuesta { get { return respuesta; } set {  respuesta = value; } }

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

        public bool EsEncuestaDeCliente(List<RespuestaPosible> rtas)
        {
            foreach (RespuestaPosible rta in rtas)
            {
                if (!TieneRtaPosible(rta))
                {
                    return false; 
                }
            }
            return true; 
        }

        public bool TieneRtaPosible(RespuestaPosible rta)
        {
            foreach (RespuestaPosible Resp in this.respuesta)
            {
                if (rta == Resp)
                { 
                    return true;
                }
            }
            return false;
        }
    }
}
