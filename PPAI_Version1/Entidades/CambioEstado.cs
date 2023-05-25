using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado[] estado;
      
        public CambioEstado(DateTime fechaHoraInicio, Estado[] estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
    }
}
