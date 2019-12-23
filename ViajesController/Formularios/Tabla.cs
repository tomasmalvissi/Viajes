using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ViajesController.Formularios
{
    public partial class Tabla : Form
    {

        Agregar agr = new Agregar();
        Gastos gastos = new Gastos();

        public Tabla()
        {
            InitializeComponent();
    
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime fechaini = new DateTime(date.Year, date.Month, 1);
            DateTime fechafin = fechaini.AddMonths(1).AddDays(-1);
            Consulta consulta = new Consulta();
            dataGridView1.DataSource = consulta.TFiltro(fechaini, fechafin);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns["Importe"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["ImporteEsp"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].HeaderText = "Nº Viaje";
            dataGridView1.Columns[6].HeaderText = "Kilometros";
            dataGridView1.Columns[8].HeaderText = "M. Espera";
            dataGridView1.Columns[9].HeaderText = "Peaje";
            dataGridView1.Columns[13].HeaderText = "Importe Espera";
            Mes();
            dpickf1.Value = fechaini;
            dpickf2.Value = fechafin;
        }


        private void btnAgViaje_Click(object sender, EventArgs e)
        {
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
    

        private void Modificar() 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
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
                agr.tbNafta.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                agr.tbTotal.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                agr.lblidvalue.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                agr.label1.Text = "Modificar Viaje";
                agr.btnModif.Visible = true;
                agr.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar", "Editar Viaje");
            }            
        }
        public void Eliminar()
        {
            string idvalue = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            ConecDB conec = new ConecDB();
            Consulta consulta = new Consulta();
            conec.AbrirConexion();
            consulta.Borrar(idvalue);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el viaje seleccionado?", "¡Alerta!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    agr.lblidvalue.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    Eliminar();
                    DateTime date = DateTime.Now;
                    DateTime fechaini = new DateTime(date.Year, date.Month, 1);
                    DateTime fechafin = fechaini.AddMonths(1).AddDays(-1);
                    Consulta consulta = new Consulta();
                    dataGridView1.DataSource = consulta.TFiltro(fechaini, fechafin);
                    dataGridView1.Columns[0].Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para borrar ", "Eliminar Viaje");
            }


        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Style.BackColor = Color.YellowGreen; 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
            this.Dispose();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (panelSide.Width == 203)
            {
                panelSide.Width = 50;
                lblD.Visible = false;
                lblH.Visible = false;
                dpickf2.Visible = false;
                dpickf1.Visible = false;
            }
            else
            {
                panelSide.Width = 203;
                lblD.Visible = true;
                lblH.Visible = true;
                dpickf2.Visible = true;
                dpickf1.Visible = true;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechavalue = dpickf1.Value.Date;
            DateTime fechafin = dpickf2.Value.Date;
            Consulta consulta = new Consulta();
            dataGridView1.DataSource = consulta.TFiltro(fechavalue, fechafin);
            Mes();
            dataGridView1.Columns["Importe"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["ImporteEsp"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["Total"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[2].HeaderText = "Nº Viaje";
            dataGridView1.Columns[6].HeaderText = "Kilometros";
            dataGridView1.Columns[8].HeaderText = "M. Espera";
            dataGridView1.Columns[9].HeaderText = "Peaje";
            dataGridView1.Columns[13].HeaderText = "Importe Espera";

        }
        private void Mes() 
        {
            switch (dpickf1.Value.Date.Month)
            {
                case 1:
                    lblMes.Text = "Enero";
                    gastos.lblTitle.Text = "Totales de Enero";
                    break;
                case 2:
                    lblMes.Text = "Febrero";
                    gastos.lblTitle.Text = "Totales de Febrero";
                    break;
                case 3:
                    lblMes.Text = "Marzo";
                    gastos.lblTitle.Text = "Totales de Marzo";
                    break;
                case 4:
                    lblMes.Text = "Abril";
                    gastos.lblTitle.Text = "Totales de Abril";
                    break;
                case 5:
                    lblMes.Text = "Mayo";
                    gastos.lblTitle.Text = "Totales de Mayo";
                    break;
                case 6:
                    lblMes.Text = "Junio";
                    gastos.lblTitle.Text = "Totales de Junio";
                    break;
                case 7:
                    lblMes.Text = "Julio";
                    gastos.lblTitle.Text = "Totales de Julio";
                    break;
                case 8:
                    lblMes.Text = "Agosto";
                    gastos.lblTitle.Text = "Totales de Agosto";
                    break;
                case 9:
                    lblMes.Text = "Septiembre";
                    gastos.lblTitle.Text = "Totales de Septiembre";
                    break;
                case 10:
                    lblMes.Text = "Octubre";
                    gastos.lblTitle.Text = "Totales de Octubre";
                    break;
                case 11:
                    lblMes.Text = "Noviembre";
                    gastos.lblTitle.Text = "Totales de Noviembre";
                    break;
                case 12:
                    lblMes.Text = "Diciembre";
                    gastos.lblTitle.Text = "Totales de Diciembre";
                    break;
            }
        }

        private void btnTotales_Click(object sender, EventArgs e)
        {
            DateTime fechavalue = dpickf1.Value.Date;
            DateTime fechafin = dpickf2.Value.Date;
            Consulta consulta = new Consulta();
            gastos.dataGridTotal.DataSource = consulta.TFiltro(fechavalue, fechafin);
            gastos.dataGridTotal.Columns[0].Visible = false;
            gastos.dataGridTotal.Columns[1].Visible = false;
            gastos.dataGridTotal.Columns[3].Visible = false;
            gastos.dataGridTotal.Columns[4].Visible = false;
            gastos.dataGridTotal.Columns[5].Visible = false;
            gastos.dataGridTotal.Columns[6].Visible = false;
            gastos.dataGridTotal.Columns[7].Visible = false;
            Mes();
            gastos.Show();
            this.Dispose();
        }
    }
}
