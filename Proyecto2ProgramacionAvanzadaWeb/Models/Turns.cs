using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Turns
    {
        [Key]
        public int TurnId { get; set; }

        [Required]
        public int DaysWork { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan StartTurn { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan EndTurn { get; set; }

        [Required]
        public string TurnType { get; set; }

        public ICollection<Employees>? Employees { get; set; }

    }
}
