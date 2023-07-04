using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Proveedor
    {
        public int IdProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Documento { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Web { get; set; }
    }
}
