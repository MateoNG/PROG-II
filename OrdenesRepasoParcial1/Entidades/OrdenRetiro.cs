using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenesRepasoParcial1.Entidades
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> lDetalles { get; set; }
        public OrdenRetiro(int nroOrden, DateTime fecha, string responsable)
        {
            NroOrden = nroOrden;
            Fecha = fecha;
            Responsable = responsable;
            lDetalles = new List<DetalleOrden>();
        }

        public OrdenRetiro()
        {
            lDetalles = new List<DetalleOrden>();
        }

        public void AddDetallle(DetalleOrden detalle)
        {
            lDetalles.Add(detalle);
        }
        public void RemoveDetalle(int index)
        {
            lDetalles.RemoveAt(index);
        }
    }
}
