using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class JobsHisotory
    {
        [Key]
        public int JobsHisotoryId { get; set; }

        [Required]
        public string Empresa { get; set; }

        [Required]
        public string Puesto { get; set; }

        [Required]
        [Column(TypeName = "Smalldatetime")]
        public DateTime StartDate { get; set; }

        [Required]
        [Column(TypeName = "Smalldatetime")]
        public DateTime EndtDate { get; set; }

        public Employees? Employees;

    }
}
