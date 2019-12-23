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
        Tarifario tarif = new Tarifario();
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            MessageBox.Show("¡Datos guardados con éxito!");
            Limpiartb();
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
            nuevoViaje.Pasajero = int.Parse(tbPasaj.Text);
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
            Tabla tabla = new Tabla();
            Viajes nuevoViaje = new Viajes();
            DateTime date = dateTimePicker1.Value;
            nuevoViaje.Fecha = date;
            nuevoViaje.NroViaje = int.Parse(tbNumV.Text);
            nuevoViaje.Empresa = tbEmpr.Text;
            nuevoViaje.Origen = tbOrig.Text;
            nuevoViaje.Destino = tbDes.Text;
            nuevoViaje.KM = float.Parse(tbKM.Text);
            nuevoViaje.Pasajero = int.Parse(tbPasaj.Text);
            nuevoViaje.MinEsper = float.Parse(tbMEspe.Text);
            nuevoViaje.PeajeEst = float.Parse(tbPeaj.Text);
            nuevoViaje.GNC = float.Parse(tbGNC.Text);
            nuevoViaje.Importe = float.Parse(tbImporte.Text);
            nuevoViaje.ImporteEsp = float.Parse(tbImpEsp.Text);
            nuevoViaje.Total = float.Parse(tbTotal.Text);
            nuevoViaje.Nafta = float.Parse(tbNafta.Text);
            string idvalue = lblidvalue.Text;

            ConecDB conec = new ConecDB();
            Consulta consulta = new Consulta();
            conec.AbrirConexion();
            consulta.Editar(nuevoViaje, idvalue);

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Editar();
            MessageBox.Show("¡Datos modificados con éxito!");
            Limpiartb();
            Tabla tabla = new Tabla();
            tabla.Show();
            this.Dispose();
        }
        private void Limpiartb() 
        {
            tbNumV.Clear();
            tbOrig.Clear();
            tbDes.Clear();
            tbKM.Clear();
            tbPasaj.Clear();
            tbMEspe.Clear();
            tbPeaj.Clear();
            tbGNC.Clear();
            tbImporte.Clear();
            tbImpEsp.Clear();
            tbTotal.Clear();
            tbNafta.Clear();

        }

        private void tbPeaj_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }
        private void tbPasaj_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }
        private void tbKM_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }

        private void tbMEspe_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }

        private void tbOrig_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }
        private void tbGNC_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }

        private void tbNafta_TextChanged(object sender, EventArgs e)
        {
            AutocompleteCampos();
        }
        private void AutocompleteCampos() 
        {
            double kmprice=0, horaprice=0;
            double kmlocal = Double.Parse(tbKM.Text);
            double horalocal = Double.Parse(tbMEspe.Text);
            if (tbEmpr.Text == "Dupont" || tbEmpr.Text == "Nissan" || tbEmpr.Text == "Loogik" || tbEmpr.Text == "Particular" || tbEmpr.Text == "Savant" || tbEmpr.Text == "Promedón")
            {
                if (tbOrig.Text == "Cordoba")
                {
                    kmprice = tarif.KMg1CBA * kmlocal;
                    horaprice = (tarif.Horag1CBA / 60) * horalocal;
                    tbImporte.Text = kmprice.ToString("#.##");
                    tbImpEsp.Text = horaprice.ToString("#.##");
                }
                else                                                                             //G1
                {
                    kmprice = tarif.KMg1INT * kmlocal;
                    horaprice = (tarif.Horag1INT / 60) * horalocal;
                    tbImporte.Text = kmprice.ToString("#.##");
                    tbImpEsp.Text = horaprice.ToString("#.##");
                }


            }
            else if (tbEmpr.Text == "Asg" || tbEmpr.Text == "Adin" || tbEmpr.Text == "Autoneum" || tbEmpr.Text == "Bureau Beritas" || tbEmpr.Text == "Conduent" || tbEmpr.Text == "Desol" || tbEmpr.Text == "Gerhentes" || tbEmpr.Text == "Gestamp" || tbEmpr.Text == "Globant" || tbEmpr.Text == "Grupo Bimbo" || tbEmpr.Text == "Homecare" || tbEmpr.Text == "HotelY111" || tbEmpr.Text == "Interar Group" || tbEmpr.Text == "Kuehne Nagel" || tbEmpr.Text == "Maxiconsumo" || tbEmpr.Text == "Sekurit" || tbEmpr.Text == "Sturam" || tbEmpr.Text == "Transatlántica" || tbEmpr.Text == "UB" || tbEmpr.Text == "Weber" || tbEmpr.Text == "Sudosilo")
            {

                if (tbOrig.Text == "Cordoba")
                {
                    kmprice = tarif.KMg2CBA * kmlocal;
                    horaprice = (tarif.Horag2CBA / 60) * horalocal;
                    tbImporte.Text = kmprice.ToString("#.##");
                    tbImpEsp.Text = horaprice.ToString("#.##");
                }
                else                                                                             //G2
                {
                    kmprice = tarif.KMg2INT * kmlocal;
                    horaprice = (tarif.Horag2INT / 60) * horalocal;
                    tbImporte.Text = kmprice.ToString("#.##");
                    tbImpEsp.Text = horaprice.ToString("#.##");
                }
            }
            else if (tbEmpr.Text == "Arcor")
            {
                kmprice = (tarif.KMg3 * kmlocal);
                horaprice = (tarif.Horag3 / 60) * horalocal;                                    //G3
                tbImporte.Text = kmprice.ToString("#.##");
                tbImpEsp.Text = horaprice.ToString("#.##");
            }
            else if (tbEmpr.Text == "Copa Airlines" || tbEmpr.Text == "Gol Airlines" || tbEmpr.Text == "Flybondi" || tbEmpr.Text == "Sky Airline" || tbEmpr.Text == "Swissport")
            {
                kmprice = tarif.KMg4 * kmlocal;
                horaprice = (tarif.Horag4 / 60) * horalocal;                                    //G4
                tbImporte.Text = kmprice.ToString("#.##");
                tbImpEsp.Text = horaprice.ToString("#.##");
            }
            else if (tbEmpr.Text == "Holcim")
            {
                kmprice = tarif.KMg11 * kmlocal;
                horaprice = (tarif.Horag11 / 60) * horalocal;                                    //G11
                tbImporte.Text = kmprice.ToString("#.##");
                tbImpEsp.Text = horaprice.ToString("#.##");
            }
            double gncprice = Double.Parse(tbGNC.Text);
            double naftaprice = Double.Parse(tbNafta.Text);                                     //Total
            double PEprice = Double.Parse(tbPeaj.Text);
            double res = (kmprice + horaprice) - (gncprice + naftaprice + PEprice);
            Math.Round(res, 2);
            tbTotal.Text = res.ToString("n2");
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Limpiartb();
        }
    }
}
