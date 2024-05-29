using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Producto
    {
        public Producto()
        {
            ProductosProveedors = new HashSet<ProductosProveedor>();
            Solicitudes = new HashSet<Solicitude>();
        }

        public int IdProductoPk { get; set; }
        public string NombreProducto { get; set; } = null!;
        public string GramajeProducto { get; set; } = null!;
        public int StockProducto { get; set; }

        public virtual ICollection<ProductosProveedor> ProductosProveedors { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
    }
}
