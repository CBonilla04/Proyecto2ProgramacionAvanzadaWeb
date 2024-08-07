using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EvaluationComments
    {
        [Key]
        public int EvaluationCommentId { get; set; }

        [Required]
        public string Comment { get; set; }

        public Evaluations Evaluations { get; set; }
    }
}
