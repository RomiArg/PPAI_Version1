using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Pregunta
    {
        public string pregunta { get; set; }
        public RespuestaPosible rtaPosible { get; set; }
        public Pregunta() { }
    }
}
