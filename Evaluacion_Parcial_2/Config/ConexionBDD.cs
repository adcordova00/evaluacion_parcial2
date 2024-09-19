using System;
using System.Data.SqlClient;

namespace Evaluacion_Parcial_2.Config
{
    class ConexionBDD
    {
        private static readonly string connectionString;

        static ConexionBDD()
        {
            connectionString = "Server=DESKTOP-KA0EPGU\\SQLEXPRESS;Database=aerolineas;User Id=sa;Password=1234;";
        }

        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(connectionString); // Retorna la conexión sin abrirla
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
                throw;
            }
        }
    }
}
