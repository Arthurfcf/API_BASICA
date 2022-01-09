using API_1.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_1.Context
{
    public class Banco1Context : DbContext
    {
    
        public DbSet<Participation> Participations { get; set; }
        public DbSet<Users> users { get; set; }
        public Banco1Context(DbContextOptions<Banco1Context> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Participation>().HasKey(x => new { x.Id });
            builder.Entity<Users>().HasKey(x => new { x.Id });
            builder.Entity<Participation>()
                .Property(v => v.Value)
                .IsRequired()
                .HasPrecision(10, 2);
            builder.Entity<Participation>()
                .Property(n => n.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Entity<Participation>()
                .Property(n => n.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Entity<Participation>()
                .HasData(
                new Participation { Id = 1, FirstName = "Leonardo", LastName = "Costa", Value = 85 },
                new Participation { Id = 2, FirstName = "Arthur", LastName = "Ferreira", Value = 80 });
        }

       
    }
}
