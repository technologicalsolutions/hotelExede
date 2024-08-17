using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ExedePrueba.ViewModels
{
    public class ResponseHotel : ResponseBase
    {
        public long Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Nombre { get; set; }

        public int Capacidad { get; set; }

        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }

        public HttpPostedFileBase Foto { get; set; }

        public string Imagen { get; set; }

        public bool Activo { get; set; }
    }
}