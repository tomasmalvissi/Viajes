using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

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
            this.Hide();
            Formularios.Agregar agr = new Formularios.Agregar();
            agr.Show();
        }
        private void Resultado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
