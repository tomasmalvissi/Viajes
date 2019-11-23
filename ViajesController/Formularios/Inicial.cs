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
        public Inicial()
        {
            InitializeComponent();

        }

        private void btnMesAct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.Tabla tbl = new Formularios.Tabla();
            tbl.Show();
        }
    }
}
