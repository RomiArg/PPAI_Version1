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
        private Pregunta pregunta;

        public Encuesta(string descripcion, DateTime fechaFinVigencia, Pregunta pregunta)
        {
            this.descripcion = descripcion;
            this.fechaFinVigencia = fechaFinVigencia;
            this.pregunta = pregunta;
        }
    }
}
