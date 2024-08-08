using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Roles
    {
<<<<<<< HEAD
        public Roles ()
        {
            RolPermissions = new List<RolPermissions>();
            EmployeeRol = new List<EmployeeRol>();
        }

=======
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
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
<<<<<<< HEAD
        public List<RolPermissions>? RolPermissions { get; set; }
        public List<EmployeeRol>? EmployeeRol { get; set; }
=======
        public ICollection<RolPermissions> RolPermissions { get; set; }
        public ICollection<EmployeeRol> EmployeeRol { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

    }
}
