using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

namespace Proyecto2ProgramacionAvanzadaWeb.Services
{
    public class JobsHistoryService : IJobsHistoryService
    {

        private readonly AppDbContext _context;

        public JobsHistoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<JobsHisotory> Add(JobsHisotory jobsHisotory)
        {
            try
            {
                await _context.JobsHisotory.AddAsync(jobsHisotory);
                await _context.SaveChangesAsync();
                return jobsHisotory;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<List<JobsHisotory>> GetAllById(int id)
        {
            try
            {
                return _context.JobsHisotory.Where(j => j.Employees.EmployeeNumber == id).ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
