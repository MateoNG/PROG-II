using Gallo_404947_ProgII_Banco.Cuenta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallo_404947_ProgII_Banco.Dominios
{
    internal class AccesoBD
    {
        string cadenaMiCasa = @"Data Source=DESKTOP-TGCA48H\SQLEXPRESS02;Initial Catalog=PROGII_1.3_Banco_v2;Integrated Security=True";
        SqlConnection conexion;
        SqlCommand comando;

        public AccesoBD()
        {
            conexion = new SqlConnection(cadenaMiCasa);
            comando = new SqlCommand();
        }

        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        public DataTable ConsultarBD(string SP)
        {
            DataTable tabla = new DataTable();

            Conectar();
            comando.CommandText = SP;
            tabla.Load(comando.ExecuteReader());
            Desconectar();

            return tabla;
        }

        public DataTable ConsultarBD(string SP, List<Parametro> lParametro)
        {
            DataTable tabla = new DataTable();

            Conectar();
            comando.CommandText = SP;

            foreach (Parametro p in lParametro)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }
            tabla.Load(comando.ExecuteReader());
            Desconectar();

            return tabla;
        }

        public int ActualizarBD(string SP)
        {
            int filasAfectadas;

            Conectar();

            comando.CommandText = SP;
            filasAfectadas = comando.ExecuteNonQuery();

            Desconectar();

            return filasAfectadas;
        }

        public int ActualizarBD(string SP, List<Parametro> lParametro)
        {
            int filasAfectadas;

            Conectar();

            comando.CommandText = SP;

            foreach (Parametro p in lParametro)
            {
                comando.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            filasAfectadas = comando.ExecuteNonQuery();

            Desconectar();

            return filasAfectadas;
        }

        public bool ConfirmarConfigurarperfil(Cliente c)
        {
            bool resultado = true;

            SqlTransaction t = null;
            try
            {
                conexion.Open();
                t = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_UPDATE_CLIENTE";
                comando.Parameters.AddWithValue("@id", c.CodCliente);
                comando.Parameters.AddWithValue("@nombre", c.Nombre);
                comando.Parameters.AddWithValue("@apellido", c.Apellido);
                comando.Parameters.AddWithValue("@dni", c.DNI);

                comando.ExecuteNonQuery();

                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

        public bool ConfirmarCrearCuenta(CuentaBanco c)
        {
            bool resultado = true;

            SqlTransaction t2 = null;
            try
            {
                conexion.Open();
                t2 = conexion.BeginTransaction();
                SqlCommand comando2 = new SqlCommand();
                comando2.Connection = conexion;
                comando2.Transaction = t2;
                comando2.CommandType = CommandType.StoredProcedure;
                comando2.CommandText = "SP_INSERT_CUENTA";
                comando2.Parameters.AddWithValue("@cbu", c.CBU);
                comando2.Parameters.AddWithValue("@saldo", c.Saldo);
                comando2.Parameters.AddWithValue("@codCliente", c.CodCliente);
                comando2.Parameters.AddWithValue("@tipoCuenta", c.TipoCuenta);
                comando2.Parameters.AddWithValue("@ultMovimiento", c.UltimoMovimiento);

                comando2.ExecuteNonQuery();

                t2.Commit();
            }
            catch
            {
                if (t2 != null)
                    t2.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }

        public bool ConfirmarCrearNuevoPerfil(Cliente c)
        {
            bool resultado = true;

            SqlTransaction t3 = null;
            try
            {
                conexion.Open();
                t3 = conexion.BeginTransaction();
                SqlCommand comando3 = new SqlCommand();
                comando3.Connection = conexion;
                comando3.Transaction = t3;
                comando3.CommandType = CommandType.StoredProcedure;
                comando3.CommandText = "SP_INSERT_CLIENTE";
                comando3.Parameters.AddWithValue("@nombre", c.Nombre);
                comando3.Parameters.AddWithValue("@apellido", c.Apellido);
                comando3.Parameters.AddWithValue("@dni", c.DNI);

                comando3.ExecuteNonQuery();

                t3.Commit();
            }
            catch
            {
                if (t3 != null)
                    t3.Rollback();
                resultado = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return resultado;
        }
    }
}
