namespace PROGII_1w1_1er_API.Models
{
    public class Temperatura_4_3
    {

        public int IOT { get; set; }
        public DateTime FechaHora { get; set; }
        public float Valor { get; set; }

        public Temperatura_4_3() 
        {
            IOT = 0;
            FechaHora = DateTime.Now;
            Valor = 0;
        }
        public Temperatura_4_3(int iot, DateTime fechaHora, float valor)
        {
            IOT = 0;
            FechaHora = DateTime.Now;
            Valor = 0;
        }
    }
}
