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
    public partial class Tarifario : Form
    {
        public double KMg1CBA = 23.37;
        public double KMg1INT = 13.86;
        public double KMg2CBA = 25.4;
        public double KMg2INT = 13.86;
        public double KMg3 = 22.45;
        public double KMg4 = 25.4;
        public double KMg11 = 19.43;

        public double Horag1CBA = 167.67;
        public double Horag1INT = 153.75;
        public double Horag2CBA = 182.25;
        public double Horag2INT = 153.75;
        public double Horag3 = 169.50;
        public double Horag4 = 182.7;
        public double Horag11 = 139.38;
        public Tarifario()
        {
            InitializeComponent();
        }
        private void Tarifario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Inicial ini = new Inicial();
            ini.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            KMg1CBA = double.Parse(tbKMg1.Text);
            KMg1INT = double.Parse(tbKMg1INT.Text);
            KMg2CBA = double.Parse(tbKMg2.Text);
            KMg2INT = double.Parse(tbKMg2INT.Text);
            KMg3 = double.Parse(tbKMg3.Text);
            KMg4 = double.Parse(tbKMg4.Text);
            KMg11 = double.Parse(tbKMg11.Text);

            Horag1CBA = double.Parse(tbHorag1.Text);
            Horag1INT = double.Parse(tbHorag1INT.Text);
            Horag2CBA = double.Parse(tbHorag2.Text);
            Horag2INT = double.Parse(tbHorag2INT.Text);
            Horag3 = double.Parse(tbHorag3.Text);
            Horag4 = double.Parse(tbHorag4.Text);
            Horag11 = double.Parse(tbHorag11.Text);
            consulta.ActTarifas(KMg1CBA, KMg1INT, KMg2CBA, KMg2INT, KMg3, KMg4, KMg11, Horag1CBA, Horag1INT, Horag2CBA, Horag2INT, Horag3, Horag4, Horag11);
            MessageBox.Show("¡Tarifa actualizada con éxito");
        }

        private void Tarifario_Load(object sender, EventArgs e)
        {
            //double res = KMg1CBA * 1;
            //lbl.Text = res.ToString();
        }
    }
}
