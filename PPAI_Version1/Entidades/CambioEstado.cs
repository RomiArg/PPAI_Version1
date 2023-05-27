using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class CambioEstado
    {
        /* Atributos de la clase CambioEstado */
        private DateTime fechaHoraInicio;
        private Estado estado;

        /* Métodos constructores de la clase */
        public CambioEstado() { }
        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }

        /* Métodos de seteo de las propiedades */
        public Estado Estado { get; set; }
        public DateTime FechaHoraInicio { get; set; }

        /* Este método convierte a los atributos en string para mostrarlos */
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Estado: ").Append(estado.MostrarDatos());
            sb.AppendLine("Fecha Hora Inicio: ").Append(fechaHoraInicio).ToString();

            return sb.ToString(); 
        }

        /* Métodos que son utilizados en la implementación del CU */
        public bool EsEstadoInicial()
        {
            return estado.EsIniciada();
        }

        public bool EsEstadoFinal()
        {
            if (estado.Nombre == "Finalizada")
            {
                return true;
            }
            return false;
        }

        public string GetNombreEstado()
        {
            return Estado.Nombre; 
        }

        public DateTime GetFechaHoraInicio()
        {
            return fechaHoraInicio;
        }
        
        //Este método buscar entre una lista de cambios de estado el estado con el atributo fechaHoraInicio mas grande,
        //primero ordenando la lista de mayor a menor y tomando el primer resultado
        public static string EsEstadoActual(List<CambioEstado> cambiosEstado)
        {
            CambioEstado cambioActual = cambiosEstado.OrderByDescending(c => c.FechaHoraInicio).FirstOrDefault();
            
            return cambioActual.GetNombreEstado();
        }
    }
}
