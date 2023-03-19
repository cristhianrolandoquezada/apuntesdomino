using System;
using System.Collections.Generic;

namespace ApuntesDominoAPI.Models
{
    public partial class Tpatrocinadore
    {
        public byte Id { get; set; }
        public byte Idpatro { get; set; }
        public string Nombrepatro { get; set; } = null!;
        public string? Abreviapatro { get; set; }
        public string? Direccionpatro { get; set; }
        public string? Telefono1patro { get; set; }
        public string? Telefono2patro { get; set; }
    }
}
