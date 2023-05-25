using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Pregunta
    {
        private string pregunta;
        private RespuestaPosible respuesta;

        public Pregunta(string pregunta, RespuestaPosible respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }
    }
}
