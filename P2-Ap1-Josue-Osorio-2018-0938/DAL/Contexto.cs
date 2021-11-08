using Microsoft.EntityFrameworkCore;
using P2_Ap1_Josue_Osorio_2018_0938.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Ap1_Josue_Osorio_2018_0938.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<TipoTarea> TipoTarea { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DATA Source = DATA/CitiesControl.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea
            {

                Tipoid = 1,
                TipodeTarea = "Analisis",
                Tiempo = 0
            });

            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea
            {
                Tipoid = 2,
                TipodeTarea = "Diseno",
                Tiempo = 0
            });

            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea
            {
                Tipoid = 3,
                TipodeTarea = "Programacion",
                Tiempo = 0
            });

            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea
            {
                Tipoid = 4,
                TipodeTarea = "Prueba",
                Tiempo = 0
            });
        }
    }
}
