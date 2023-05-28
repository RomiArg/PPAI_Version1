using PPAI_Version1.Analisis;
using PPAI_Version1.Entidades;
using System;
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

            private void btnGenerar_Click(object sender, EventArgs e)
            {
                CSV ventana = new CSV();
                ventana.ShowDialog();
            }

            private void VentanaPrincipal_Load(object sender, EventArgs e)
            {
                // pedirFechasFiltroPeriodo();
                this.gestor.ConsultarEncuesta();
            }

            public void pedirFechasFiltroPeriodo() { MessageBox.Show("Por favor colocar las fechas de inicio y fin del periodo a buscar"); }

            private void btnBuscarPeriodo_Click(object sender, EventArgs e)
            {
                DateTime fechaInicio = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;
                gestor.TomarSeleccionFechasFiltros(fechaInicio, fechaFin);
            }

            private void btnImprimir_Click(object sender, EventArgs e)
            {

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

                // Recorrer la lista de personas y agregar cada persona como una fila en el DataGridView
                foreach (Llamada llama in llamadas)
                {  
                    contador++;
                    string nombreLlamada = "Llamada" + contador.ToString();
                    dgwLlamadasEncuesta.Rows.Add(nombreLlamada, llama.Cliente.NombreCompleto, llama.EncuestaEnviada);
                }
            }

        private void dgwLlamadasEncuesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Llamada> llamadaList = gestor.BuscarLlamadasConEncuestaRespondida();

            // Verificar si el índice de fila es válido
            if (e.RowIndex >= 0 && e.RowIndex < dgwLlamadasEncuesta.Rows.Count)
            {
                // Obtener el objeto seleccionado en la grilla si la lista contiene elementos
                if (llamadaList.Count > e.RowIndex)
                {
                    gestor.LlamadaSeleccionada = llamadaList[e.RowIndex];
                    gestor.TomarSeleccionLlamada(gestor.LlamadaSeleccionada);
                    MessageBox.Show(gestor.LlamadaSeleccionada.MostrarDatos());
                }
            }
            else
            {
                MessageBox.Show("Índice de fila inválido.");
            }
        }

        public void pedirOpcionFinalizacion()
        {
            gestor.MostrarCSV();
            dgwLlamada.Rows.Clear();
            int contador = 0;

            // Recorrer la lista de personas y agregar cada persona como una fila en el DataGridView
            foreach (Llamada llama in gestor.Llamadas)
            {
                contador++;
                string nombreLlamada = "Llamada" + contador.ToString();
                dgwLlamadasEncuesta.Rows.Add(nombreLlamada, llama.Cliente.NombreCompleto, llama.EncuestaEnviada);
            }
        }
    }
}
