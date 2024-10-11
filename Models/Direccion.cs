﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MipequeniaTienda.Models
{
    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; } = null!;
        [Required]
        [StringLength(20)]
        public string Ciudad { get; set; } = null!;
        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = null!;
        [Required]
        public string CodigoPostal { get; set; } = null!;
        [Required]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }=null!;
    }
}
