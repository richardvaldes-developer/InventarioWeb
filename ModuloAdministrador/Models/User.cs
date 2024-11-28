using System.ComponentModel.DataAnnotations;

namespace ModuloAdministrador.Models
{
    public class Users
    {
        [Key]
        public int IduserPK { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public string? TypeUser { get; set; }
    }
}
