using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class ProductosProveedor
    {
        public int IdProductoProveedorPk { get; set; }
        public int? Precio { get; set; }
        public int IdProductoFk { get; set; }
        public int IdProveedorFk { get; set; }

        public virtual Producto IdProductoFkNavigation { get; set; } = null!;
        public virtual Proveedore IdProveedorFkNavigation { get; set; } = null!;
    }
}
