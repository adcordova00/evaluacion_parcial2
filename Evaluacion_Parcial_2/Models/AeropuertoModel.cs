using System;

namespace Evaluacion_Parcial_2.Models
{
    public class AeropuertoModel
    {
        public int ID_Aeropuerto { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public override string ToString()
        {
            return $"{ID_Aeropuerto} - {Ciudad}, {Pais}";
        }

        public AeropuertoModel() { }

        public AeropuertoModel(int id, string ciudad, string pais)
        {
            ID_Aeropuerto = id;
            Ciudad = ciudad;
            Pais = pais;
        }
    }
}