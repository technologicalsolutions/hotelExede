namespace ExedePrueba.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Temporada")]
    public partial class Temporada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Temporada()
        {
            Reserva = new HashSet<Reserva>();
        }

        public long Id { get; set; }

        [Column("Temporada")]
        public bool Temporada1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_fin { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }
    }
}
