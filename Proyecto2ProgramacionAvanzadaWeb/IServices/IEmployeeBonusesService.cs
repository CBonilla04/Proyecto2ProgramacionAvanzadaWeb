using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.IServices
{
    public interface IEmployeeBonusesService
    {
        Task<bool> Add(int employeeId, int bonusesId);
        Task<bool> Remove(int employeeId, int bonusesId);
    }
}
