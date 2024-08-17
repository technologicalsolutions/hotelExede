using System.ComponentModel.DataAnnotations;

namespace ExedePrueba.ViewModels
{
    public class GetHabitaciones
    {
        public long Id { get; set; }

        public long Id_Hotel { get; set; }

        [Required]
        [StringLength(500)]
        public string Nombre { get; set; }

        public int MaximaCantidadHuespedes { get; set; }

        public long Id_TipoAlojamiento { get; set; }
        public string TipoAlojamiento { get; set; }

        public bool Activo { get; set; }
    }
}