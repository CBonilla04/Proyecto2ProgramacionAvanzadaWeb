using Microsoft.AspNetCore.Mvc;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;
using Proyecto2ProgramacionAvanzadaWeb.ViewModel;

namespace Proyecto2ProgramacionAvanzadaWeb.Controllers
{
    public class TurnsController : Controller
    {
        private readonly IEmployeesService _employeesService;

        public TurnsController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpGet]
        public async Task<IActionResult> Data()
        {
            Employees employees = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
            if(employees.Turns == null)
            {
                List<TurnsView> turn = new List<TurnsView>();
                return View(turn);
            }

            ViewData["TurnType"] = employees.Turns.TurnType;
            ViewData["DaysWork"] = employees.Turns.DaysWork;

            var schedule = new List<TurnsView>
            {
                new TurnsView { DayOfWeek = "Lunes", StartTime = new DateTime(2024, 8, 5,  employees.Turns.StartTurn.Hours, employees.Turns.StartTurn.Minutes, 0), EndTime = new DateTime(2024, 8, 5, employees.Turns.EndTurn.Hours, employees.Turns.EndTurn.Minutes, 0) },
                new TurnsView { DayOfWeek = "Martes", StartTime = new DateTime(2024, 8, 6,  employees.Turns.StartTurn.Hours, employees.Turns.StartTurn.Minutes, 0), EndTime = new DateTime(2024, 8, 6, employees.Turns.EndTurn.Hours, employees.Turns.EndTurn.Minutes, 0) },
                new TurnsView { DayOfWeek = "Miercoles", StartTime = new DateTime(2024, 8,  6, employees.Turns.StartTurn.Hours, employees.Turns.StartTurn.Minutes, 0), EndTime = new DateTime(2024, 8, 6, employees.Turns.EndTurn.Hours, employees.Turns.EndTurn.Minutes, 0) },
                new TurnsView { DayOfWeek = "Jueves", StartTime = new DateTime(2024, 8, 6,  employees.Turns.StartTurn.Hours, employees.Turns.StartTurn.Minutes, 0), EndTime = new DateTime(2024, 8, 6, employees.Turns.EndTurn.Hours, employees.Turns.EndTurn.Minutes, 0) },
                new TurnsView { DayOfWeek = "Viernes", StartTime = new DateTime(2024, 8, 6,  employees.Turns.StartTurn.Hours, employees.Turns.StartTurn.Minutes, 0), EndTime = new DateTime(2024, 8, 6, employees.Turns.EndTurn.Hours, employees.Turns.EndTurn.Minutes, 0) },
                // Agrega más días de la semana...
            };
            return View(schedule);
        }

        [HttpGet]
        public async Task<IActionResult> SetSchedule()
        {
            try
            {
                Employees employees = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
                return View(employees.Turns);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SetSchedule(Turns turn)
        {
            try
            {
                turn.TurnType = turn.StartTurn.Hours < 20 ? "Diurno" : "Nocturno";
                turn.DaysWork = 5;
                Employees employees = await _employeesService.GetById(HttpContext.Session.GetObjectFromJson<int>("EmployeeNumber"));
                employees.Turns = turn;
                if(await _employeesService.Update(employees))
                {
                    TempData["Success"] = "Horario de trabajo para " + employees.FirstName + " actualizado correctamente";
                    return RedirectToAction("Data", "Turns");
                }
                return View(turn);
            }
            catch (Exception ex)
            {
                return View(turn);
            }
        }
    }
}
