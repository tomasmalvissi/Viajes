using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViajesController.Formularios
{
    public partial class Tarifario : Form
    {
        public Tarifario()
        {
            InitializeComponent();
        }
        private void Tarifario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
        }

    }
}
