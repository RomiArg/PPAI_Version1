using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class CambioEstado
    {
        public DateTime fechaHoraInicio {get; set;}
        public Estado estado = new Estado();
       public CambioEstado() { }  
    }
}
