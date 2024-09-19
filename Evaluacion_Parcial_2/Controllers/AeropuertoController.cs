using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Evaluacion_Parcial_2.Models;
using Evaluacion_Parcial_2.Config;


namespace Evaluacion_Parcial_2.Controllers
{
    public class AeropuertoController
    {
        public List<AeropuertoModel> ObtenerAeropuertos()
        {
            List<AeropuertoModel> aeropuertos = new List<AeropuertoModel>();
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "SELECT ID_Aeropuerto, Ciudad, Pais FROM Aeropuertos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    AeropuertoModel aeropuerto = new AeropuertoModel
                    {
                        ID_Aeropuerto = Convert.ToInt32(reader["ID_Aeropuerto"]),
                        Ciudad = reader["Ciudad"].ToString(),
                        Pais = reader["Pais"].ToString()
                    };
                    aeropuertos.Add(aeropuerto);
                }

                conn.Close();
            }
            return aeropuertos;
        }

        // Método para agregar un nuevo aeropuerto
        public void AgregarAeropuerto(AeropuertoModel aeropuerto)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "INSERT INTO Aeropuertos (Ciudad, Pais) VALUES (@Ciudad, @Pais)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ciudad", aeropuerto.Ciudad);
                cmd.Parameters.AddWithValue("@Pais", aeropuerto.Pais);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar el aeropuerto: " + ex.Message);
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

        public void ActualizarAeropuerto(AeropuertoModel aeropuerto)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "UPDATE Aeropuertos SET Ciudad = @Ciudad, Pais = @Pais WHERE ID_Aeropuerto = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", aeropuerto.ID_Aeropuerto);
                cmd.Parameters.AddWithValue("@Ciudad", aeropuerto.Ciudad);
                cmd.Parameters.AddWithValue("@Pais", aeropuerto.Pais);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // Método para eliminar un aeropuerto
        public void EliminarAeropuerto(int id)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "DELETE FROM Aeropuertos WHERE ID_Aeropuerto = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}