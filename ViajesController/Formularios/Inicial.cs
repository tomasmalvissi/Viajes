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
            //DateTime fechavalue = dpickIni.Value.Date;
            //DateTime fechafin = dpickFin.Value.Date;
            //consulta.Filtrar(fechavalue,fechafin);
            //this.Hide();
            //tbl.Show();

        }
    }
}
