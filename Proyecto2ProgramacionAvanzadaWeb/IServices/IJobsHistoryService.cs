using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.IServices
{
    public interface IJobsHistoryService
    {
        Task<List<JobsHisotory>> GetAllById(int id);

        Task<JobsHisotory> Add(JobsHisotory jobsHisotory);
    }
}
