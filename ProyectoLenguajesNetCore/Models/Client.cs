using System.ComponentModel.DataAnnotations;

namespace ProyectoLenguajesNetCore.Models
{
    public class Client
    {
        [Key]
        public int ID_CLIENTE { get; set; }

        [Required]
        [StringLength(20)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(20)]
        public string APELLIDO { get; set; }

        [StringLength(20)]
        public string GENERO { get; set; }

        [Required]
        [StringLength(50)]
        public string CORREO { get; set; }

        [StringLength(100)]
        public string DIRECCION { get; set; }

        [Required]
        public int TELEFONO { get; set; }

    }
}
