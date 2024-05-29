using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class DetallesGuia
    {
        public int IdGuiaDetalle { get; set; }
        public int IdGuiaFk { get; set; }

        public virtual Guia IdGuiaFkNavigation { get; set; } = null!;
    }
}
