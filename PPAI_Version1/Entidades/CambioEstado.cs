using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estado;

        public CambioEstado() { }
        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
        public Estado Estado { get { return estado; } set { estado = value; } }
        public DateTime FechaHoraInicio { get {  return fechaHoraInicio; } set {  fechaHoraInicio = value; } }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Estado: ").Append(estado.MostrarDatos());
            sb.AppendLine("Fecha Hora Inicio: ").Append(fechaHoraInicio).ToString();

            return sb.ToString(); 
        }

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
            return estado.Nombre; //metodo getNombre
        }

        public DateTime GetFechaHoraInicio()
        {
            return fechaHoraInicio;
        }

    }
}
