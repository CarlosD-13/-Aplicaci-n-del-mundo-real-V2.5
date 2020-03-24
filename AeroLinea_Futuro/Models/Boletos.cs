using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AeroLinea_Futuro.Models
{
    public class Boletos
    {
        [Key]
        public int BoletosID { get; set; }
        [Column(TypeName ="varchar(30)")]
        public string Nombre { get; set; }
        [Column(TypeName = "int")]
        public int Precio { get; set; }
        [Column(TypeName = "DateTime")]
        public DateTime Fecha { get; set; }
        [Column(TypeName = "varchar(10)")]
        public String Reserva { get; set; }
    }
}
