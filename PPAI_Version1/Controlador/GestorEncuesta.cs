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
        private float duracionLlamada;
        private List<RespuestaDeCliente> rtasCliente;
        private List<RespuestaPosible> rtasSeleccionadas;
        private List<Pregunta> descripcionPreguntas;
        private Llamada llamadaSeleccionada;
        private List<Encuesta> encuesta;
        private List<Llamada> llamadas;
        private PantallaEncuesta pantallaEncuesta;



        /* Métodos constructores de la clase */
        public GestorEncuesta(PantallaEncuesta pantallaEncuesta)
        {
            this.PantallaEncuesta = pantallaEncuesta;
            Llamadas = new List<Llamada>();
            Encuesta = new List<Encuesta>();
            RtasCliente = new List<RespuestaDeCliente>();
            RtasSeleccionadas = new List<RespuestaPosible>();
            DescripcionPreguntas = new List<Pregunta>();
        }

        public GestorEncuesta(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo, string nombreCliente, int duracionLlamada, List<RespuestaDeCliente> rtasCliente, List<RespuestaPosible> rtasSeleccionadas, List<Pregunta> descripcionPreguntas, Llamada llamadaSeleccionada, PantallaEncuesta pantallaEncuesta)
        {
            this.fechaInicioPeriodo = fechaInicioPeriodo;
            this.fechaFinPeriodo = fechaFinPeriodo;
            this.nombreCliente = nombreCliente;
            this.duracionLlamada = duracionLlamada;
            this.rtasCliente = rtasCliente;
            this.rtasSeleccionadas = rtasSeleccionadas;
            this.descripcionPreguntas = descripcionPreguntas;
            this.llamadaSeleccionada = llamadaSeleccionada;
            this.encuesta = new List<Encuesta>();
            this.pantallaEncuesta = new PantallaEncuesta(this);
            this.llamadas = new List<Llamada>();
        }

        /* Métodos de seteo de las propiedades */
        public DateTime FechaInicioPeriodo { get { return fechaInicioPeriodo; } set { fechaInicioPeriodo = value; } }
        public DateTime FechaFinPeriodo { get { return fechaFinPeriodo; } set{ fechaFinPeriodo = value; } }
        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }
        public List<RespuestaDeCliente> RtasCliente { get { return rtasCliente; } set { rtasCliente = value; } }
        public List<RespuestaPosible> RtasSeleccionadas { get { return rtasSeleccionadas; } set { rtasSeleccionadas = value; } }
        public List<Pregunta> DescripcionPreguntas { get { return descripcionPreguntas; } set { descripcionPreguntas = value; } }
        public Llamada LlamadaSeleccionada { get { return llamadaSeleccionada; } set { llamadaSeleccionada = value; } }
        public List<Encuesta> Encuesta { get { return encuesta; } set { encuesta = value; } }
        public float DuracionLlamada { get { return duracionLlamada; } set  { duracionLlamada = value ; } }
        public List<Llamada> Llamadas { get { return llamadas; } set { llamadas = value; } }
        public PantallaEncuesta PantallaEncuesta { get; set; }

        /* Métodos que son utilizados en la implementación del CU */

        public void ConsultarEncuesta()
        {
            // pedirFechasFiltroPeriodo();


            /* Creacion de los objetos Estado */
            Estado e0 = new Estado("Iniciada");
            Estado e1 = new Estado("Finalizada");
            Estado e2 = new Estado("Cancelada");
            Estado e3 = new Estado("En Curso");

            /* Creación de los objetos CambioEstado */
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

            /* Creación de los objetos Cliente */
            Cliente cl0 = new Cliente("José Perez", 459267987, 1585642548);
            Cliente cl1 = new Cliente("Micalea Gonzalez", 459267987, 1514187694);
            Cliente cl2 = new Cliente("Sofia Vergara", 459267987, 1597541629);
            Cliente cl3 = new Cliente("Celeste Rojas", 459267987, 1649718234);
            Cliente cl4 = new Cliente("Diego Martinez", 459267987, 1952118874);
            Cliente cl5 = new Cliente("Ana Maria Villegas", 459267987, 1649718246);

            /* Creación de los objetos RespuestaPosible */

            RespuestaPosible respuestaPosible1 = new RespuestaPosible { Valor = "1", Descripcion = "Teléfono" };
            RespuestaPosible respuestaPosible2 = new RespuestaPosible { Valor = "2", Descripcion = "Correo electrónico" };
            RespuestaPosible respuestaPosible3 = new RespuestaPosible { Valor = "3", Descripcion = "Chat en vivo" };
            RespuestaPosible respuestaPosible4 = new RespuestaPosible { Valor = "4", Descripcion = "Rapidez en las respuestas" };
            RespuestaPosible respuestaPosible5 = new RespuestaPosible { Valor = "5", Descripcion = "Amabilidad y trato personalizado" };
            RespuestaPosible respuestaPosible6 = new RespuestaPosible { Valor = "6", Descripcion = "Soluciones efectivas a los problemas" };
            RespuestaPosible respuestaPosible7 = new RespuestaPosible { Valor = "7", Descripcion = "Muy satisfecho(a)" };
            RespuestaPosible respuestaPosible8 = new RespuestaPosible { Valor = "8", Descripcion = "Satisfecho(a)" };
            RespuestaPosible respuestaPosible9 = new RespuestaPosible { Valor = "9", Descripcion = "Insatisfecho(a)" };
            RespuestaPosible respuestaPosible10 = new RespuestaPosible { Valor = "10", Descripcion = "Muy claro(a)" };
            RespuestaPosible respuestaPosible11 = new RespuestaPosible { Valor = "11", Descripcion = "Algo claro(a)" };
            RespuestaPosible respuestaPosible12 = new RespuestaPosible { Valor = "12", Descripcion = "Poco claro(a)" };
            RespuestaPosible respuestaPosible13 = new RespuestaPosible { Valor = "13", Descripcion = "Muy competente" };
            RespuestaPosible respuestaPosible14 = new RespuestaPosible { Valor = "14", Descripcion = "Competente" };
            RespuestaPosible respuestaPosible15 = new RespuestaPosible { Valor = "15", Descripcion = "Poco competente" };

            /* Creación de los objetos Pregunta */
            Pregunta pregunta1 = new Pregunta { DescripcionPregunta = "¿Cuál es tu canal de comunicación preferido para contactar con nuestro servicio de atención al cliente?" };
            Pregunta pregunta2 = new Pregunta { DescripcionPregunta = "¿Qué aspecto valoras más en un buen servicio de atención al cliente?" };
            Pregunta pregunta3 = new Pregunta { DescripcionPregunta = "¿Qué tan satisfecho(a) estás con el tiempo de espera para ser atendido(a) por nuestro servicio de atención al cliente?" };
            Pregunta pregunta4 = new Pregunta { DescripcionPregunta = "¿Qué tan claro(a) encuentras el lenguaje utilizado por nuestro equipo de atención al cliente al brindarte información o solucionar tus problemas ?" };
            Pregunta pregunta5 = new Pregunta { DescripcionPregunta = "Qué tan competente te parece nuestro equipo de atención al cliente al resolver tus consultas o problemas?" };

            /* Se agregan a las preguntas sus respuestas*/
            pregunta1.Respuesta.Add(respuestaPosible1);
            pregunta1.Respuesta.Add(respuestaPosible2);
            pregunta1.Respuesta.Add(respuestaPosible3);

            pregunta2.Respuesta.Add(respuestaPosible4);
            pregunta2.Respuesta.Add(respuestaPosible5);
            pregunta2.Respuesta.Add(respuestaPosible6);

            pregunta3.Respuesta.Add(respuestaPosible7);
            pregunta3.Respuesta.Add(respuestaPosible8);
            pregunta3.Respuesta.Add(respuestaPosible9);

            pregunta4.Respuesta.Add(respuestaPosible10);
            pregunta4.Respuesta.Add(respuestaPosible11);
            pregunta4.Respuesta.Add(respuestaPosible12);

            pregunta5.Respuesta.Add(respuestaPosible13);
            pregunta5.Respuesta.Add(respuestaPosible14);
            pregunta5.Respuesta.Add(respuestaPosible15);

            /* Creación de los objetos Encuesta */
            Encuesta encuesta1 = new Encuesta { Descripcion = "Encuesta 1", FechaFinVigencia = DateTime.Parse("2023-04-26 11:30:00") };
            Encuesta encuesta2 = new Encuesta { Descripcion = "Encuesta 2", FechaFinVigencia = DateTime.Parse("2023-04-03 11:00:00") };
            Encuesta encuesta3 = new Encuesta { Descripcion = "Encuesta 3", FechaFinVigencia = DateTime.Parse("2023-05-25 10:15:00") };

            /* Se agregan a las encuestas sus preguntas */
            encuesta1.Pregunta.Add(pregunta1);
            encuesta1.Pregunta.Add(pregunta2);
            encuesta1.Pregunta.Add(pregunta3);

            encuesta2.Pregunta.Add(pregunta1);
            encuesta2.Pregunta.Add(pregunta4);
            encuesta2.Pregunta.Add(pregunta5);

            encuesta3.Pregunta.Add(pregunta2);
            encuesta3.Pregunta.Add(pregunta4);
            encuesta3.Pregunta.Add(pregunta5);

            /* Creación de los objetos RespuestaDeCliente */
            RespuestaDeCliente respuesta1 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible1, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta2 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible4, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta3 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible7, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };

            RespuestaDeCliente respuesta4 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible2, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta5 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible5, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta6 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible8, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };

            RespuestaDeCliente respuesta7 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible3, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta8 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible6, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta9 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible9, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };

            RespuestaDeCliente respuesta10 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible10, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta11 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible14, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta12 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible1, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };

            RespuestaDeCliente respuesta13 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible15, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta14 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible12, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta15 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible6, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };

            RespuestaDeCliente respuesta16 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible3, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta17 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible12, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };
            RespuestaDeCliente respuesta18 = new RespuestaDeCliente { RespuestaSeleccionada = respuestaPosible14, FechaDeEncuesta = DateTime.Parse("2023-04-26 11:30:00") };

            /* Creación de los objetos Llamada */
            Llamada llamada0 = new Llamada { Cliente = cl0, EncuestaEnviada = true };
            Llamada llamada1 = new Llamada { Cliente = cl1, EncuestaEnviada = true };
            Llamada llamada2 = new Llamada { Cliente = cl2, EncuestaEnviada = true };
            Llamada llamada3 = new Llamada { Cliente = cl3, EncuestaEnviada = true };
            Llamada llamada4 = new Llamada { Cliente = cl4, EncuestaEnviada = true };
            Llamada llamada5 = new Llamada { Cliente = cl5, EncuestaEnviada = true };

            /* Se agregan a las llamadas sus cambios de estado*/
            llamada0.CambiosEstado.Add(ce0);
            llamada0.CambiosEstado.Add(ce3);
            llamada0.CambiosEstado.Add(ce7);
            llamada0.CambiosEstado.Add(ce11);

            llamada1.CambiosEstado.Add(ce1);
            llamada1.CambiosEstado.Add(ce4);
            llamada1.CambiosEstado.Add(ce6);
            llamada1.CambiosEstado.Add(ce10);

            llamada2.CambiosEstado.Add(ce2);
            llamada2.CambiosEstado.Add(ce5);
            llamada2.CambiosEstado.Add(ce8);
            llamada2.CambiosEstado.Add(ce9);

            llamada3.CambiosEstado.Add(ce0);
            llamada3.CambiosEstado.Add(ce3);
            llamada3.CambiosEstado.Add(ce7);
            llamada3.CambiosEstado.Add(ce11);

            llamada4.CambiosEstado.Add(ce1);
            llamada4.CambiosEstado.Add(ce4);
            llamada4.CambiosEstado.Add(ce6);
            llamada4.CambiosEstado.Add(ce10);

            llamada5.CambiosEstado.Add(ce2);
            llamada5.CambiosEstado.Add(ce5);
            llamada5.CambiosEstado.Add(ce8);
            llamada5.CambiosEstado.Add(ce9);

            /* Se agregan a las llamadas sus respuestas de cliente */
            llamada0.RespuestasDeEncuesta.Add(respuesta1);
            llamada0.RespuestasDeEncuesta.Add(respuesta2);
            llamada0.RespuestasDeEncuesta.Add(respuesta3);

            llamada1.RespuestasDeEncuesta.Add(respuesta4);
            llamada1.RespuestasDeEncuesta.Add(respuesta5);
            llamada1.RespuestasDeEncuesta.Add(respuesta6);

            llamada2.RespuestasDeEncuesta.Add(respuesta7);
            llamada2.RespuestasDeEncuesta.Add(respuesta8);
            llamada2.RespuestasDeEncuesta.Add(respuesta9);

            llamada3.RespuestasDeEncuesta.Add(respuesta10);
            llamada3.RespuestasDeEncuesta.Add(respuesta11);
            llamada3.RespuestasDeEncuesta.Add(respuesta12);

            llamada4.RespuestasDeEncuesta.Add(respuesta13);
            llamada4.RespuestasDeEncuesta.Add(respuesta14);
            llamada4.RespuestasDeEncuesta.Add(respuesta15);

            llamada5.RespuestasDeEncuesta.Add(respuesta16);
            llamada5.RespuestasDeEncuesta.Add(respuesta17);
            llamada5.RespuestasDeEncuesta.Add(respuesta18);

            /* Se agregan al gestor todas las llamadas */
            //GestorEncuesta gestor = new GestorEncuesta ();
            this.Llamadas.Add(llamada0);
            this.Llamadas.Add(llamada1);
            this.Llamadas.Add(llamada2);
            this.Llamadas.Add(llamada3);
            this.Llamadas.Add(llamada4);
            this.Llamadas.Add(llamada5);

            /* Se agregan al gestor todas las encuestas */
            this.Encuesta.Add(encuesta1);
            this.Encuesta.Add(encuesta2);
            this.Encuesta.Add(encuesta3);
        }


        public string MostrarCSV()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CSV:");
            sb.AppendLine(BuscarDatosLlamada());
            sb.AppendLine("Duracion de llamada:").Append(DuracionLlamada.ToString());
            BuscarRespuestas();
            Encuesta enc = BuscarPreguntasDeEncuesta(RtasSeleccionadas);
            foreach (Pregunta preg in enc.Pregunta)
            {
                foreach (RespuestaPosible res in rtasSeleccionadas)
                {
                    if (preg.Respuesta.Contains(res))
                    {
                        sb.AppendLine(preg.DescripcionPregunta).Append(res.Descripcion);
                    }
                }
            }

            return sb.ToString();
        }

        public void TomarSeleccionFechasFiltros(DateTime fechaIniP, DateTime fechaFinP)
        {
            FechaInicioPeriodo = fechaIniP;
            FechaFinPeriodo = fechaFinP;

            List<Llamada> llamadasRespondidas = BuscarLlamadasConEncuestaRespondida();
            PantallaEncuesta.pedirSeleccionLlamada(llamadasRespondidas);
        }

        public List<Llamada> BuscarLlamadasConEncuestaRespondida()
        {
            List<Llamada> llamadasFiltradas = new List<Llamada>();
            foreach (Llamada llamada in this.Llamadas)
            {
                if (llamada.EsDePeriodo(FechaInicioPeriodo, FechaFinPeriodo) && llamada.TieneEncuestaRespondida())
                {
                    llamadasFiltradas.Add(llamada);
                }
            }
            return llamadasFiltradas;
        }

        public void TomarSeleccionLlamada(Llamada llamadaElegida)
        {
            LlamadaSeleccionada = llamadaElegida;
            BuscarDatosLlamada();
            DuracionLlamada = LlamadaSeleccionada.GetDuracion();
            RtasCliente = LlamadaSeleccionada.RespuestasDeEncuesta;
        }

        public string BuscarDatosLlamada()
        {
            return llamadaSeleccionada.GetNombreClienteYEstado();
        }

        public void BuscarRespuestas()
        {
           
            foreach (RespuestaDeCliente res in RtasCliente)
            {
                 RtasSeleccionadas.Append(res.RespuestaSeleccionada);
            }   
        }

        public Encuesta BuscarPreguntasDeEncuesta(List<RespuestaPosible> respuestas)
        {
            foreach (Encuesta encu in this.encuesta)
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
            PantallaEncuesta.pedirOpcionFinalizacion();
            return encuesta.Descripcion;
        }
    }
}
