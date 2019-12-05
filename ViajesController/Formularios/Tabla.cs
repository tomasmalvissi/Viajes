﻿using CapaDatos;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ViajesController.Formularios
{
    public partial class Tabla : Form
    {

        NegViajes objViajes = new NegViajes();
        Formularios.Agregar agr = new Formularios.Agregar();
        public string idvalue = "";

        public Tabla()
        {
            InitializeComponent();
            
        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            MostrarViajes();
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
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

        private void MostrarViajes()
        {
            dataGridView1.DataSource = objViajes.MostrarProd();
            dataGridView1.Columns[0].Visible = false;

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
                agr.tbTotal.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                agr.tbNafta.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
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
            }
            else
            {
                panelSide.Width = 203;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            lblD.Visible = true;
            lblH.Visible = true;
            fechafin.Visible = true;
            fechavalue.Visible = true;
        }
    }
}
