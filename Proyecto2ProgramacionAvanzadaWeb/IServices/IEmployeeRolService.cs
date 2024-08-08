using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.IServices
{
    public interface IEmployeeRolService
    {
        Task<EmployeeRol> add(EmployeeRol employeeRol);
    }
}
