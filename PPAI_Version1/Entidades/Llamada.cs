using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private float duracion;
        private Array encuestaEnviada;
        private string observacionAuditor;
        private RespuestaDeCliente respuestasDeEncuesta;
        private Cliente cliente;
        private CambioEstado cambioEstado;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, float duracion, Array encuestaEnviada, string observacionAuditor, RespuestaDeCliente respuestasDeEncuesta, Cliente cliente, CambioEstado cambioEstado)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.respuestasDeEncuesta = respuestasDeEncuesta;
            this.cliente = cliente;
            this.cambioEstado = cambioEstado;
        }
    }
}
