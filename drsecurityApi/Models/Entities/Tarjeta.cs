using System;
using System.Collections.Generic;

#nullable disable

namespace drsecurityApi.Models.Entities
{
    public partial class Tarjeta
    {
        public int Id { get; set; }
        public string NoTarjeta { get; set; }
        public string Fecha { get; set; }
        public string Ccv { get; set; }
        public string NombreTitular { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
