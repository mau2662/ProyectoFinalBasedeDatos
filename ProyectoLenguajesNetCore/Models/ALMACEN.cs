using System.ComponentModel.DataAnnotations;

namespace ProyectoLenguajesNetCore.Models
{
    public class ALMACEN
    {
        [Key]
        public int ID_ESTANTE { get; set; }

        [Required]
        [StringLength(30)]
        public string NOMBRE_ESTANTE { get; set; }
    }
}
