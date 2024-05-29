using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Guia
    {
        public Guia()
        {
            DetallesGuia = new HashSet<DetallesGuia>();
        }

        public int IdGuiaPk { get; set; }
        public DateTime FechaGuia { get; set; }
        public int NumeroGuia { get; set; }
        public string NombreEmpresaOrigen { get; set; } = null!;
        public string DireccionEmpresaOrigen { get; set; } = null!;
        public string TelefonoEmpresaOrigen { get; set; } = null!;
        public string DireccionDestino { get; set; } = null!;
        public string NombreEmpresaDestino { get; set; } = null!;
        public string TelefonoEmpresaDestino { get; set; } = null!;

        public virtual ICollection<DetallesGuia> DetallesGuia { get; set; }
    }
}
