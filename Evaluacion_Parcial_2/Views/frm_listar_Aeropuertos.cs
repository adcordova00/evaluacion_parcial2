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
    public partial class frm_listar_Aeropuertos : Form
    {
        public frm_listar_Aeropuertos()
        {
            InitializeComponent();
        }

        AeropuertoController aeropuertoController = new AeropuertoController();

        private void CargarListaAeropuertos()
        {
            lst_aeropuertos.Items.Clear();
            var aeropuertos = aeropuertoController.ObtenerAeropuertos();

            foreach (var aeropuerto in aeropuertos)
            {
                lst_aeropuertos.Items.Add(aeropuerto);
            }
        }

        private void frm_listar_Aeropuertos_Load(object sender, EventArgs e)
        {
            CargarListaAeropuertos();
        }

        private void btn_eliminar_aeropuerto_Click(object sender, EventArgs e)
        {
            if (lst_aeropuertos.SelectedItem != null)
            {

                string selectedItem = lst_aeropuertos.SelectedItem.ToString();
                int idAeropuerto = int.Parse(selectedItem.Split('-')[0].Trim());

                try
                {
                    aeropuertoController.EliminarAeropuerto(idAeropuerto);
                    MessageBox.Show("Aeropuerto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaAeropuertos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Aeropuerto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Aeropuerto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_modificar_aeropuerto_Click(object sender, EventArgs e)
        {
            if (lst_aeropuertos.SelectedItem != null)
            {
                AeropuertoModel aeropuertoSeleccionado = lst_aeropuertos.SelectedItem as AeropuertoModel;

                if (aeropuertoSeleccionado != null)
                {
                    frm_Aeropuertos formEditarAeropuerto = new frm_Aeropuertos(aeropuertoSeleccionado);
                    formEditarAeropuerto.ShowDialog();

                    CargarListaAeropuertos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un aeropuerto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
