using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Proveedore
    {
        public Proveedore()
        {
            ProductosProveedors = new HashSet<ProductosProveedor>();
        }

        public int IdProveedorPk { get; set; }
        public string RutProveedor { get; set; } = null!;
        public DateTime? FechaCreacion { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string GiroProvedor { get; set; } = null!;
        public string TelefonoProveedor { get; set; } = null!;
        public string DireccionProveedor { get; set; } = null!;
        public string EmailProveedor { get; set; } = null!;

        public virtual ICollection<ProductosProveedor> ProductosProveedors { get; set; }
    }
}
