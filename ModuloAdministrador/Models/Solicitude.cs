using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Solicitude
    {
        public int IdSolicitudPk { get; set; }
        public string TipoSolicitud { get; set; } = null!;
        public DateTime FechaSolicitud { get; set; }
        public bool EstadoAprobacion { get; set; }
        public int Cantidad { get; set; }
        public int IdProductoFk { get; set; }
        public int IdTrabajadorFk { get; set; }
        public int IdUsuarioFk { get; set; }

        public virtual Producto IdProductoFkNavigation { get; set; } = null!;
        public virtual Trabajadore IdTrabajadorFkNavigation { get; set; } = null!;
        public virtual Usuario IdUsuarioFkNavigation { get; set; } = null!;
    }
}
