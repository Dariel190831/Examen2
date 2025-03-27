using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenFinalDT.Models
{
    [Table("Tarea")]
    public class Tarea
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }
        public string Descripcion { get; set; }

    }
}
