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


            Llamada llamada0 = new Llamada { Cliente = cl0 };
            Llamada llamada1 = new Llamada { Cliente = cl1 };
            Llamada llamada2 = new Llamada { Cliente = cl2 };
            Llamada llamada3 = new Llamada { Cliente = cl3 };
            Llamada llamada4 = new Llamada { Cliente = cl4 };
            Llamada llamada5 = new Llamada { Cliente = cl5 };

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

        private void btnBuscarPeriodo_Click(object sender, EventArgs e)
        {
            if (gestor.TomarSeleccionFechasFiltros(dtpFechaInicio.Value, dtpFechaFin.Value))
            {
                MessageBox.Show("Esta bien");
            }
            else
            {
                MessageBox.Show("No se encontraron Llamadas con Encuestas responidas en el periodo indicado");
                
                if(gestor.TomarSeleccionFechasFiltros(dtpFechaInicio.Value, dtpFechaFin.Value))
                { 
                    MessageBox.Show("Bien"); 
                }
                //this.Close();
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
