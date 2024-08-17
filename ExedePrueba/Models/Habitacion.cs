namespace ExedePrueba.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Habitacion")]
    public partial class Habitacion
    {

        public long Id { get; set; }

        public long Id_Hotel { get; set; }

        [Required]
        [StringLength(500)]
        public string Nombre { get; set; }

        public int MaximaCantidadHuespedes { get; set; }

        public long Id_TipoAlojamiento { get; set; }

        public bool Activo { get; set; } 
    }
}
