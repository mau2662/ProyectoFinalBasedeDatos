using System.ComponentModel.DataAnnotations;

namespace ProyectoLenguajesNetCore.Models
{
    public class MEDICAMENTO
    {
        [Key]
        public int ID_MEDICAMENTO { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [StringLength(20)]
        public string FARMACEUTICA { get; set; }

        [Required]
        public DateTime FECHA_INGRESO { get; set; }

        [Required]
        public DateTime FECHA_VENCIMIENTO { get; set; }
    }
}
