using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModuloAdministrador.Models
{
    public class Product
    {
        [Key]
        public int ID_Product { get; set; }

        [Required]
        [StringLength(100)]
        public string NameProduct { get; set; }

        [Required]
        [StringLength(255)]
        public string DescriptionProduct { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string? ImageUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        // Relación con la tabla Proveedores
        [ForeignKey("ID_Supplier")]
        public int ID_Supplier { get; set; }
    }
}
