using Microsoft.EntityFrameworkCore;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

namespace Proyecto2ProgramacionAvanzadaWeb.Services
{
    public class BonusesServices : IBonusesService
    {
        private readonly AppDbContext _context;

        public BonusesServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Bonuses>> GetAll()
        {
            try
            {
                return await _context.Bonuses.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
