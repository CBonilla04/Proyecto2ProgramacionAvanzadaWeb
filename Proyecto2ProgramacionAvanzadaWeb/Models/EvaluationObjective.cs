using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EvaluationObjective
    {
        [Key]
        public int EvaluationObjectiveId { get; set; }

        [Required]
        public int ObjetiveProgress { get; set; }

        public Objetives Objetives { get; set; }
        public Evaluations Evaluations { get; set; }
    }
}
