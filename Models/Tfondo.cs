using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApuntesDominoAPI.Models
{
    public partial class Tfondo
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string Fonnombre { get; set; } = null!;
        [MaxLength(2)]
        public string? Defecto { get; set; }
        public string Fonruta { get; set; } = null!;
        public string Fonpie { get; set; } = null!;
    }
}
