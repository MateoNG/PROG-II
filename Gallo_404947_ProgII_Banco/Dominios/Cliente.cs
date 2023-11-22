using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallo_404947_ProgII_Banco.Dominios
{
    internal class Cliente
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Int64 DNI { get; set; }

        public Cliente()
        {
            CodCliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            DNI = 0;
        }

        public Cliente(int codCliente, string nombre, string apellido, Int64 dni)
        {
            CodCliente = codCliente;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public bool DniUnico()
        {
            bool dniUnico = true;

            string SP = "SP_CONSULTAR_CLIENTE";

            List<Parametro> lParametros = new List<Parametro>();
            lParametros.Clear();
            lParametros.Add(new Parametro("@dni", DNI));

            DataTable tabla = new AccesoBD().ConsultarBD(SP, lParametros);
            foreach (DataRow fila in tabla.Rows)
            {
                Cliente c2 = new Cliente();
                c2.DNI = Convert.ToInt64(fila[3]);

                if (DNI == c2.DNI)
                {
                    dniUnico = false;
                    return dniUnico;
                }
            }
            return dniUnico;
        }
        public override string ToString()
        {
            return Convert.ToString(DNI)+" - "+Apellido+", "+ Nombre;
        }
    }
}
