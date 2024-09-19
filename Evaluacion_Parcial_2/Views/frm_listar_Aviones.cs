using Evaluacion_Parcial_2.Controllers;
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
using Evaluacion_Parcial_2.Views;

namespace Evaluacion_Parcial_2.Views
{
    public partial class frm_listar_Aviones : Form
    {
        public frm_listar_Aviones()
        {
            InitializeComponent();
        }

        AvionController avionController = new AvionController();

        private void CargarListaAviones()
        {
            lst_aviones.Items.Clear(); 
            var aviones = avionController.ObtenerAviones();

            foreach (var avion in aviones)
            {
                lst_aviones.Items.Add(avion);
            }
        }

        private void frm_listar_Aviones_Load(object sender, EventArgs e)
        {
            CargarListaAviones();
        }

        private void btn_eliminar_avion_Click(object sender, EventArgs e)
        {
            if (lst_aviones.SelectedItem != null)
            {

                string selectedItem = lst_aviones.SelectedItem.ToString();
                int idAvion = int.Parse(selectedItem.Split('-')[0].Trim());

                try
                {
                    avionController.EliminarAvion(idAvion);
                    MessageBox.Show("Avión eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarListaAviones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el avión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un avión para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_modificar_avion_Click(object sender, EventArgs e)
        {
            if (lst_aviones.SelectedItem != null)
            {
                // Obtener el avión seleccionado como objeto AvionModel
                AvionModel avionSeleccionado = lst_aviones.SelectedItem as AvionModel;

                if (avionSeleccionado != null)
                {
                    // Abrir el formulario de edición y pasar el avión seleccionado
                    frm_Aviones formEditarAvion = new frm_Aviones(avionSeleccionado);
                    formEditarAvion.ShowDialog();

                    // Recargar la lista de aviones después de cerrar el formulario de edición
                    CargarListaAviones();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un avión para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
