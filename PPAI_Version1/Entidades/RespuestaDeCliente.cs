using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaDeCliente
    {
        public DateTime fechaDeEncuesta { get; set; }
        public RespuestaPosible respuestaSeleccionada = new RespuestaPosible();
        public RespuestaDeCliente() { }
    }
}
