using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MipequeniaTienda.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        [Required(ErrorMessage = "El campo Address es obligatorio")]
        [StringLength(50)]
        public string Address { get; set; } = null!;
        [Required(ErrorMessage = "El campo Ciudad es obligatorio")]
        [StringLength(20)]
        public string Ciudad { get; set; } = null!;
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        [StringLength(20)]
        public string Estado { get; set; } = null!;
        [Required(ErrorMessage = "El campo CodigoPostal es obligatorio")]
        public string CodigoPostal { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }=null!;
    }
}
