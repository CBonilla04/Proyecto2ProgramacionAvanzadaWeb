using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Objetives
    {
        [Key]
        public int ObjetiveId { get; set; }

        [Required]
        public string ObjetiveName { get; set; }

        [Required]
        public string ObjetiveDescription { get; set; }

        [Required]
        public int ObjetiveWeight { get; set; }

        public ICollection<EvaluationObjective> EvaluationObjective { get; set; }


    }
}
