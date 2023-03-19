using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApuntesDominoAPI.Models
{
    public partial class Ttema
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string Temnombre { get; set; } = null!;
        [MaxLength(2)]
        public string? Defecto { get; set; }
    }
}
