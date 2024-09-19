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
    public partial class frm_Aeropuertos : Form
    {
        private AeropuertoModel aeropuertoActual;
        private AeropuertoController aeropuertoController;
        public frm_Aeropuertos()
        {
            InitializeComponent();
            aeropuertoController = new AeropuertoController();
        }

        public frm_Aeropuertos(AeropuertoModel aeropuerto) : this() {
            aeropuertoActual = aeropuerto;
            txt_ciudad_aeropuerto.Text = aeropuerto.Ciudad;
            txt_pais_aeropuerto.Text = aeropuerto.Pais;
        }

        private void btn_guardar_aeropuerto_Click(object sender, EventArgs e)
        {
            try
            {
                if (aeropuertoActual == null) 
                {
                    AeropuertoModel nuevoAeropuerto = new AeropuertoModel
                    {
                        Ciudad = txt_ciudad_aeropuerto.Text,
                        Pais = txt_pais_aeropuerto.Text
                    };
                    aeropuertoController.AgregarAeropuerto(nuevoAeropuerto);
                    MessageBox.Show("Aeropuerto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    aeropuertoActual.Ciudad = txt_ciudad_aeropuerto.Text;
                    aeropuertoActual.Pais = txt_pais_aeropuerto.Text;
                    aeropuertoController.ActualizarAeropuerto(aeropuertoActual);
                    MessageBox.Show("Aeropuerto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Aeropuerto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
