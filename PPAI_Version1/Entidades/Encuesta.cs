using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Encuesta
    {
        private string descripcion;
        private DateTime fechaFinVigencia;
        private Pregunta[] pregunta;

        public Encuesta() { }
        public Encuesta(string descripcion, DateTime fechaFinVigencia, Pregunta[] pregunta)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.pregunta = pregunta;
        }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime FechaFinVigencia { get { return fechaFinVigencia; } set {  fechaFinVigencia = value; } }
        public Pregunta[] Pregunta { get { return pregunta; } set { pregunta = value; } }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Descripcion: ").Append(descripcion);
            sb.AppendLine("Fecha Fin Vigencia: ").Append(fechaFinVigencia.ToString());
            foreach(Pregunta pta in pregunta)
            {
                sb.AppendLine(pta.MostrarDatos());
            }

            return sb.ToString();
        }

        public bool EsEncuestaDeCliente()
        {

        }
    }
}
