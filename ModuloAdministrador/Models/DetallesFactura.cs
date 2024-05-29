using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class DetallesFactura
    {
        public int IdFacturasDetallePk { get; set; }
        public int IdFacturasFk { get; set; }

        public virtual Factura IdFacturasFkNavigation { get; set; } = null!;
    }
}
