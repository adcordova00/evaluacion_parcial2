using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion_Parcial_2.Views;

namespace Evaluacion_Parcial_2.Views
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void avionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Aviones _Aviones = new frm_Aviones();
            _Aviones.ShowDialog();
        }

        private void agregarAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Aviones _Aviones = new frm_Aviones();
            _Aviones.ShowDialog();
        }

        private void listaAvionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listar_Aviones _Listar_Aviones = new frm_listar_Aviones();
            _Listar_Aviones.ShowDialog();
        }

        private void aeropuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Aeropuertos _Aeropuertos = new frm_Aeropuertos();
            _Aeropuertos.ShowDialog();
        }

        private void listoAeropuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listar_Aeropuertos _Listar_Aeropuertos = new frm_listar_Aeropuertos();
            _Listar_Aeropuertos.ShowDialog();
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pasajeros _Pasajeros = new frm_Pasajeros();
            _Pasajeros.ShowDialog();
        }

        private void listarPasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listar_Pasajeros _Listar_Pasajeros = new frm_listar_Pasajeros();
            _Listar_Pasajeros.ShowDialog();
        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Vuelos _Vuelos = new frm_Vuelos();
            _Vuelos.ShowDialog();
        }

        private void listarVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listar_Vuelos _Listar_Vuelos = new frm_listar_Vuelos();
            _Listar_Vuelos.ShowDialog();
        }

        private void reporteVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hola");
        }
    }
}
