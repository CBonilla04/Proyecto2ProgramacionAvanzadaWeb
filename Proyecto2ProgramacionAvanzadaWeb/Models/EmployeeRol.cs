namespace Proyecto2ProgramacionAvanzadaWeb.Models
{
    public class EmployeeRol
    {
        public int EmployeeRolId { get; set; }

        public int EmployeeNumber { get; set; }
        public int RolId { get; set; }

        public Employees? Employee { get; set; }
        public Roles? Rol { get; set; }
    }
}
