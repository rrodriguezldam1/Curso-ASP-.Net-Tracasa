using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_MVC_EF_ASPCore.Models
{
    public class TeacherContext : DbContext
    {
        public TeacherContext(DbContextOptions<TeacherContext> options) : base (options) 
        { 
        }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                Console.WriteLine("La bbdd NO ha sido configurada");
            }
            else
            {
                Console.WriteLine("La bbdd SÍ ha sido configurada");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Teacher>(
                entity =>
                {
                    entity.Property(e => e.Name)
                          .IsRequired()
                          .HasMaxLength(50)
                          .IsUnicode(false);

                    entity.Property(e => e.Skills)
                          .IsRequired()
                          .HasMaxLength(100)
                          .IsUnicode(false);
                });
        }
    }
}
