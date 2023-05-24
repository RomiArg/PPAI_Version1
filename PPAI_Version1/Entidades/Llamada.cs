using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Version1.Entidades
{
    public class Llamada
    {
        public string descripcionOperador { get; set; }
        public string detalleAccionRequerida { get; set; }
        public float duracion { get; set; }
        public Array encuestaEnviada { get; set; }
        public string observacionAuditor { get; set; }
        public RespuestaDeCliente respuestasDeEncuesta = new RespuestaDeCliente();
        public Cliente cliente = new Cliente();
        public CambioEstado cambioEstado = new CambioEstado();
        public Llamada() { }
    }
}
