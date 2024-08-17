namespace ExedePrueba.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VistaReserva")]
    public partial class VistaReserva
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id_hotel { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string Nombre_hotel { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Ciudad { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id_habitacion { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string Numero_habitacion { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Capacidad { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id_huesped { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string Huesped { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id_tarifa { get; set; }

        public decimal? Valor_tarifa { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "date")]
        public DateTime Fecha_inicio { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "date")]
        public DateTime Fecha_fin { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool Temporada { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Estado { get; set; }
    }
}
