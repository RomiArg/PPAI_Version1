using PPAI_Version1.Analisis;
using PPAI_Version1.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_Version1
{
        public partial class PantallaEncuesta : Form
        {

            private GestorEncuesta gestor;
            public PantallaEncuesta(GestorEncuesta gestor)
            {
                this.gestor = gestor;
                InitializeComponent();
            }
            public PantallaEncuesta()
            {
                InitializeComponent();
                this.gestor = new GestorEncuesta(this);
            }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            this.gestor.ConsultarEncuesta();
        }

        public void pedirFechasFiltroPeriodo() 
        { 
            MessageBox.Show("Por favor colocar las fechas de inicio y fin del periodo a buscar"); 
        }

        private void btnBuscarPeriodo_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;
            gestor.TomarSeleccionFechasFiltros(fechaInicio, fechaFin);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se comenzará la impresión de la encuesta de la llamada seleccionada");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cancelar la ejecución?", "Confirmación", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        public void pedirSeleccionLlamada(List<Llamada> llamadas)
        {
            dgwLlamadasEncuesta.Rows.Clear();
            int contador = 0;

            foreach (Llamada llama in llamadas)
            {  
                contador++;
                string nombreLlamada = "Llamada " + contador.ToString();
                dgwLlamadasEncuesta.Rows.Add(nombreLlamada, llama.Cliente.NombreCompleto, llama.EncuestaEnviada);
            }
        }

        private void dgwLlamadasEncuesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Llamada> llamadaList = gestor.BuscarLlamadasConEncuestaRespondida();
           
            if (e.RowIndex >= 0 && e.RowIndex < dgwLlamadasEncuesta.Rows.Count)
            { 
                if (llamadaList.Count > e.RowIndex)
                {
                    gestor.LlamadaSeleccionada = llamadaList[e.RowIndex];
                    gestor.NombreLlamada = "Llamada " + (e.RowIndex + 1).ToString();
                    gestor.TomarSeleccionLlamada(gestor.LlamadaSeleccionada);
                }
            }
            else
            {
                MessageBox.Show("Índice de fila inválido.");
            }
        }

        public void pedirOpcionVisualizacion()
        {
            dgwLlamada.Rows.Clear();
            dgwPreguntas.Rows.Clear();
            dgwLlamada.Rows.Add(gestor.NombreLlamada, gestor.NombreCliente, gestor.EstadoActual, gestor.DuracionLlamada, gestor.DescripcionEncuesta);
            for (int i = 0; i < ((gestor.PreguntasYRespuestas.Count) / 2); i++)
            {
                int a = i * 2;
                dgwPreguntas.Rows.Add(gestor.PreguntasYRespuestas[a], gestor.PreguntasYRespuestas[a + 1]);
            }
        }
       
        private void btnGenerarCSV_Click(object sender, EventArgs e)
        {
            CSV ventana = new CSV(gestor);
            ventana.ShowDialog();
            Close();
        }
    }
}
