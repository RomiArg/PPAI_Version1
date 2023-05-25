using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaPosible
    {
        private string descripcion;
        private string valor;

        public RespuestaPosible(string descripcion, string valor)
            { 
                this.descripcion = descripcion;
                this.valor = valor;
            }
        public RespuestaPosible() { }
        public string getDescripcionRta() => descripcion;

    }
}