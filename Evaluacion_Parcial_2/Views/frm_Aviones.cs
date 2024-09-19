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
    public partial class frm_Aviones : Form
    {
        private AvionModel avionActual;
        private AvionController avionController;
        public frm_Aviones()
        {
            InitializeComponent();
            avionController = new AvionController();
        }

        public frm_Aviones(AvionModel avion) : this()
        {
            avionActual = avion;
            txt_modelo_avion.Text = avion.Modelo; // Cargar el modelo en el TextBox
        }

        private void btn_guardar_avion_Click(object sender, EventArgs e)
        {
            try
            {
                if (avionActual == null) // Nuevo avión
                {
                    AvionModel nuevoAvion = new AvionModel
                    {
                        Modelo = txt_modelo_avion.Text
                    };
                    avionController.AgregarAvion(nuevoAvion);
                    MessageBox.Show("Avión agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Editar avión existente
                {
                    avionActual.Modelo = txt_modelo_avion.Text;
                    avionController.ActualizarAvion(avionActual);
                    MessageBox.Show("Avión modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cerrar el formulario después de guardar
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el avión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
