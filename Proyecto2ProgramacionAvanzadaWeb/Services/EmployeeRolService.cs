using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

namespace Proyecto2ProgramacionAvanzadaWeb.Services
{
    public class EmployeeRolService : IEmployeeRolService
    {
        private readonly AppDbContext _context;

        public EmployeeRolService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<EmployeeRol> add(EmployeeRol employeeRol)
        {
            try
            {
                await _context.EmployeeRol.AddAsync(employeeRol);
                await _context.SaveChangesAsync();
                return employeeRol;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
