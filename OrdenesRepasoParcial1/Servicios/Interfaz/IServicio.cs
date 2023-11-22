using OrdenesRepasoParcial1.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Servicios.Interfaz
{
    public interface IServicio
    {
        List<Material> ObtenerMateriales();
        DataTable ObtenerTabla(string nombreSp);
        int CrearOrdenRetiro(OrdenRetiro orden);
    }
}
