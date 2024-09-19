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
    public partial class frm_Pasajeros : Form
    {
        private PasajeroModel pasajeroActual;
        private PasajeroController pasajeroController;
        private VueloController vueloController;
        public frm_Pasajeros()
        {
            InitializeComponent();
            pasajeroController = new PasajeroController();
            vueloController = new VueloController();
        }

        public frm_Pasajeros(PasajeroModel pasajero) : this()
        {
            pasajeroActual = pasajero;
            txt_nombre_pasajero.Text = pasajero.Nombre; 
            cb_vuelo_pasajero.SelectedValue = pasajero.ID_Vuelo;
        }

        private void CargarCBVuelos()
        {
            var vuelos = vueloController.ObtenerVuelos();

            foreach (var vuelo in vuelos)
            {
                cb_vuelo_pasajero.Items.Add(vuelo);
            }
        }


        private void btn_guardar_pasajero_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasajeroActual == null) 
                {
                    PasajeroModel nuevoPasajero = new PasajeroModel
                    {
                        Nombre = txt_nombre_pasajero.Text,
                        ID_Vuelo = Convert.ToInt32(cb_vuelo_pasajero.SelectedValue),
                    };
                    pasajeroController.AgregarPasajero(nuevoPasajero);
                    MessageBox.Show("Pasajero agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    pasajeroActual.Nombre = txt_nombre_pasajero.Text;
                    pasajeroActual.ID_Vuelo = Convert.ToInt32(cb_vuelo_pasajero.SelectedValue);
                    pasajeroController.ActualizarPasajero(pasajeroActual);
                    MessageBox.Show("Pasajero modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pasajero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
