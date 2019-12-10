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
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
            CalcularTotales();
        }
        private void Gastos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tabla frmTabla = new Tabla();
            frmTabla.Show();
        }
        private void CalcularTotales() 
        {
            double peaje = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                peaje += Convert.ToDouble(row.Cells["PeajeEst"].Value);                 //PEAJE
            }
            txtPE.Text = Convert.ToString(peaje);

            double GNC = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                GNC += Convert.ToDouble(row.Cells["GNC"].Value);                 //GNC
            }
            txtGNC.Text = Convert.ToString(GNC);

            double nafta = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                nafta += Convert.ToDouble(row.Cells["Nafta"].Value);                 //NAFTA
            }
            txtNafta.Text = Convert.ToString(nafta);

            double minespera = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                minespera += Convert.ToDouble(row.Cells["MinEspera"].Value);                 //MIN ESPERA
            }
            txtMinEsp.Text = Convert.ToString(minespera);

            double impesp = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                impesp += Convert.ToDouble(row.Cells["ImporteEsp"].Value);                 //IMP ESPERA
            }
            txtTotalEsp.Text = Convert.ToString(impesp);

            double imp = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                imp += Convert.ToDouble(row.Cells["Importe"].Value);                 //IMPORTE
            }
            txtImpT.Text = Convert.ToString(imp);

            double ttotal = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                ttotal += Convert.ToDouble(row.Cells["Total"].Value);                 //TOTAL
            }
            txtTotal.Text = Convert.ToString(ttotal);
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            CalcularTotales();
        }
    }
}
