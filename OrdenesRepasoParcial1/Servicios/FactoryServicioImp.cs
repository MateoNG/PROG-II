using OrdenesRepasoParcial1.Servicios.Implementacion;
using OrdenesRepasoParcial1.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Servicios
{
    public class FactoryServicioImp : FactoryServicio
    {
        public override IServicio ObtenerServicio()
        {
            return new Servicio();
        }
    }
}
