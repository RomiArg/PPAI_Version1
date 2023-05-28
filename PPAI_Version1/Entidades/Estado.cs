using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Estado
    {
        /* Atributos de la clase Estado */
        private string nombre;

        /* Método constructor de la clase */
        public Estado(string nombre)
        {
            this.nombre = nombre;
        }
        public Estado() { }
        
        /* Método de seteo de la propiedad */
        public string Nombre { get { return nombre; } set { nombre = value; } }

        /* Este método convierte al atributo en string para mostrarlo */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre:").Append(nombre);
            
            return sb.ToString();
        }
         
        /* Métodos que son utilizados en la implementación del CU */
        public bool EsFinalizada()
        {
            return nombre.Equals("Finalizada", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsIniciada()
        {
            if (nombre.Equals("Iniciada", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
