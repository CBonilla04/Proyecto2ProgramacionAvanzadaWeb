using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Payrolls
    {
        [Key]
        public int PayrollId { get; set; }

        [Required]
        public int PayrollDay1 { get; set; }

        [Required]
        public int PayrollDay2 { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public decimal Deductions { get; set; }

        [Required]
        public decimal Bonuses { get; set; }

        [Required]
        public decimal NetSalary { get; set; }

<<<<<<< HEAD
        public Employees? Employee { get; set; }
=======
        public Employees Employee { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

    }
}
