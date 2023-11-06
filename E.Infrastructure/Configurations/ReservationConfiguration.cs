using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.Configurations
{
    internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new
            {
                r.LocataireFK,
                r.VehiculeFK,
                r.DateReservation
            });

            builder.HasOne(L => L.Locataire)
                .WithMany(L => L.Reservations)
                .HasForeignKey(L => L.LocataireFK);

            builder.HasOne(L => L.Vehicule)
                .WithMany(L => L.Reservations)
                .HasForeignKey(L => L.VehiculeFK);






        }
    }
}
