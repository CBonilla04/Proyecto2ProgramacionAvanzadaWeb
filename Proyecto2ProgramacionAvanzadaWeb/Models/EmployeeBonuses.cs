using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EmployeeBonuses
    {
        [Key]
        public int EmployeeBonusId { get; set; }

        public int EmployeeId { get; set; }
        public int BonusId { get; set; }

        public Employees Employees { get; set; }
        public Bonuses Bonuses { get; set; }

    }
}
