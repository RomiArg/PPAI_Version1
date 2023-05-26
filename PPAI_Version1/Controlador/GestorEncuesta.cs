using PPAI_Version1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Analisis
{
    public class GestorEncuesta
    {
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private string nombreCliente;
        private int duracionLlamada;
        private RespuestaDeCliente[] rtasCliente;
        private RespuestaPosible[] rtasSeleccionadas;
        private Pregunta[] descripcionPreguntas;

        public GestorEncuesta() { }
        public GestorEncuesta(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo, string nombreCliente, int duracionLlamada, RespuestaDeCliente[] rtasCliente, RespuestaPosible[] rtasSeleccionadas, Pregunta[] descripcionPreguntas)
        {
            this.fechaFinPeriodo = fechaFinPeriodo;
            this.fechaFinPeriodo = fechaFinPeriodo;
            this.nombreCliente = nombreCliente;
            this.duracionLlamada = duracionLlamada;
            this.rtasCliente = rtasCliente;
            this.rtasSeleccionadas = rtasSeleccionadas;
            this.descripcionPreguntas = descripcionPreguntas;
        }

        public DateTime FechaInicioPeriodo { get { return fechaInicioPeriodo; } set { fechaInicioPeriodo = value; } }
        public DateTime FechaFinPeriodo { get { return fechaFinPeriodo; } set { fechaFinPeriodo = value; } }
        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }
        public RespuestaDeCliente[] RtasCliente { get { return rtasCliente; } set rtasCliente = Value; }
        public RespuestaPosible[] RtasSeleccionadas { get { return rtasSeleccionadas; } set rtasSeleccionadas = value; }
        public Pregunta[] DescripcionPreguntas { get { return descripcionPreguntas.ToArray(); } set { descripcionPreguntas = value; } }


        public void ConsultarEncuesta()
        {

        }

        public void TomarSeleccionFechasFiltros()
        {

        }

        public void BuscarLlamadasConEncuestasRespondidas()
        {

        }

        public void TomarSeleccionLlamada()
        {

        }

        public void BuscarDatosLlamada()
        {

        }
    }
}
