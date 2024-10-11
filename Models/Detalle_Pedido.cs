﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MipequeniaTienda.Models
{
    public class Detalle_Pedido
    {
        [Key]
        public int DetallePedido { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int PedidoId { get; set; }
        [ForeignKey("PedidoId")]
        public Pedido Pedido { get; set; } = null!;
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int ProductoId {  get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; } = null!;
        [Required(ErrorMessage = "El campo Cantidad es obligatorio")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo Precio es obligatorio")]
        public decimal Precio { get; set; }

    }
}
