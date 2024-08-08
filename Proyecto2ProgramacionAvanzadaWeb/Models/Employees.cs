using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using Proyecto2ProgramacionAvanzadaWeb.ViewModel;
=======
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Employees
    {
<<<<<<< HEAD
        public Employees()
        {
            Payrolls = new List<Payrolls>();
            EmployeeRol = new List<EmployeeRol>();
            JobsHisotory = new List<JobsHisotory>();
            EmployeeBonuses = new List<EmployeeBonuses>();
        }

=======
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
        [Key]
        public int EmployeeNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string SecondSurname { get; set; }

        [Required]
        [StringLength(500)]
        public string Direction { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "El email no es válido.")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "Smalldatetime")]
        public DateTime Birthdate { get; set; }

        [Required]
        [Column(TypeName = "Smalldatetime")]
        public DateTime HiredDate { get; set; }

        [Required]
        [StringLength(1)]
        public string State { get; set; }

<<<<<<< HEAD
        public Turns? Turns { get; set; }

        public List<Payrolls>? Payrolls { get; set; }

        public List<EmployeeRol>? EmployeeRol { get; set; }
        public List<JobsHisotory>? JobsHisotory { get; set; }

        public List<EmployeeBonuses>? EmployeeBonuses { get; set; }

        
=======
        public Turns Turns { get; set; }

        public Payrolls Payrolls { get; set; }

        public ICollection<EmployeeRol> EmployeeRol { get; set; }

>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

    }
}
