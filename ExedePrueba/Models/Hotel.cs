namespace ExedePrueba.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Hotel")]
    public partial class Hotel
    {       
        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Nombre { get; set; }

        public int Capacidad { get; set; }

        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }

        public string Imagen { get; set; }

        public bool Activo { get; set; }

    }
}
