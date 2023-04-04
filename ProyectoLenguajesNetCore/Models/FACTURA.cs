using System.ComponentModel.DataAnnotations;

namespace ProyectoLenguajesNetCore.Models
{
    public class FACTURA
    {
        [Key]
        public int ID_FACTURA { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(20)]
        public string APELLIDO { get; set; }

        [Required]
        [StringLength(50)]
        public string CORREO { get; set; }

        [Required]
        [StringLength(100)]
        public string DIRECCION { get; set; }

        [Required]
        public int TELEFONO { get; set; }

        [Required]
        [StringLength(20)]
        public string PRODUCTOS { get; set; }

        [Required]
        public int TOTAL { get; set; }
    }
}
