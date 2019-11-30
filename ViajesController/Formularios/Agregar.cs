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

namespace ViajesController.Formularios
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            MessageBox.Show("¡Datos guardados con éxito!");
        }


        private void Agregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tabla frmTabla = new Tabla();
            frmTabla.Show();
        }
        private void GuardarDatos() 
        {
            Viajes nuevoViaje = new Viajes();
            DateTime date = dateTimePicker1.Value;
            nuevoViaje.Fecha = date;
            nuevoViaje.NroViaje = int.Parse(tbNumV.Text);
            nuevoViaje.Empresa = tbEmpr.Text;
            nuevoViaje.Origen = tbOrig.Text;
            nuevoViaje.Destino = tbDes.Text;
            nuevoViaje.KM = float.Parse(tbKM.Text);
            nuevoViaje.Pasajero = tbPasaj.Text;
            nuevoViaje.MinEsper = float.Parse(tbMEspe.Text);
            nuevoViaje.PeajeEst = float.Parse(tbPeaj.Text);
            nuevoViaje.GNC = float.Parse(tbGNC.Text);
            nuevoViaje.Importe = float.Parse(tbImporte.Text);
            nuevoViaje.ImporteEsp = float.Parse(tbImpEsp.Text);
            nuevoViaje.Total = float.Parse(tbTotal.Text);
            nuevoViaje.Nafta = float.Parse(tbNafta.Text);

            ConecDB conec = new ConecDB();
            Consulta consulta = new Consulta();
            conec.AbrirConexion();
            consulta.Grabar(nuevoViaje);
        }
        private void Editar() 
        {
            Viajes nuevoViaje = new Viajes();
            DateTime date = dateTimePicker1.Value;
            nuevoViaje.Fecha = date;
            nuevoViaje.NroViaje = int.Parse(tbNumV.Text);
            nuevoViaje.Empresa = tbEmpr.Text;
            nuevoViaje.Origen = tbOrig.Text;
            nuevoViaje.Destino = tbDes.Text;
            nuevoViaje.KM = float.Parse(tbKM.Text);
            nuevoViaje.Pasajero = tbPasaj.Text;
            nuevoViaje.MinEsper = float.Parse(tbMEspe.Text);
            nuevoViaje.PeajeEst = float.Parse(tbPeaj.Text);
            nuevoViaje.GNC = float.Parse(tbGNC.Text);
            nuevoViaje.Importe = float.Parse(tbImporte.Text);
            nuevoViaje.ImporteEsp = float.Parse(tbImpEsp.Text);
            nuevoViaje.Total = float.Parse(tbTotal.Text);
            nuevoViaje.Nafta = float.Parse(tbNafta.Text);

            ConecDB conec = new ConecDB();
            Consulta consulta = new Consulta();
            conec.AbrirConexion();
            consulta.Editar(nuevoViaje);

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Editar();
            MessageBox.Show("¡Datos guardados con éxito!");
        }
    }
}
