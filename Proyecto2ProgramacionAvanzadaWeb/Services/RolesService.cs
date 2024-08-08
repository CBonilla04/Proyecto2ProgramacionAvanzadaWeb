using Microsoft.EntityFrameworkCore;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

namespace Proyecto2ProgramacionAvanzadaWeb.Services
{
    public class RolesService : IRolesService
    {   
        private readonly AppDbContext _context;

        public RolesService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Roles>> getAll()
        {
            try
                {
                return _context.Roles.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Roles> getById(int id)
        {
            try
            {
                return await _context.Roles.FirstOrDefaultAsync(x => x.RoleId == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
