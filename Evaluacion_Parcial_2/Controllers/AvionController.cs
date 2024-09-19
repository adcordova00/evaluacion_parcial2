using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Evaluacion_Parcial_2.Models;
using Evaluacion_Parcial_2.Config;

namespace Evaluacion_Parcial_2.Controllers
{
    public class AvionController
    {
        // Método para obtener todos los aviones
        public List<AvionModel> ObtenerAviones()
        {
            List<AvionModel> aviones = new List<AvionModel>();
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "SELECT ID_Avion, Modelo FROM Aviones";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AvionModel avion = new AvionModel
                    {
                        ID_Avion = Convert.ToInt32(reader["ID_Avion"]),
                        Modelo = reader["Modelo"].ToString()
                    };
                    aviones.Add(avion);
                }

                conn.Close();
            }
            return aviones;
        }

        // Método para agregar un nuevo avión
        public void AgregarAvion(AvionModel avion)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "INSERT INTO Aviones (Modelo) VALUES (@Modelo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);

                try
                {
                    conn.Open(); 
                    cmd.ExecuteNonQuery(); 
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el avión: " + ex.Message);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void ActualizarAvion(AvionModel avion)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "UPDATE Aviones SET Modelo = @Modelo WHERE ID_Avion = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", avion.ID_Avion);
                cmd.Parameters.AddWithValue("@Modelo", avion.Modelo);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el avión: " + ex.Message);
                }
                finally
                {
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        // Método para eliminar un avión
        public void EliminarAvion(int id)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "DELETE FROM Aviones WHERE ID_Avion = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
