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
    }
}
