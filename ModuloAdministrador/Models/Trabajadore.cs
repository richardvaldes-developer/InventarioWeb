using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Trabajadore
    {
        public Trabajadore()
        {
            Solicitudes = new HashSet<Solicitude>();
            Tareas = new HashSet<Tarea>();
        }

        public int IdTrabajadorPk { get; set; }
        public string Nombre { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public int? IdUsuarioFk { get; set; }

        public virtual Usuario? IdUsuarioFkNavigation { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
