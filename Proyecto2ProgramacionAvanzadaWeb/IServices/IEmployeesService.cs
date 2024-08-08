using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.ViewModel;

namespace Proyecto2ProgramacionAvanzadaWeb.IServices
{
    public interface IEmployeesService
    {
        Task<EmployeesView> Add(EmployeesView employeeView);
        Task<bool> Update(Employees employe);
        Task<Employees> GetById(int id);
        Task<List<Employees>> GetAll();

    }
}
