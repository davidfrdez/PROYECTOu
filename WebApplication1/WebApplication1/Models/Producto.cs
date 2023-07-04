using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public string? Cantidad { get; set; }
        public string? Proveedor { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
