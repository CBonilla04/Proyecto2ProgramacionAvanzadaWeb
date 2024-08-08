using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Models;
using Proyecto2ProgramacionAvanzadaWeb.Utils;
using Proyecto2ProgramacionAvanzadaWeb.ViewModel;
using System.Net.Http;

namespace Proyecto2ProgramacionAvanzadaWeb.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly AppDbContext _context;
        private readonly IEmployeeRolService _employeeRolService;
        private readonly IRolesService _rolesService;

        public EmployeesService(AppDbContext context, IEmployeeRolService employeeRolService, IRolesService rolesService)
        {
            _context = context;
            _employeeRolService = employeeRolService;
            _rolesService = rolesService;
        }
        public async Task<EmployeesView> Add(EmployeesView employeeView)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                Roles rol = await _rolesService.getById(employeeView.RoleId);

                Employees employee = AsignDataModel(employeeView);

                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                EmployeeRol employeeRol = new EmployeeRol
                {
                    EmployeeNumber = employee.EmployeeNumber,
                    RolId = rol.RoleId
                };

                await _employeeRolService.add(employeeRol);

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();

                employeeView = AsignDataView(employee);
                return employeeView;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return employeeView;
            }
        }

        public async Task<List<Employees>> GetAll()
        {
            try
            {
                return _context.Employees.Where(e => e.State == "A").ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Employees> GetById(int id)
        {
            try
            {
                Employees employee = await _context.Employees.
                                            Include(e => e.JobsHisotory).
                                            Include(t => t.Turns).
                                            Include(b => b.EmployeeBonuses).
                                                ThenInclude(eb => eb.Bonuses).
                                            FirstOrDefaultAsync(x => x.EmployeeNumber == id);
                return employee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> Update(Employees employee)
        {
            try
            {
                _context.Employees.Update(employee);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Employees AsignDataModel(EmployeesView employeeView)
        {
            return new Employees
            {
                EmployeeNumber = employeeView.EmployeeNumber,
                FirstName = employeeView.FirstName,
                Surname = employeeView.Surname,
                SecondSurname = employeeView.SecondSurname,
                Direction = employeeView.Direction,
                PhoneNumber = employeeView.PhoneNumber,
                Email = employeeView.Email,
                Birthdate = employeeView.Birthdate,
                HiredDate = employeeView.HiredDate,
                State = employeeView.State,
                Turns = null,
                Payrolls = null,
                EmployeeRol = null,
                JobsHisotory = null

            };
        }

        public EmployeesView AsignDataView(Employees employee)
        {
            try
            {
                return new EmployeesView
                {
                    EmployeeNumber = employee.EmployeeNumber,
                    FirstName = employee.FirstName,
                    Surname = employee.Surname,
                    SecondSurname = employee.SecondSurname,
                    Direction = employee.Direction,
                    PhoneNumber = employee.PhoneNumber,
                    Email = employee.Email,
                    Birthdate = employee.Birthdate,
                    HiredDate = employee.HiredDate,
                    State = employee.State,
                    Turn = employee.Turns,
                    Payrolls = employee.Payrolls,
                    EmployeeRol = employee.EmployeeRol,
                    JobsHisotory = employee.JobsHisotory

                };
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
