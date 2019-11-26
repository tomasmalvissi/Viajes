using CapaNegocio;
using System;
using System.Windows.Forms;

namespace ViajesController.Formularios
{
    public partial class Tabla : Form
    {
        NegViajes objViajes = new NegViajes();
        public Tabla()
        {
            InitializeComponent();
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            MostrarViajes();
        }
        private void MostrarViajes()
        {
            dataGridView1.DataSource = objViajes.MostrarProd();
        }

        private void btnAgViaje_Click(object sender, EventArgs e)
        {
            Formularios.Agregar agr = new Formularios.Agregar();
            agr.Show();
        }

        private void Tabla_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
