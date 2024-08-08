using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.IServices
{
    public interface IRolesService
    {
        Task<List<Roles>> getAll();
        Task<Roles> getById(int id);
    }
}
