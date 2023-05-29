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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CSV ventana = new CSV();
            ventana.ShowDialog();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
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
            MessageBox.Show("Se comenzará la impresión de la encuesta de la llmada seleccionada");
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

            if (e.RowIndex >= 0 && e.RowIndex < dgwLlamadasEncuesta.Rows.Count)
            { 
                if (llamadaList.Count > e.RowIndex)
                {
                    gestor.LlamadaSeleccionada = llamadaList[e.RowIndex];
                    gestor.TomarSeleccionLlamada(gestor.LlamadaSeleccionada);
                    // MessageBox.Show(gestor.LlamadaSeleccionada.MostrarDatos());
                    //pedirOpcionFinalizacion();
                    pedirOpcionLlamada(gestor.LlamadaDatos);
                }
            }
            else
            {
                MessageBox.Show("Índice de fila inválido.");
            }
        }

        //public void pedirOpcionFinalizacion()
        //{
        //    string cargaDatos = gestor.MostrarCSV();
        //    Console.WriteLine(gestor.LlamadaDatos.ToString());

        //    // Limpiar los datos existentes en el DataGridView
        //    dgwLlamada.Rows.Clear();

        //    string[] filas = cargaDatos.Split('\n');

        //    foreach (string fila in filas)
        //    {
        //        // Dividir la fila en columnas utilizando el coma como separador
        //        string[] columnas = fila.Split(',');

        //        // Crear una nueva fila en el DataGridView y asignar los valores de las columnas
        //        dgwLlamada.Rows.Add(columnas);
        //    }
        //}

        //public void pedirOpcionLlamada(List<string> datos)
        //{
        //    dgwLlamada.Rows.Clear();
        //    int contador = 0;

        //    // Recorrer la lista de personas y agregar cada persona como una fila en el DataGridView
        //    foreach (string llama in datos)
        //    {
        //        contador++;
        //        string nombreLlamada = "Llamada" + contador.ToString();
        //        dgwLlamada.Rows.Add(nombreLlamada, gestor.LlamadaDatos);
        //    }
        //}

        public void pedirOpcionLlamada(List<string> datos)
        {
            dgwLlamada.Rows.Clear();
            int contador = 0;

            foreach (string elemento in datos)
            {
                contador++;
                string nombreLlamada = "Llamada" + contador.ToString();

                // Verificar que haya suficientes datos en la lista gestor.LlamadaDatos
                if (contador <= gestor.LlamadaDatos.Count)
                {
                    dgwLlamada.Rows.Add(nombreLlamada, gestor.LlamadaDatos[0], gestor.LlamadaDatos[1], gestor.LlamadaDatos[2]);
                }
            }
        }

            private void btnGenerarCSV_Click(object sender, EventArgs e)
        {
            CSV ventana = new CSV();
            ventana.ShowDialog();
        }
    }
}
