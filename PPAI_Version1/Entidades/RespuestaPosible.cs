using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class RespuestaPosible
    {
        /* Atributos de la clase RespuestaPosible */
        private string descripcion;
        private string valor;

        /* Métodos constructores de la clase */
        public RespuestaPosible(string descripcion, string valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;
        }
        public RespuestaPosible() { }

        /* Métodos de seteo de las propiedades */
        public string Descripcion { get { return descripcion; } set {  descripcion = value; } }
        public string Valor { get { return valor; } set {  valor = value; } }

        /* Este método convierte a los atributos en string para mostrarlos */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Descripcion: ").Append(descripcion);
            sb.AppendLine("valor").Append(valor);

            return sb.ToString();
        }

        /* Método que se utiliza en la implementación del CU */
        public string GetDescripcionRta()
        {
            return descripcion;
        }

    }
}