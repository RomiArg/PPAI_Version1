using System;
using PPAI_Version1.Analisis;
using PPAI_Version1.Entidades;
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
    public partial class CSV : Form
    {
        private GestorEncuesta gestor;

        public CSV(GestorEncuesta gestor)
        {
            InitializeComponent();

            this.gestor = gestor;
        }
        private void CSV_Load(object sender, EventArgs e)
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
    }
}


