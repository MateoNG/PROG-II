namespace PROGII_1w1_1er_API.Models
{
    public class Fecha // act. 4.1
    {
        //La URI es la fecha / los objetos van entre llaves
        public int Dia { get; set; }
        public int Mes { get; set;}
        public int Anio { get; set; }
        public string DiaSemana { get; set; }

        public Fecha()
        {
            Dia = DateTime.Today.Day;
            Mes = DateTime.Today.Month;
            Anio = DateTime.Today.Year;
            DiaSemana = DateTime.Today.DayOfWeek.ToString();
        }
    }
}
