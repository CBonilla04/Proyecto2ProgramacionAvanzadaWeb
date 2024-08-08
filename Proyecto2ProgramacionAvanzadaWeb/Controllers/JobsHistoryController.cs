using Microsoft.AspNetCore.Mvc;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

namespace Proyecto2ProgramacionAvanzadaWeb.Controllers
{
    public class JobsHistoryController : Controller
    {
        private readonly IJobsHistoryService _jobsHistoryService;
        private readonly IEmployeesService _employeesService;

        public JobsHistoryController(IJobsHistoryService jobsHistoryService, IEmployeesService employeesService)
        {
            _jobsHistoryService = jobsHistoryService;
            _employeesService = employeesService;
        }

        [HttpGet]
        public async Task<IActionResult> Data(int id)
        {
            try
            {
                var employee = await _employeesService.GetById(id);
                    return View(employee);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(JobsHisotory jobsHisotory)
        {
            try
            {
                Employees employee = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
                employee?.JobsHisotory.Add(jobsHisotory);

                if(await _employeesService.Update(employee))
                {

                   TempData["Success"] = "Historial de trabajo agregado correctamente";
                    return RedirectToAction("Data", "JobsHistory", new { id = employee.EmployeeNumber });
                }
            
                TempData["Error"] = "Error: No se puedo agregar el historial de trabajo, intente nuevamente";
                return View(jobsHisotory);

            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error: No se puedo agregar el historial de trabajo, intente nuevamente";
                return View(jobsHisotory);

            }
        }
    }
}
