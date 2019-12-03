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
        public Inicial()
        {
            InitializeComponent();
        }

        private void btnMesAct_Click(object sender, EventArgs e)
        {
            this.Hide();
            tbl.Show();
        }

        private void btnFiltrado_Click(object sender, EventArgs e)
        {
            Viajes NuevoViaje = new Viajes();
            NuevoViaje.fechavalue = dpickIni.Value.Date;
            NuevoViaje.fechafin = dpickFin.Value.Date;
            consulta.Filtrar(NuevoViaje);
            this.Hide();
            tbl.Show();

        }
    }
}
