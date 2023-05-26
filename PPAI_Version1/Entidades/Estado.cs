using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Estado
    {
        private string nombre;

        public Estado(string nombre)
        {
            this.nombre = nombre;
        }
        public Estado() { }
        public string Nombre { get { return nombre; } set { nombre = value; } }

        
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre:").Append(nombre);
            
            return sb.ToString();
        }

        public bool EsFinalizada()
        {
            return nombre.Equals("finalizada", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsIniciada()
        {
            return nombre.Equals("iniciada", StringComparison.OrdinalIgnoreCase);
        }
    }
}
