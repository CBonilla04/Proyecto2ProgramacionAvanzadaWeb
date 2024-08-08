using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.IServices
{
    public interface IBonusesService
    {
        Task<List<Bonuses>> GetAll();
    }
}
