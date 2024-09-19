namespace Evaluacion_Parcial_2.Models
{
    public class AvionModel
    {
        public int ID_Avion { get; set; }
        public string Modelo { get; set; }

        public override string ToString()
        {
            return $"{ID_Avion} - {Modelo}";
        }

        public AvionModel() { }

        public AvionModel(int id, string modelo)
        {
            ID_Avion = id;
            Modelo = modelo;
        }
    }
}
