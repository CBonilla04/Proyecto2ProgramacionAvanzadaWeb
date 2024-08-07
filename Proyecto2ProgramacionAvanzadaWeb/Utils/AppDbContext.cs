using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Proyecto2ProgramacionAvanzadaWeb.Models;

namespace Proyecto2ProgramacionAvanzadaWeb.Utils
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employees> Empleados { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<EmployeeRol> EmpleadoRoles { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RolPermissions> RolPermissions { get; set; }
        public DbSet<Evaluations> Evaluations { get; set; }
        public DbSet<Objetives> Objetives { get; set; }
        public DbSet<EvaluationObjective> EvaluationObjective { get; set; }
        public DbSet<EvaluationComments> EvaluationComments { get; set; }
        public DbSet<Turns> Turns{ get; set; }
        public DbSet<Admins> Admins{ get; set; }
        public DbSet<Payrolls> Payrolls { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public void InitializeDatabase()
        {
            try
            {
                var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
                if (dbCreator != null)
                {
                    if (!dbCreator.CanConnect())
                    {
                        dbCreator.Create();
                    }

                    if (!dbCreator.HasTables())
                    {
                        dbCreator.EnsureCreated();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
