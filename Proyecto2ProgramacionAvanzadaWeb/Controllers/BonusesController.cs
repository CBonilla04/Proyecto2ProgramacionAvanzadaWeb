using Microsoft.AspNetCore.Mvc;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;
using Proyecto2ProgramacionAvanzadaWeb.ViewModel;

namespace Proyecto2ProgramacionAvanzadaWeb.Controllers
{
    public class BonusesController : Controller
    {
        private readonly IEmployeesService _employeesService;
        private readonly IBonusesService _bonusesServices;
        private readonly IEmployeeBonusesService _employeeBonusesService;

        public BonusesController(IEmployeesService employeesService, IBonusesService bonusesService, IEmployeeBonusesService employeeBonusesService)
        {
            _employeesService = employeesService;
            _bonusesServices = bonusesService;
            _employeeBonusesService = employeeBonusesService;
        }

        [HttpGet]
        public async Task<IActionResult> Assign()
        {
            try
            {
                List<Bonuses> employeeBonuses = new List<Bonuses>();
                List<Bonuses> Bonuses = new List<Bonuses>();
                Employees employee = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
                if (employee != null)
                {
                    foreach (EmployeeBonuses item in employee?.EmployeeBonuses)
                    {
                        employeeBonuses.Add(item.Bonuses);
                    }
                }

                Bonuses = await _bonusesServices.GetAll();
                if (Bonuses == null)
                {
                    Bonuses = new List<Bonuses>();
                }
                else
                {
                    Bonuses.RemoveAll(b => employeeBonuses.Any(eb => eb.BonusId == b.BonusId));

                }

                BonusesView bonusesView = new BonusesView(employeeBonuses, Bonuses);

                return View(bonusesView);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
            try
            {
                Employees employee = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
                if(await _employeeBonusesService.Add(employee.EmployeeNumber, id))
                {
                    TempData["Success"] = "Bono asignado correctamente";
                }
                else
                {
                    TempData["Error"] = "Error: No se puedo asignar el bono, intente nuevamente";
                }
                
                return RedirectToAction("Assign");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                Employees employee = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
                if (await _employeeBonusesService.Remove(employee.EmployeeNumber, id))
                {
                    TempData["Success"] = "Bono eliminado correctamente";
                }
                else
                {
                    TempData["Error"] = "Error: No se puedo eliminar el bono, intente nuevamente";
                }

                return RedirectToAction("Assign");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
