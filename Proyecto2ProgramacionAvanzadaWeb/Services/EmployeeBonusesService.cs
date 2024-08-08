using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

namespace Proyecto2ProgramacionAvanzadaWeb.Services
{
    public class EmployeeBonusesService : IEmployeeBonusesService
    {
        private readonly AppDbContext _context;

        public EmployeeBonusesService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Add(int employeeId, int bonusesId)
        {
            try
                {
                var employeeBonuses = new EmployeeBonuses
                {
                    EmployeeId = employeeId,
                    BonusId = bonusesId
                };
                _context.EmployeeBonuses.AddAsync(employeeBonuses);
                _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<bool> Remove(int employeeId, int bonusesId)
        {
            try
            {
                var employeeBonuses = _context.EmployeeBonuses.Where(eb => eb.EmployeeId == employeeId && eb.BonusId == bonusesId).FirstOrDefault();
                _context.EmployeeBonuses.Remove(employeeBonuses);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
