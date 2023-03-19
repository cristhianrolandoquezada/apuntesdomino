using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApuntesDominoAPI.Models
{
    public partial class apuntesdominodbContext : DbContext
    {

    
        public apuntesdominodbContext(DbContextOptions<apuntesdominodbContext> options)
        : base(options)
        {
        }

        // Estas son las tablas 
        public virtual DbSet<Tfondo> Tfondos { get; set; } = null!;
        public virtual DbSet<Timagene> Timagenes { get; set; } = null!;
        public virtual DbSet<Tpatrocinadore> Tpatrocinadores { get; set; } = null!;
        public virtual DbSet<Ttema> Ttemas { get; set; } = null!;

    }

}
