using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaDeCliente
    {
        private DateTime fechaDeEncuesta;
        private RespuestaPosible respuestaSeleccionada;

        public RespuestaDeCliente(DateTime fechaDeEncuesta, RespuestaPosible respuestaSeleccionada)
        {
            this.fechaDeEncuesta = fechaDeEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;
        }
        
        //public RespuestaPosible GetDescripcionRta()
        public RespuestaPosible GetRespuestaSeleccionada() 
        {
            return respuestaSeleccionada;
        }      
    }
}
