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
        public string StartTurn { get; set; }

        [Required]
        public string EndTurn { get; set; }

        [Required]
        public string TurnType { get; set; }

        public ICollection<Employees> Employees { get; set; }

    }
}
