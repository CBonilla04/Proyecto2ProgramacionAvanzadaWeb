using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.ViewModel
{
    public class EmployeesView
    {
        public EmployeesView()
        {
            Roles = new List<Roles>();
            Payrolls = new List<Payrolls>();
            EmployeeRol = new List<EmployeeRol>();
            JobsHisotory = new List<JobsHisotory>();
            HiredDate = DateTime.Now;
            Birthdate = DateTime.Now;
        }
        public int EmployeeNumber { get; set; }


        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string SecondSurname { get; set; }

        public string Direction { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }

        public DateTime HiredDate { get; set; }
        public string State { get; set; }

        public Turns? Turn { get; set; }
        public int RoleId { get; set; }

        public List<Roles>? Roles { get; set; }
        public List<Payrolls>? Payrolls { get; set; }

        public List<EmployeeRol>? EmployeeRol { get; set; }
        public List<JobsHisotory>? JobsHisotory { get; set; }
    }
}
