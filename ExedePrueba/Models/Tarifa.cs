namespace ExedePrueba.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tarifa")]
    public partial class Tarifa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarifa()
        {
            Reserva = new HashSet<Reserva>();
        }

        public long Id { get; set; }

        public decimal Valor_base { get; set; }

        public decimal? Incremento_temporada { get; set; }

        public int MinHuespedes { get; set; }

        public int MaxHuespedes { get; set; }

        public long Id_TipoAlojamiento { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva> Reserva { get; set; }

        public virtual TipoAlojamientos TipoAlojamientos { get; set; }
    }
}
