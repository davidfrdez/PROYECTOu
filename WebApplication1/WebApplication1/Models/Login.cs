using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Login
    {
        public int IdLogin { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
    }
}
