using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion_Parcial_2.Models;
using Evaluacion_Parcial_2.Controllers;

namespace Evaluacion_Parcial_2.Views
{
    public partial class frm_Vuelos : Form
    {
        private VueloModel vueloActual;
        private VueloController vueloController;
        private AeropuertoController aeropuertoController;
        private AvionController avionController;
        public frm_Vuelos()
        {
            InitializeComponent();
            vueloController = new VueloController();
            aeropuertoController = new AeropuertoController();
            avionController = new AvionController();
        }

        public frm_Vuelos(VueloModel vuelo) : this()
        {
            vueloActual = vuelo;
            cb_aeropuerto_origen.SelectedItem = vuelo.ID_Aeropuerto_Origen;
            cb_aeropuerto_destino.SelectedItem = vuelo.ID_Aeropuerto_Destino;
            cb_avion.SelectedItem = vuelo.ID_Avion;
            dtp_fecha_vuelo.Value = Convert.ToDateTime(vuelo.Fecha);
        }

        private void CargarCBAeropuertos()
        {
            var aeropuertos = aeropuertoController.ObtenerAeropuertos();

            foreach (var aeropuerto in aeropuertos)
            {
                cb_aeropuerto_origen.Items.Add(aeropuerto);
                cb_aeropuerto_destino.Items.Add(aeropuerto);
            }
        }

        private void CargarCBAviones()
        {
            var aviones = avionController.ObtenerAviones();

            foreach (var avion in aviones)
            {
                cb_avion.Items.Add(avion);
            }
        }

        private void btn_guardar_vuelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (vueloActual == null)
                {
                    VueloModel nuevoVuelo = new VueloModel
                    {
                        ID_Aeropuerto_Origen = Convert.ToInt32(cb_aeropuerto_origen.SelectedItem),
                        ID_Aeropuerto_Destino = Convert.ToInt32(cb_aeropuerto_destino.SelectedItem),
                        ID_Avion = Convert.ToInt32(cb_avion.SelectedItem),
                        Fecha = Convert.ToDateTime(dtp_fecha_vuelo.Value),
                    };
                    vueloController.AgregarVuelo(nuevoVuelo);
                    MessageBox.Show("Vuelo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    vueloActual.ID_Aeropuerto_Origen = Convert.ToInt32(cb_aeropuerto_origen.SelectedItem);
                    vueloActual.ID_Aeropuerto_Destino = Convert.ToInt32(cb_aeropuerto_destino.SelectedItem);
                    vueloActual.ID_Avion = Convert.ToInt32(cb_avion.SelectedItem);
                    vueloActual.Fecha = Convert.ToDateTime(dtp_fecha_vuelo.Value);
                    vueloController.ActualizarVuelo(vueloActual);
                    MessageBox.Show("Vuelo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vuelo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Vuelos_Load(object sender, EventArgs e)
        {
            CargarCBAeropuertos();
            CargarCBAviones();
        }
    }
}
