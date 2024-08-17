using ExedePrueba.Models;
using System.Data.Entity;

namespace ExedePrueba.Context
{
    public partial class ModeloHotel : DbContext
    {
        public ModeloHotel()
            : base("name=ModeloHotel")
        {
        }

        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Reserva> Reserva { get; set; }
        public virtual DbSet<Tarifa> Tarifa { get; set; }
        public virtual DbSet<Temporada> Temporada { get; set; }
        public virtual DbSet<TipoAlojamientos> TipoAlojamientos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<VistaReserva> VistaReserva { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarifa>()
                .HasMany(e => e.Reserva)
                .WithRequired(e => e.Tarifa)
                .HasForeignKey(e => e.Id_tarifa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Temporada>()
                .HasMany(e => e.Reserva)
                .WithRequired(e => e.Temporada)
                .HasForeignKey(e => e.Id_Temporada)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoAlojamientos>()
                .HasMany(e => e.Tarifa)
                .WithRequired(e => e.TipoAlojamientos)
                .HasForeignKey(e => e.Id_TipoAlojamiento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Reserva)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Id_huesped)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VistaReserva>()
                .Property(e => e.Valor_tarifa)
                .HasPrecision(37, 4);
        }
    }
}
