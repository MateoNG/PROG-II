using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Datos
{
    public class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlConnection conexion;
        private HelperDAO()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }
        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }
        
        public DataTable ConsultarSP(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(nombreSP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

    }
}
