using Microsoft.AspNetCore.Mvc;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;
using Proyecto2ProgramacionAvanzadaWeb.ViewModel;

namespace Proyecto2ProgramacionAvanzadaWeb.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeesService _employeesService;
        private readonly IRolesService _rolesService;
        public EmployeesController(IEmployeesService employeesService, IRolesService rolesService)
        {
            _employeesService = employeesService;
            _rolesService = rolesService;
        }

        [HttpGet]
        public async Task<IActionResult> AddEmployee()
        {
            EmployeesView employee = new EmployeesView();
            try
                {
                employee.Roles =  await _rolesService.getAll();
                if (employee.Roles == null)
                {
                    employee.Roles = new List<Roles>();
                }
                return View(employee);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeesView employee)
        {
            try
            {
                ViewData["Message"] = "";
                employee = await _employeesService.Add(employee);
                if (employee?.EmployeeNumber > 0)
                {
                    TempData["Success"] = "Empleado: " + employee.FirstName + " agregado correctamente, número de empleado: " + employee.EmployeeNumber;
                    
                    employee = clearEmployee(employee);
                    return RedirectToAction("Employees", "Employees");
                }

                TempData["Error"] = "Error: No se puedo agregar el empleado, intente nuevamente";
                ViewData["Message"] = "Error: No se puedo agregar el empleado, intente nuevamente";
                return View(employee);

            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error: No se puedo agregar el empleado, intente nuevamente";
                ViewData["Message"] = "Error: No se puedo agregar el empleado, intente nuevamente";
                return View(employee);

            }
        }

        [HttpGet]
        public async Task<IActionResult> Employees(List<Employees> employees)
        {
            employees = await _employeesService.GetAll();
            if (employees == null)
            {
                employees = new List<Employees>();
                return View(employees);
            }
            return View(employees);
        }

        public EmployeesView clearEmployee(EmployeesView employee)
        {
            return new EmployeesView();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            try
            {
                Employees employee = await _employeesService.GetById(id);
                if (employee == null)
                {

                    TempData["Error"] = "Empleado no encontrado";
                    return RedirectToAction("Employees", "Employees");
                }
                HttpContext.Session.SetObjectAsJson("EmployeeNumber", employee.EmployeeNumber);

                return View(employee);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(Employees employee)
        {
            try
            {
                ;
                if (await _employeesService.Update(employee))
                {
                    TempData["Success"] = "Empleado: " + employee.EmployeeNumber + " actualizado correctamente." ;
                    return RedirectToAction("Employees", "Employees");
                }
                TempData["Error"] = "Error: No se puedo actualizar el empleado, intente nuevamente";
                ViewData["Message"] = "Error: No se puedo actualizar el empleado, intente nuevamente";
                return View(employee);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }




}
