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
        public string Nombre { get; set; }

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
            return nombre.Equals("finalizada", StringComparison.OrdinalIgnoreCase);
        }

        public bool EsIniciada()
        {
            return nombre.Equals("iniciada", StringComparison.OrdinalIgnoreCase);
        }
    }
}
