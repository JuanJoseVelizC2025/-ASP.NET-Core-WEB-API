using System.ComponentModel.DataAnnotations;

namespace WebAPISolution.Models
{
    public class Docente
    {
        [Key]
        public int DocenteId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Apellidos { get; set; }
    }
}