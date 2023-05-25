using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Cliente
    {
        private string nombreCompleto;
        private int DNI;
        private int nroCelular;

        public Cliente(string nombreCompleto, int dNI, int nroCelular)
        {
            this.nombreCompleto = nombreCompleto;
            DNI = dNI;
            this.nroCelular = nroCelular;
        }
    }
}
