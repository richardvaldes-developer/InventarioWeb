using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Factura
    {
        public Factura()
        {
            DetallesFacturas = new HashSet<DetallesFactura>();
        }

        public int IdFacturasPk { get; set; }
        public DateTime FechaFactura { get; set; }
        public string NumeroFactura { get; set; } = null!;
        public string NombreEmpresaOrigen { get; set; } = null!;
        public string DireccionEmpresaOrigen { get; set; } = null!;
        public string TelefonoEmpresaOrigen { get; set; } = null!;
        public string DireccionDestino { get; set; } = null!;
        public string NombreEmpresaDestino { get; set; } = null!;
        public string TelefonoEmpresaDestino { get; set; } = null!;

        public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; }
    }
}
