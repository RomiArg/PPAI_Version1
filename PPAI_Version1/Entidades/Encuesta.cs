using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Encuesta
    {
        public string descripcion{ get; set; }
        public DateTime fechaFinVigencia { get; set; }
        public Pregunta pregunta = new Pregunta();
        public Encuesta () { }
    }
}
