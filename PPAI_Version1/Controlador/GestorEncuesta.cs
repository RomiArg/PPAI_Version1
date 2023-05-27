using PPAI_Version1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_Version1.Analisis
{
    public class GestorEncuesta
    {
        /* Atributos de la clase GestorEncuesta*/
        private DateTime fechaInicioPeriodo;
        private DateTime fechaFinPeriodo;
        private string nombreCliente;
        private int duracionLlamada;
        private List<RespuestaDeCliente> rtasCliente;
        private List<RespuestaPosible> rtasSeleccionadas;
        private List<Pregunta> descripcionPreguntas;
        private Llamada llamadaSeleccionada;
        private List<Encuesta> encuesta;
        private List<Llamada> llamadas;

        /* Métodos constructores de la clase */
        public GestorEncuesta() 
        {
       
            
        }
        public GestorEncuesta(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo, string nombreCliente, int duracionLlamada, List<RespuestaDeCliente> rtasCliente, List<RespuestaPosible> rtasSeleccionadas, List<Pregunta> descripcionPreguntas, Llamada llamadaSeleccionada, List<Encuesta> encuesta)
        {
            this.fechaInicioPeriodo = fechaInicioPeriodo;
            this.fechaFinPeriodo = fechaFinPeriodo;
            this.nombreCliente = nombreCliente;
            this.duracionLlamada = duracionLlamada;
            this.rtasCliente = rtasCliente;
            this.rtasSeleccionadas = rtasSeleccionadas;
            this.descripcionPreguntas = descripcionPreguntas;
            this.llamadaSeleccionada = llamadaSeleccionada;
            this.encuesta = encuesta;   
        }

        /* Métodos de seteo de las propiedades */
        public DateTime FechaInicioPeriodo { get; set; }
        public DateTime FechaFinPeriodo { get; set; }
        public string NombreCliente { get; set; }
        public List<RespuestaDeCliente> RtasCliente { get; set; }
        public List<RespuestaPosible> RtasSeleccionadas { get; set; }
        public List<Pregunta> DescripcionPreguntas { get; set; }
        public Llamada LlamadaSeleccionada { get; set; }
        public List<Encuesta> Encuesta { get; set; }
        public int DuracionLlamada { get; set; }
        public List<Llamada> Llamadas { get; set; }

        /* Métodos que son utilizados en la implementación del CU */

        public void CargarEntidades()
        {
            Estado e0 = new Estado("Iniciada");
            Estado e1 = new Estado("Finalizada");
            Estado e2 = new Estado("Cancelada");
            Estado e3 = new Estado("En Curso");

            CambioEstado ce0 = new CambioEstado(DateTime.Parse("2023-02-02 05:00:00"), e0);
            CambioEstado ce1 = new CambioEstado(DateTime.Parse("2023-01-17 12:45:00"), e0);
            CambioEstado ce2 = new CambioEstado(DateTime.Parse("2023-06-30 18:30:00"), e0);
            CambioEstado ce3 = new CambioEstado(DateTime.Parse("2023-05-25 10:15:00"), e1);
            CambioEstado ce4 = new CambioEstado(DateTime.Parse("2023-04-03 11:00:00"), e1);
            CambioEstado ce5 = new CambioEstado(DateTime.Parse("2023-04-26 11:30:00"), e1);
            CambioEstado ce6 = new CambioEstado(DateTime.Parse("2023-03-22 09:45:00"), e2);
            CambioEstado ce7 = new CambioEstado(DateTime.Parse("2023-01-25 09:00:00"), e2);
            CambioEstado ce8 = new CambioEstado(DateTime.Parse("2023-06-04 11:35:00"), e2);
            CambioEstado ce9 = new CambioEstado(DateTime.Parse("2023-05-19 13:55:00"), e3);
            CambioEstado ce10 = new CambioEstado(DateTime.Parse("2023-05-20 12:20:00"), e3);
            CambioEstado ce11 = new CambioEstado(DateTime.Parse("2023-03-25 15:15:00"), e3);

            Cliente cl0 = new Cliente("José Perez", 459267987, 1585642548);
            Cliente cl1 = new Cliente("Micalea Gonzalez", 459267987, 1514187694);
            Cliente cl2 = new Cliente("Sofia Vergara", 459267987, 1597541629);
            Cliente cl3 = new Cliente("Celeste Rojas", 459267987, 1649718234);
            Cliente cl4 = new Cliente("Diego Martinez", 459267987, 1952118874);
            Cliente cl5 = new Cliente("Ana Maria Villeegas", 459267987, 1649718246);


            Llamada llamada0 = new Llamada {Cliente = cl0};
            Llamada llamada1 = new Llamada {Cliente = cl1};
            Llamada llamada2 = new Llamada {Cliente = cl2};
            Llamada llamada3 = new Llamada {Cliente = cl3};
            Llamada llamada4 = new Llamada {Cliente = cl4};
            Llamada llamada5 = new Llamada {Cliente = cl5};

            llamada0.CambiosEstado.Add(ce0);
            llamada0.CambiosEstado.Add(ce3);
            llamada0.CambiosEstado.Add(ce7);
            llamada0.CambiosEstado.Add(ce11);

            llamada1.CambiosEstado.Add(ce1);
            llamada1.CambiosEstado.Add(ce4);
            llamada1.CambiosEstado.Add(ce6);
            llamada1.CambiosEstado.Add(ce10);

            GestorEncuesta gestor = new GestorEncuesta();
            gestor.Llamadas.Add(llamada0);
            gestor.Llamadas.Add(llamada1);
            gestor.Llamadas.Add(llamada2);
            gestor.Llamadas.Add(llamada3);
            gestor.Llamadas.Add(llamada4);
            gestor.Llamadas.Add(llamada5);

        }
        public void ConsultarEncuesta()
        {
            
        }

        public void TomarSeleccionFechasFiltros(DateTime fechaIniP, DateTime fechaFinP) 
        {
            FechaInicioPeriodo = fechaIniP;
            FechaFinPeriodo = fechaFinP;
        }

        public List<Llamada> BuscarLlamadasConEncuestaRespondida()
        {
            List<Llamada> llamadasFiltradas = null;
            foreach (Llamada llamada in llamadas)
            {
                if (llamada.EsDePeriodo(FechaInicioPeriodo, FechaFinPeriodo) & llamada.TieneEncuestaRespondida())
                {
                    llamadasFiltradas.Add(llamada);
                }
            }
            return llamadasFiltradas;
        }

        public void TomarSeleccionLlamada(Llamada llamadaElegida)
        {
            LlamadaSeleccionada = llamadaElegida;
        }

        public string BuscarDatosLlamada()
        {
            return llamadaSeleccionada.GetNombreClienteYEstado();
        }

        public string BuscarRespuestas()
        {
            foreach(RespuestaDeCliente res in rtasCliente)
            {
                return res.GetDescripcionRta();
            }
            return null;
        }

        public Encuesta BuscarPreguntasDeEncuesta(List<RespuestaDeCliente> respuestas)
        {
            foreach(Encuesta encu in this.encuesta)
            {
                if (encu.EsEncuestaDeCliente(respuestas))
                {
                    return encu;
                }
            }
            return null;
        }

        public string BuscarDescripcionEncuestaYPregunta(Encuesta encuesta)
        {
            return encuesta.Descripcion;
        }
    }
}
