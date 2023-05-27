using PPAI_Version1.Analisis;
using PPAI_Version1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_Version1
{
    public partial class VentanaPrincipal : Form
    {
        public GestorEncuesta gestor = new GestorEncuesta();
        public VentanaPrincipal()
        {
            InitializeComponent();
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {
            CSV ventana = new CSV();
            ventana.ShowDialog();
        }

        private void dgwLlamada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarPeriodo_Click(object sender, EventArgs e)
        {
            if (gestor.TomarSeleccionFechasFiltros(dtpFechaInicio.Value, dtpFechaFin.Value))
            {
                MessageBox.Show("Esta bien");
            }
            else
            {
                MessageBox.Show("No se encontraron Llamadas con Encuestas responidas en el periodo indicado");
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void dgwLlamadasEncuesta_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
