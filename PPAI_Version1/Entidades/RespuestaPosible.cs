using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaPosible
    {
        public string descripcion { get; set; }
        public string valor { get; set; }

        public RespuestaPosible(string descripcion, string valor)
            { 
                this.descripcion = descripcion;
                this.valor = valor;
            }
        public RespuestaPosible() { }
        public void getDescripcionRta(string desc) { this.descripcion = desc; }
        
    }
}