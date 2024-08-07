using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class Employees
    {
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

        public Turns Turns { get; set; }

        public Payrolls Payrolls { get; set; }

        public ICollection<EmployeeRol> EmployeeRol { get; set; }


    }
}
