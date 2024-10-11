using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MipequeniaTienda.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Pedidos=new List<Pedido>();
        }
        [Key]
        public int UsuarioId { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        [StringLength(15)]
        public string Telefono { get; set; }=null!;
        [Required(ErrorMessage = "El campo NombreUsuario es obligatorio")]
        [StringLength(50)]
        public string NombreUsuario { get; set; } = null!;
        [Required(ErrorMessage = "El campo Contrasenia es obligatorio")]
        [StringLength(255)]
        public string Contrasenia { get; set; } = null!;
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        [StringLength(255)]
        public string Correo { get; set; } = null!;
        [Required(ErrorMessage = "El campo Direccion es obligatorio")]
        [StringLength(100)]
        public string Direccion {  get; set; } = null!;
        [Required(ErrorMessage = "El campo Ciudad es obligatorio")]
        [StringLength(20)]
        public string Ciudad { get; set; } = null!;
        [Required(ErrorMessage = "El campo Estado es obligatorio")]
        [StringLength(20)]
        public string Estado {  get; set; } = null!;
        [Required(ErrorMessage = "El campo CodigoPostal es obligatorio")]
        public string CodigoPostal { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int RolId { get; set; }
        [ForeignKey("RolId")]
        public Rol Rol { get; set; } = null!;
        public ICollection<Pedido> Pedidos {  get; set; }
        [InverseProperty("Usuario")]
        public ICollection<Direccion> Direcciones { get; set; } = null!;
    }
}
