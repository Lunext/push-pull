using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Push_Pull_Program.Models;

namespace Push_Pull_Program.Data
{
    public class Push_Pull_ProgramContext : DbContext
    {
        public Push_Pull_ProgramContext (DbContextOptions<Push_Pull_ProgramContext> options)
            : base(options)
        {
        }

        public DbSet<Push_Pull_Program.Models.Reporte> Reporte { get; set; }
        public DbSet<Push_Pull_Program.Models.Empleado> Empleado { get; set; }
        public DbSet<Push_Pull_Program.Models.EmpleadoReporte> EmpleadoReporte { get; set; }


        protected override void OnModelCreating(
        ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>()
                .Ignore(empleado => empleado.Nacimiento_Fecha); 
                
            

        }
    }
}

