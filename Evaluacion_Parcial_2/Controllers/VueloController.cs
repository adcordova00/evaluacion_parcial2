using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Evaluacion_Parcial_2.Models;
using Evaluacion_Parcial_2.Config;

namespace Evaluacion_Parcial_2.Controllers
{
    public class VueloController
    {
        // Método para obtener todos los vuelos
        public List<VueloModel> ObtenerVuelos()
        {
            List<VueloModel> vuelos = new List<VueloModel>();
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "SELECT ID_Vuelo, ID_Aeropuerto_Origen, ID_Aeropuerto_Destino, ID_Avion, Fecha FROM Vuelos";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    VueloModel vuelo = new VueloModel
                    {
                        ID_Vuelo = Convert.ToInt32(reader["ID_Vuelo"]),
                        ID_Aeropuerto_Origen = Convert.ToInt32(reader["ID_Aeropuerto_Origen"]),
                        ID_Aeropuerto_Destino = Convert.ToInt32(reader["ID_Aeropuerto_Destino"]),
                        ID_Avion = Convert.ToInt32(reader["ID_Avion"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    vuelos.Add(vuelo);
                }

                conn.Close();
            }
            return vuelos;
        }

        // Método para agregar un nuevo vuelo
        public void AgregarVuelo(VueloModel vuelo)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "INSERT INTO Vuelos (ID_Aeropuerto_Origen, ID_Aeropuerto_Destino, ID_Avion, Fecha) " +
                               "VALUES (@Origen, @Destino, @Avion, @Fecha)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Origen", vuelo.ID_Aeropuerto_Origen);
                cmd.Parameters.AddWithValue("@Destino", vuelo.ID_Aeropuerto_Destino);
                cmd.Parameters.AddWithValue("@Avion", vuelo.ID_Avion);
                cmd.Parameters.AddWithValue("@Fecha", vuelo.Fecha);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        // Método para actualizar un vuelo existente
        public void ActualizarVuelo(VueloModel vuelo)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "UPDATE Vuelos SET ID_Aeropuerto_Origen = @Origen, ID_Aeropuerto_Destino = @Destino, " +
                               "ID_Avion = @Avion, Fecha = @Fecha WHERE ID_Vuelo = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", vuelo.ID_Vuelo);
                cmd.Parameters.AddWithValue("@Origen", vuelo.ID_Aeropuerto_Origen);
                cmd.Parameters.AddWithValue("@Destino", vuelo.ID_Aeropuerto_Destino);
                cmd.Parameters.AddWithValue("@Avion", vuelo.ID_Avion);
                cmd.Parameters.AddWithValue("@Fecha", vuelo.Fecha);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void EliminarVuelo(int id)
        {
            using (SqlConnection conn = ConexionBDD.GetConnection())
            {
                string query = "DELETE FROM Vuelos WHERE ID_Vuelo = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
