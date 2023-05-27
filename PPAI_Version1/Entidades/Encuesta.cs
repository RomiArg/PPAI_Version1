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
        public Encuesta() { }
        public Encuesta(string descripcion, DateTime fechaFinVigencia, List<Pregunta> pregunta)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.pregunta = pregunta;
        }

        /* Métodos de seteo de las propiedades */
        public string Descripcion { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public List<Pregunta> Pregunta { get; set; }

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
        public bool EsEncuestaDeCliente(List<RespuestaDeCliente> respuestas)
        {
            for (int i = 0; i < pregunta.Count - 1; i++)
            {
                if (!pregunta[i].EsEncuestaDeCliente(respuestas))
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
