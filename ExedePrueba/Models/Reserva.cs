namespace ExedePrueba.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reserva")]
    public partial class Reserva
    {
        public long Id { get; set; }

        public long Id_habitacion { get; set; }

        public long Id_huesped { get; set; }

        public long Id_tarifa { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_fin { get; set; }

        public long Id_Temporada { get; set; }

        public int Estado { get; set; }

        public virtual Habitacion Habitacion { get; set; }

        public virtual Tarifa Tarifa { get; set; }

        public virtual Temporada Temporada { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
