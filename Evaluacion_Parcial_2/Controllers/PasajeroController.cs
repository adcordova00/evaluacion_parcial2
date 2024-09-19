using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Evaluacion_Parcial_2.Models;
using Evaluacion_Parcial_2.Config;

namespace Evaluacion_Parcial_2.Controllers
{
    public class PasajeroController
    {
        // Método para obtener todos los pasajeros
        public List<PasajeroModel> ObtenerPasajeros()
        {
            List<PasajeroModel> pasajeros = new List<PasajeroModel>();
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "SELECT ID_Pasajero, Nombre, ID_Vuelo FROM Pasajeros";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PasajeroModel pasajero = new PasajeroModel
                    {
                        ID_Pasajero = Convert.ToInt32(reader["ID_Pasajero"]),
                        Nombre = reader["Nombre"].ToString(),
                        ID_Vuelo = Convert.ToInt32(reader["ID_Vuelo"])
                    };
                    pasajeros.Add(pasajero);
                }

                conn.Close();
            }
            return pasajeros;
        }

        // Método para agregar un nuevo pasajero
        public void AgregarPasajero(PasajeroModel pasajero)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "INSERT INTO Pasajeros (ID_Pasajero, Nombre, ID_Vuelo) VALUES (@ID, @Nombre, @ID_Vuelo)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", pasajero.ID_Pasajero);
                cmd.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@ID_Vuelo", pasajero.ID_Vuelo);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // Método para actualizar un pasajero existente
        public void ActualizarPasajero(PasajeroModel pasajero)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "UPDATE Pasajeros SET Nombre = @Nombre, ID_Vuelo = @ID_Vuelo WHERE ID_Pasajero = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", pasajero.ID_Pasajero);
                cmd.Parameters.AddWithValue("@Nombre", pasajero.Nombre);
                cmd.Parameters.AddWithValue("@ID_Vuelo", pasajero.ID_Vuelo);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EliminarPasajero(int id)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "DELETE FROM Pasajeros WHERE ID_Pasajero = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}