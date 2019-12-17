using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViajesController
{
    public partial class Inicial : Form
    {
        Formularios.Tabla tbl = new Formularios.Tabla();
        Consulta consulta = new Consulta();
        Formularios.Tarifario tarif = new Formularios.Tarifario();
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnMesAct_Click(object sender, EventArgs e)
        {
            this.Hide();
            tbl.Show();
        }

        private void btnTarif_Click(object sender, EventArgs e)
        {
            this.Hide();
            tarif.Show();
        }

        private void Inicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
