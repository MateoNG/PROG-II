namespace PROGII_1w1_1er_API.Models
{
    public class Producto // act. 4.4
    {
        public Producto(int codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }
        public Producto()
        {
            Codigo = 0;
            Nombre = string.Empty;
            Precio = 0;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }


    }
}
