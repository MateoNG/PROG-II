using OrdenesRepasoParcial1.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Servicios
{
    public abstract class FactoryServicio
    {
        public abstract IServicio ObtenerServicio();
    }
}
