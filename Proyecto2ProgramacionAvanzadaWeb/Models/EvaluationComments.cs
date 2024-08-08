using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EvaluationComments
    {
        [Key]
        public int EvaluationCommentId { get; set; }

        [Required]
<<<<<<< HEAD
        public required string Comment { get; set; }

        public required Evaluations Evaluations { get; set; }
=======
        public string Comment { get; set; }

        public Evaluations Evaluations { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
    }
}
