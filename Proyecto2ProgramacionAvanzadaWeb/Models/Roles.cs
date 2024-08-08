using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Roles
    {
        public Roles ()
        {
            RolPermissions = new List<RolPermissions>();
            EmployeeRol = new List<EmployeeRol>();
        }

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
        public List<RolPermissions>? RolPermissions { get; set; }
        public List<EmployeeRol>? EmployeeRol { get; set; }

    }
}
