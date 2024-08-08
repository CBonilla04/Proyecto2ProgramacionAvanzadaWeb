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
<<<<<<< HEAD
        [DataType(DataType.Time)]
        public TimeSpan StartTurn { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan EndTurn { get; set; }
=======
        public string StartTurn { get; set; }

        [Required]
        public string EndTurn { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

        [Required]
        public string TurnType { get; set; }

<<<<<<< HEAD
        public ICollection<Employees>? Employees { get; set; }
=======
        public ICollection<Employees> Employees { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

    }
}
