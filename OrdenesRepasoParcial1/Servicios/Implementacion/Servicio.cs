using OrdenesRepasoParcial1.Datos.Implementacion;
using OrdenesRepasoParcial1.Datos.Interfaz;
using OrdenesRepasoParcial1.Entidades;
using OrdenesRepasoParcial1.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Servicios.Implementacion
{
    public class Servicio : IServicio
    {
        private IOrdenRetiroDAO dao;
        public Servicio()
        {
            dao = new OrdenRetiroDAO();
        }

        public int CrearOrdenRetiro(OrdenRetiro orden)
        {
            return dao.Crear(orden);
        }

        public DataTable ObtenerTabla(string nombreSp)
        {
            return dao.ObtenerTabla(nombreSp);
        }

        public List<Material> ObtenerMateriales()
        {
            return dao.ObtenerMateriales();
        }
    }
}
