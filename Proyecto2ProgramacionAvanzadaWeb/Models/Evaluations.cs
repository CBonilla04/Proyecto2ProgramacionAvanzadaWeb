using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Evaluations
    {
        [Key]
        public int EvaluationId { get; set; }

        [Required]
        public string EvaluationName { get; set; }

        [Required]
        [Column(TypeName = "Smalldatetime")]
        public DateTime EvaluationDate { get; set; }

        [Required]
        public string EvaluationStatus { get; set; }

        public Employees? Employee { get; set; }

        public ICollection<EvaluationComments>? EvaluationComments { get; set; }
        public ICollection<EvaluationObjective>? EvaluationObjective { get; set; }
    }
}
