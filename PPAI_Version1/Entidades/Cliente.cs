using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Cliente
    {
        /* Atributos de la clase Cliente */
        private string nombreCompleto;
        private int dni;
        private int nroCelular;

        /* Métodos constructores de la clase */
        public Cliente() { }
        public Cliente(string nombreCompleto, int dni, int nroCelular)
        {
            this.nombreCompleto = nombreCompleto;
            this.dni = dni;
            this.nroCelular = nroCelular;
        }

        /* Métodos de seteo de las propiedades */
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public int  DNI { get { return dni; } set { dni = value; } }
        public int NumeroCelular { get { return nroCelular; } set { nroCelular = value; } }

        /* Este método convierte a los atributos en string para mostrarlos */
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
