using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MipequeniaTienda.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "El campo Codigo es obligatorio")]
        [StringLength(50)]
        public string Codigo { get; set; } = null!;
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(255)]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(255)]
        public string Modelo { get; set; } = null!;
        [Required(ErrorMessage = "El campo Description es obligatorio")]
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [Required(ErrorMessage = "El campo Precio es obligatorio")]
        public string Precio { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(255)]
        public string Imagen { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; } = null!;
        [Required(ErrorMessage = "El campo Stock es obligatorio")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        [StringLength(100)]
        public string Marca { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        public bool Activo { get; set; }
        public ICollection<Detalle_Pedido> DetallesPedido { get; set; }=null!;

    }
}
