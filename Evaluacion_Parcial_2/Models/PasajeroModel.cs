namespace Evaluacion_Parcial_2.Models
{
    public class PasajeroModel
    {
        public int ID_Pasajero { get; set; }
        public string Nombre { get; set; }
        public int ID_Vuelo { get; set; }

        public PasajeroModel() { }

        public PasajeroModel(int id, string nombre, int idVuelo)
        {
            ID_Pasajero = id;
            Nombre = nombre;
            ID_Vuelo = idVuelo;
        }
    }
}