using System;
using System.Collections.Generic;

#nullable disable

namespace drsecurityApi.Models.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
            Tarjeta = new HashSet<Tarjeta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<Tarjeta> Tarjeta { get; set; }
    }
}
