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
        private int dni;
        private int nroCelular;

        public Cliente() { }
        public Cliente(string nombreCompleto, int dNI, int nroCelular)
        {
            this.nombreCompleto = nombreCompleto;
            dni = dNI;
            this.nroCelular = nroCelular;
        }

        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public int NumeroCelular { get { return nroCelular; } set { nroCelular = value; } }
        public int DNI { get { return dni; } set { dni = value; } }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre y Apellido:").Append(nombreCompleto);
            sb.AppendLine("DNI:").Append(dni);
            sb.AppendLine("Teléfono:").Append(nroCelular);

            return sb.ToString();

        }


    }
}
