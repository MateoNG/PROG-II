using OrdenesRepasoParcial1.Datos.Interfaz;
using OrdenesRepasoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Datos.Implementacion
{
    public class OrdenRetiroDAO : IOrdenRetiroDAO
    {
        public DataTable ObtenerTabla(string nombreSp)
        {
            return HelperDAO.ObtenerInstancia().ConsultarSP(nombreSp);
        }

        public List<Material> ObtenerMateriales()
        {
            List<Material> list = new List<Material>();

            DataTable tabla = HelperDAO.ObtenerInstancia().ConsultarSP("SP_CONSULTAR_MATERIALES");
            foreach (DataRow fila in tabla.Rows)
            {
                int cod = Convert.ToInt32(fila["codigo"]);
                string nom = fila["nombre"].ToString();
                int stock = Convert.ToInt32(fila["stock"]);
                Material m = new Material(cod, nom, stock);
                list.Add(m);
            }

            return list;
        }

        public int Crear(OrdenRetiro orden)
        {
            int ordenNro = 0;
            SqlConnection cnn = HelperDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdMaestro = new SqlCommand("SP_INSERTAR_ORDEN", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@responsable", orden.Responsable);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@nro";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;
                cmdMaestro.Parameters.Add(param);

                cmdMaestro.ExecuteNonQuery();

                ordenNro = Convert.ToInt32(param.Value);
                int detalleNro = 1;

                SqlCommand cmdDetalle;
                foreach (DetalleOrden d in orden.lDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", ordenNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@codigo", d.Material.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", d.Cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ordenNro;
        }
        //extra (update)
        public bool ModificarPresupuesto(OrdenRetiro orden)
        {
            bool ok = true;
            int ordenNro = 0;
            SqlConnection cnn = HelperDAO.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmdMaestro = new SqlCommand("SP_MODIFICAR_MAESTRO", cnn, t);
                cmdMaestro.CommandType = CommandType.StoredProcedure;
                cmdMaestro.Parameters.AddWithValue("@responsable", orden.Responsable);
                cmdMaestro.Parameters.AddWithValue("@nro_orden", orden.Responsable);
                cmdMaestro.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleOrden detalle in orden.lDetalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", ordenNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@codigo", detalle.Material.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                t.Commit();
            }

            catch
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }
    }
}
