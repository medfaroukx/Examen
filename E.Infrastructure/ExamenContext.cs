using E.ApplicationCore.Domain;
using E.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Agent> Agents { get; set; }

        public DbSet<Entreprise> Entreprises { get; set; }

        public DbSet<Locataire> Locataires { get; set; }

        public DbSet<Personne> Personnes { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Vehicule> vehicules { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            Initial Catalog=TestDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            // configuration de TPH : l'approche par défaut de l'heritage
            // modification du type to int

            modelBuilder.Entity<Locataire>()
              .HasDiscriminator<int>("TypeLocataire")
              .HasValue<Locataire>(1)
              .HasValue<Entreprise>(2)
             .HasValue<Personne>(3);

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
        }
    }
}
