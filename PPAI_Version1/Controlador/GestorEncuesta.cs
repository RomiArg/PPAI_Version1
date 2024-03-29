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
        private string nombreLlamada;
        private string estadoActual;
        private List<string> preguntasYRespuestas;
        private string descripcionEncuesta;

        /* M�todos constructores de la clase */
        public GestorEncuesta(PantallaEncuesta pantallaEncuesta)
        {
            this.PantallaEncuesta = pantallaEncuesta;
            Llamadas = new List<Llamada>();
            Encuesta = new List<Encuesta>();
            RtasCliente = new List<RespuestaDeCliente>();
            RtasSeleccionadas = new List<RespuestaPosible>();
            DescripcionPreguntas = new List<Pregunta>();
        }

        public GestorEncuesta(DateTime fechaInicioPeriodo, DateTime fechaFinPeriodo, string nombreCliente, int duracionLlamada, List<RespuestaDeCliente> rtasCliente, List<RespuestaPosible> rtasSeleccionadas, List<Pregunta> descripcionPreguntas, Llamada llamadaSeleccionada, PantallaEncuesta pantallaEncuesta, string nombreLlamada, string estadoActual, List<string> preguntasYRespuestas, string descripcionEncuesta)
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
            this.nombreLlamada = nombreLlamada;
            this.estadoActual = estadoActual;
            this.preguntasYRespuestas = preguntasYRespuestas;
            this.descripcionEncuesta = descripcionEncuesta;
        }
        public GestorEncuesta()
        {
            Llamadas = new List<Llamada>();
            Encuesta = new List<Encuesta>();
            RtasCliente = new List<RespuestaDeCliente>();
            RtasSeleccionadas = new List<RespuestaPosible>();
            DescripcionPreguntas = new List<Pregunta>();
        }

        /* M�todos de seteo de las propiedades */
        public DateTime FechaInicioPeriodo { get { return fechaInicioPeriodo; } set { fechaInicioPeriodo = value; } }
        public DateTime FechaFinPeriodo { get { return fechaFinPeriodo; } set { fechaFinPeriodo = value; } }
        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }
        public List<RespuestaDeCliente> RtasCliente { get { return rtasCliente; } set { rtasCliente = value; } }
        public List<RespuestaPosible> RtasSeleccionadas { get { return rtasSeleccionadas; } set { rtasSeleccionadas = value; } }
        public List<Pregunta> DescripcionPreguntas { get { return descripcionPreguntas; } set { descripcionPreguntas = value; } }
        public Llamada LlamadaSeleccionada { get { return llamadaSeleccionada; } set { llamadaSeleccionada = value; } }
        public List<Encuesta> Encuesta { get { return encuesta; } set { encuesta = value; } }
        public float DuracionLlamada { get { return duracionLlamada; } set { duracionLlamada = value; } }
        public List<Llamada> Llamadas { get { return llamadas; } set { llamadas = value; } }
        public PantallaEncuesta PantallaEncuesta { get; set; }
        public string NombreLlamada { get { return nombreLlamada; } set { nombreLlamada = value; } }
        public string EstadoActual { get { return estadoActual; } set { estadoActual = value; } }
        public List<string> PreguntasYRespuestas { get { return preguntasYRespuestas; } set { preguntasYRespuestas = value; } }
        public string DescripcionEncuesta { get { return descripcionEncuesta; } set { descripcionEncuesta = value; } }

        /* M�todos que son utilizados en la implementaci�n del CU */

        public void ConsultarEncuesta()
        {
            PantallaEncuesta.pedirFechasFiltroPeriodo();

            /* Creacion de los objetos Estado */
            Estado e0 = new Estado("Iniciada");
            Estado e1 = new Estado("Finalizada");
            Estado e2 = new Estado("Cancelada");
            Estado e3 = new Estado("En Curso");

            /* Creaci�n de los objetos CambioEstado */
            CambioEstado ce0 = new CambioEstado(DateTime.Parse("2023-02-02 05:00:00"), e0);
            CambioEstado ce1 = new CambioEstado(DateTime.Parse("2023-01-17 12:45:00"), e0);
            CambioEstado ce2 = new CambioEstado(DateTime.Parse("2023-04-26 18:35:00"), e0);
            CambioEstado ce3 = new CambioEstado(DateTime.Parse("2023-05-25 10:15:00"), e1);
            CambioEstado ce4 = new CambioEstado(DateTime.Parse("2023-04-03 11:00:00"), e1);
            CambioEstado ce5 = new CambioEstado(DateTime.Parse("2023-06-30 11:55:00"), e1);
            CambioEstado ce6 = new CambioEstado(DateTime.Parse("2023-03-22 09:45:00"), e2);
            CambioEstado ce7 = new CambioEstado(DateTime.Parse("2023-01-25 09:00:00"), e2);
            CambioEstado ce8 = new CambioEstado(DateTime.Parse("2023-06-04 11:35:00"), e2);
            CambioEstado ce9 = new CambioEstado(DateTime.Parse("2023-05-19 13:30:00"), e3);
            CambioEstado ce10 = new CambioEstado(DateTime.Parse("2023-05-20 12:20:00"), e3);
            CambioEstado ce11 = new CambioEstado(DateTime.Parse("2023-03-25 15:15:00"), e3);
           

            /* Creaci�n de los objetos Cliente */
            Cliente cl0 = new Cliente("Jos� Perez", 459267987, 1585642548);
            Cliente cl1 = new Cliente("Micaela Gonzalez", 459267987, 1514187694);
            Cliente cl2 = new Cliente("Sofia Vergara", 459267987, 1597541629);
            Cliente cl3 = new Cliente("Celeste Rojas", 459267987, 1649718234);
            Cliente cl4 = new Cliente("Diego Martinez", 459267987, 1952118874);
            Cliente cl5 = new Cliente("Ana Maria Villegas", 459267987, 1649718246);

            /* Creaci�n de los objetos RespuestaPosible */

            RespuestaPosible respuestaPosible1 = new RespuestaPosible { Valor = "1", Descripcion = "Tel�fono" };
            RespuestaPosible respuestaPosible2 = new RespuestaPosible { Valor = "2", Descripcion = "Correo electr�nico" };
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

            /* Creaci�n de los objetos Pregunta */
            Pregunta pregunta1 = new Pregunta { DescripcionPregunta = "�Cu�l es tu canal de comunicaci�n preferido para contactar con nuestro servicio de atenci�n al cliente?" };
            Pregunta pregunta2 = new Pregunta { DescripcionPregunta = "�Qu� aspecto valoras m�s en un buen servicio de atenci�n al cliente?" };
            Pregunta pregunta3 = new Pregunta { DescripcionPregunta = "�Qu� tan satisfecho(a) est�s con el tiempo de espera para ser atendido(a) por nuestro servicio de atenci�n al cliente?" };
            Pregunta pregunta4 = new Pregunta { DescripcionPregunta = "�Qu� tan claro(a) encuentras el lenguaje utilizado por nuestro equipo de atenci�n al cliente al brindarte informaci�n o solucionar tus problemas?" };
            Pregunta pregunta5 = new Pregunta { DescripcionPregunta = "�Qu� tan competente te parece nuestro equipo de atenci�n al cliente al resolver tus consultas o problemas?" };

            /* Se agregan a las preguntas sus respuestas*/
            pregunta1.RespuestaPosibles.Add(respuestaPosible1);
            pregunta1.RespuestaPosibles.Add(respuestaPosible2);
            pregunta1.RespuestaPosibles.Add(respuestaPosible3);

            pregunta2.RespuestaPosibles.Add(respuestaPosible4);
            pregunta2.RespuestaPosibles.Add(respuestaPosible5);
            pregunta2.RespuestaPosibles.Add(respuestaPosible6);

            pregunta3.RespuestaPosibles.Add(respuestaPosible7);
            pregunta3.RespuestaPosibles.Add(respuestaPosible8);
            pregunta3.RespuestaPosibles.Add(respuestaPosible9);

            pregunta4.RespuestaPosibles.Add(respuestaPosible10);
            pregunta4.RespuestaPosibles.Add(respuestaPosible11);
            pregunta4.RespuestaPosibles.Add(respuestaPosible12);

            pregunta5.RespuestaPosibles.Add(respuestaPosible13);
            pregunta5.RespuestaPosibles.Add(respuestaPosible14);
            pregunta5.RespuestaPosibles.Add(respuestaPosible15);

            /* Creaci�n de los objetos Encuesta */
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

            /* Creaci�n de los objetos RespuestaDeCliente */
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

            /* Creaci�n de los objetos Llamada */

            Llamada llamada0 = new Llamada { Cliente = cl0, EncuestaEnviada = true, Duracion = 15 };
            Llamada llamada1 = new Llamada { Cliente = cl1, EncuestaEnviada = true, Duracion = 12 };
            Llamada llamada2 = new Llamada { Cliente = cl2, EncuestaEnviada = true, Duracion = 15 };
            Llamada llamada3 = new Llamada { Cliente = cl3, EncuestaEnviada = true, Duracion = 20 };
            Llamada llamada4 = new Llamada { Cliente = cl4, EncuestaEnviada = true, Duracion = 10 };
            Llamada llamada5 = new Llamada { Cliente = cl5, EncuestaEnviada = true, Duracion = 25 };


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
        /*Este m�todo guarda las fechas que entran por par�metros como variables del gestor y a su vez llama al m�todo 
         BuscarLlamadasConEncuestaRespondida y guarda el resultado de este en una variable local. */
        public void TomarSeleccionFechasFiltros(DateTime fechaIniP, DateTime fechaFinP)
        {
            FechaInicioPeriodo = fechaIniP;
            FechaFinPeriodo = fechaFinP;

            List<Llamada> llamadasRespondidas = BuscarLlamadasConEncuestaRespondida();
            if (llamadasRespondidas.Count == 0)
            {
                MessageBox.Show("No existen llamadas con encuestas respondidas en el per�odo indicado. \nPor favor ingresar una nueva fecha de inicio y fin de periodo.");
            }
            else
            {
                PantallaEncuesta.pedirSeleccionLlamada(llamadasRespondidas);
            }
        }

        /* Este m�todo filtra las llamadas por su periodo y si tiene encuesta respondida y devuelve la Lista de llamadas. */
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

        /*Setea la variable LlamadaElegida del gestor y realiza la b�squeda de los datos de la Llamada y la Encuesta  
         y manda un mensaje a la Pantalla para que muestre los datos en la tabla*/
        public void TomarSeleccionLlamada(Llamada llamadaElegida)
        {
            LlamadaSeleccionada = llamadaElegida;
            BuscarDatosLlamada();
            BuscarRespuestas();
            Encuesta Enc = BuscarPreguntasDeEncuesta(RtasSeleccionadas);
            DescripcionEncuesta = Enc.Descripcion;
            PreguntasYRespuestas = BuscarDescripcionEncuestaYPreguntas(Enc);
            PantallaEncuesta.pedirOpcionVisualizacion();
        }

        /*Obtiene los datos de la Llamada guardada en el gestor y llama los m�todos en la clase Llamada que necesita */
        public void BuscarDatosLlamada()
        {
            List<string> NombreYEstado = llamadaSeleccionada.GetNombreClienteYEstado();
            NombreCliente = NombreYEstado[0];
            EstadoActual = NombreYEstado[1];
            DuracionLlamada = llamadaSeleccionada.Duracion;
        }

        /* Busca las respuestas posibles a trav�s de las respuestas del Cliente de la Llamada y las guarda en la variable del Gestor*/
        public void BuscarRespuestas()
        {
            RtasCliente = LlamadaSeleccionada.RespuestasDeEncuesta;
            RtasSeleccionadas = new List<RespuestaPosible>();

            foreach (RespuestaDeCliente res in RtasCliente)
            {
                RtasSeleccionadas.Add(res.RespuestaSeleccionada);
            }
        }

        /* Busca de la clase Encuesta las preguntas que la componen y compara con las respuesta guardadas anteriormente si son iguales y si lo son devuelve la encuesta */
        public Encuesta BuscarPreguntasDeEncuesta(List<RespuestaPosible> respuestas)
        {
            foreach (Encuesta encuesta in encuesta)
            {
                if (encuesta.EsEncuestaDeCliente(respuestas))
                {
                    return encuesta;
                }
            }
            return null;
        }

        /* Busca en la Encuesta las preguntas y las respustas guardadas y las ordena en una lista de strings comparandolas */
        public List<string> BuscarDescripcionEncuestaYPreguntas(Encuesta enc)
        {
            List<string> encuestaArmada = new List<string>();
            foreach (Pregunta preg in enc.Pregunta)
            {
                foreach (RespuestaPosible res in rtasSeleccionadas)
                {
                    if (preg.RespuestaPosibles.Contains(res))
                    {
                        encuestaArmada.Add(preg.DescripcionPregunta);
                        encuestaArmada.Add(res.Descripcion);
                    }
                }
            }
            return encuestaArmada;
        }
    }
}
