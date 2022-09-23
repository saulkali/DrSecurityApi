using System;
using System.Collections.Generic;

#nullable disable

namespace drsecurityApi.Models.Entities
{
    public partial class UsuarioBaja
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }
}
