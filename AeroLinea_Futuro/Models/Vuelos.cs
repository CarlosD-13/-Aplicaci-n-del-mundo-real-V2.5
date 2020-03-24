    using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AeroLinea_Futuro.Models
{
    public class Vuelos
    {
        [Key]
        public int Id_Vuelos { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Escala { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Tanda { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Categoria { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Fecha { get; set; }

    }
}