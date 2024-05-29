using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Solicitudes = new HashSet<Solicitude>();
            Tareas = new HashSet<Tarea>();
            Trabajadores = new HashSet<Trabajadore>();
        }

        public int IdUsuarioPk { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public string ContraseniaUsuario { get; set; } = null!;
        public string TipoUsuario { get; set; } = null!;

        public virtual ICollection<Solicitude> Solicitudes { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
        public virtual ICollection<Trabajadore> Trabajadores { get; set; }
    }
}
