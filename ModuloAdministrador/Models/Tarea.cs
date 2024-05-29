using System;
using System.Collections.Generic;

namespace ModuloAdministrador.Models
{
    public partial class Tarea
    {
        public int IdTareasPk { get; set; }
        public string TipoTarea { get; set; } = null!;
        public bool? EstadoTarea { get; set; }
        public string Prioridad { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaFinalizacion { get; set; }
        public int? IdUsuarioFk { get; set; }
        public int? IdTrabajadorFk { get; set; }

        public virtual Usuario? IdUsuarioFk1 { get; set; }
        public virtual Trabajadore? IdUsuarioFkNavigation { get; set; }
    }
}
