namespace PROGII_1w1_1er_API.Models
{
    public class RegistroTemp_4_3
    {
        private RegistroTemp_4_3()
        {
            this.lTemperaturas = new List<Temperatura_4_3>();
        }

        private static RegistroTemp_4_3 instancia;
        public static RegistroTemp_4_3 ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new RegistroTemp_4_3();
            }
            return instancia;
        }
        public List<Temperatura_4_3> lTemperaturas { get; set; }

        public void AgregarTemp(Temperatura_4_3 t)
        {
            lTemperaturas.Add(t);
        }

        public void QuitarTemp(int pos)
        {
            lTemperaturas.RemoveAt(pos);
        }
    }
}
