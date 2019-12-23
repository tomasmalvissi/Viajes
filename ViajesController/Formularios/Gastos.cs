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
            txtPE.Text = peaje.ToString("#.##");

            double GNC = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                GNC += Convert.ToDouble(row.Cells["GNC"].Value);                 //GNC
            }
            txtGNC.Text = GNC.ToString("#.##");

            double nafta = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                nafta += Convert.ToDouble(row.Cells["Nafta"].Value);                 //NAFTA
            }
            txtNafta.Text = nafta.ToString("#.##");

            double minespera = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                minespera += Convert.ToDouble(row.Cells["MinEspera"].Value);                 //MIN ESPERA
            }
            txtMinEsp.Text = minespera.ToString("#.##");

            double impesp = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                impesp += Convert.ToDouble(row.Cells["ImporteEsp"].Value);                 //IMP ESPERA
            }
            txtTotalEsp.Text = impesp.ToString("#.##");

            double imp = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                imp += Convert.ToDouble(row.Cells["Importe"].Value);                 //IMPORTE
            }
            txtImpT.Text = imp.ToString("#.##");

            double ttotal = 0;
            foreach (DataGridViewRow row in dataGridTotal.Rows)
            {
                ttotal += Convert.ToDouble(row.Cells["Total"].Value);                 //TOTAL
            }
            txtTotal.Text = ttotal.ToString("#.##");
        }

        private void Gastos_Load(object sender, EventArgs e)
        {
            CalcularTotales();
            dataGridTotal.Columns[2].HeaderText = "Nº Viaje";
            dataGridTotal.Columns[6].HeaderText = "Kilometros";
            dataGridTotal.Columns[8].HeaderText = "M. Espera";
            dataGridTotal.Columns[9].HeaderText = "Peaje";
            dataGridTotal.Columns[13].HeaderText = "Importe Espera";
            dataGridTotal.Columns["Importe"].DefaultCellStyle.Format = "N2";
            dataGridTotal.Columns["ImporteEsp"].DefaultCellStyle.Format = "N2";
            dataGridTotal.Columns["Total"].DefaultCellStyle.Format = "N2";
        }
    }
}
