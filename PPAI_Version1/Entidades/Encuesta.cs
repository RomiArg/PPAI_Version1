using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Encuesta
    {
        /* Atributos de la clase Encuesta */
        private string descripcion;
        private DateTime fechaFinVigencia;
        private List<Pregunta> pregunta;

        /* Métodos constructores de la clase */
        public Encuesta() { Pregunta = new List<Pregunta>(); }
        public Encuesta(string descripcion, DateTime fechaFinVigencia, List<Pregunta> pregunta1)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.pregunta = pregunta1;
        }

        /* Métodos de seteo de las propiedades */
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime FechaFinVigencia { get { return fechaFinVigencia; } set { fechaFinVigencia = value; } }
        public List<Pregunta> Pregunta { get { return pregunta; } set { pregunta = value; } }

        /* Este método convierte a los atributos en string para mostrarlos */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Descripcion: ").Append(descripcion);
            sb.AppendLine("Fecha Fin Vigencia: ").Append(fechaFinVigencia.ToString());
            foreach (Pregunta pta in pregunta)
            {
                sb.AppendLine(pta.MostrarDatos());
            }
            return sb.ToString();
        }

        /* Métodos que son utilizados en la implementación del CU */

        public bool EsEncuestaDeCliente(List<RespuestaPosible> respuestas)
        {
            foreach (Pregunta pregunta in pregunta)
            {
                if (!pregunta.EsEncuestaDeCliente(respuestas))
                {
                    return false;
                }
            }
            return true;
        }


        public bool EsVigente(DateTime fechaVig)
        {
            if(fechaFinVigencia.Date <= fechaVig.Date)
            {
                return true;
            }
            return false;
        }
    }
}
