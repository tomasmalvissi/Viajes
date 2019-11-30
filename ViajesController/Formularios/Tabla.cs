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
            this.Dispose();
        }

        private void Tabla_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        public void Modificar() 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Formularios.Agregar agr = new Formularios.Agregar();
                agr.tbNumV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                agr.tbEmpr.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                agr.tbOrig.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                agr.tbDes.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                agr.tbKM.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                agr.tbPasaj.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                agr.tbMEspe.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                agr.tbPeaj.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                agr.tbGNC.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                agr.tbImporte.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                agr.tbImpEsp.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                agr.tbTotal.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                agr.tbNafta.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                agr.label1.Text = "Modificar Viaje";
                agr.btnModif.Visible = true;
                agr.Show();
                this.Dispose();
            }
        }
    }
}
