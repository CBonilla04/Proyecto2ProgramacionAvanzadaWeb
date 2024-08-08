using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EvaluationObjective
    {
        [Key]
        public int EvaluationObjectiveId { get; set; }

        [Required]
        public int ObjetiveProgress { get; set; }

<<<<<<< HEAD
        public required Objetives Objetives { get; set; }
        public required Evaluations Evaluations { get; set; }
=======
        public Objetives Objetives { get; set; }
        public Evaluations Evaluations { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
    }
}
