using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        [Required]
        public int MonthSalary { get; set; }

        [Required]
        public int HoursWeek { get; set; }

        [Required]
        public int HourCost { get; set; }
        public ICollection<RolPermissions> RolPermissions { get; set; }
        public ICollection<EmployeeRol> EmployeeRol { get; set; }

    }
}
