using System;
using System.Collections.Generic;

namespace ApuntesDominoAPI.Models
{
    public partial class Timagene
    {
        public byte Id { get; set; }
        public string Imgnomimagevid { get; set; } = null!;
        public string Imgcomentcorto { get; set; } = null!;
        public string? Imgcomentlargo { get; set; }
        public string Imgtipo { get; set; } = null!;
        public byte? Idpatro { get; set; }
        public byte? Idtema { get; set; }
        public string? Imgruta { get; set; }
    }
}
