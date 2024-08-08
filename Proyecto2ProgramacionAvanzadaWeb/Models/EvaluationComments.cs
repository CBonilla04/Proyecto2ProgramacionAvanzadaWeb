using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EvaluationComments
    {
        [Key]
        public int EvaluationCommentId { get; set; }

        [Required]
        public required string Comment { get; set; }

        public required Evaluations Evaluations { get; set; }
    }
}
