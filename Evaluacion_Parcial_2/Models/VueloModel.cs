using System;

namespace Evaluacion_Parcial_2.Models
{
    public class VueloModel
    {
        public int ID_Vuelo { get; set; }
        public int ID_Aeropuerto_Origen { get; set; }
        public int ID_Aeropuerto_Destino { get; set; }
        public int ID_Avion { get; set; }
        public DateTime Fecha { get; set; }

        public VueloModel() { }

        public VueloModel(int idVuelo, int idAeropuertoOrigen, int idAeropuertoDestino, int idAvion, DateTime fecha)
        {
            ID_Vuelo = idVuelo;
            ID_Aeropuerto_Origen = idAeropuertoOrigen;
            ID_Aeropuerto_Destino = idAeropuertoDestino;
            ID_Avion = idAvion;
            Fecha = fecha;
        }
    }
}
