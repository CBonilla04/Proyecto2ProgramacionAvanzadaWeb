using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Bonuses
    {
        public Bonuses()
        {
            EmployeeBonuses = new List<EmployeeBonuses>();
        }
        [Key]
        public int BonusId { get; set; }

        [Required]
        public string BonusName { get; set; }

        [Required]
        public string BonusDescription { get; set; }

        [Required]
        public decimal MontlyAmount { get; set; }

        public List<EmployeeBonuses>? EmployeeBonuses { get; set; }

    }
}
