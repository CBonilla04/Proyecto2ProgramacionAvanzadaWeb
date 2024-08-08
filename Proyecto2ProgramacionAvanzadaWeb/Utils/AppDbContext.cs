using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Proyecto2ProgramacionAvanzadaWeb.Models;
<<<<<<< HEAD
using System.Data;
using System.Security;
=======
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

namespace Proyecto2ProgramacionAvanzadaWeb.Utils
{
    public class AppDbContext : DbContext
    {
<<<<<<< HEAD
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<EmployeeRol> EmployeeRol { get; set; }
=======
        public DbSet<Employees> Empleados { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<EmployeeRol> EmpleadoRoles { get; set; }
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<RolPermissions> RolPermissions { get; set; }
        public DbSet<Evaluations> Evaluations { get; set; }
        public DbSet<Objetives> Objetives { get; set; }
        public DbSet<EvaluationObjective> EvaluationObjective { get; set; }
        public DbSet<EvaluationComments> EvaluationComments { get; set; }
        public DbSet<Turns> Turns{ get; set; }
        public DbSet<Admins> Admins{ get; set; }
        public DbSet<Payrolls> Payrolls { get; set; }
<<<<<<< HEAD
        public DbSet<JobsHisotory> JobsHisotory { get; set; }
        public DbSet<Bonuses> Bonuses { get; set; }
        public DbSet<EmployeeBonuses> EmployeeBonuses { get; set; }

=======
>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

<<<<<<< HEAD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            try
            {
                modelBuilder.Entity<EmployeeRol>()
                .HasKey(er => er.EmployeeRolId);

                modelBuilder.Entity<EmployeeRol>()
                    .HasOne(er => er.Employee)
                    .WithMany(e => e.EmployeeRol)
                    .HasForeignKey(er => er.EmployeeNumber);

                modelBuilder.Entity<EmployeeRol>()
                    .HasOne(er => er.Rol)
                    .WithMany(r => r.EmployeeRol)
                    .HasForeignKey(er => er.RolId);

                modelBuilder.Entity<EmployeeBonuses>()
                .HasKey(er => er.EmployeeBonusId);

                modelBuilder.Entity<EmployeeBonuses>()
                    .HasOne(er => er.Employees)
                    .WithMany(e => e.EmployeeBonuses)
                    .HasForeignKey(er => er.EmployeeId);

                modelBuilder.Entity<EmployeeBonuses>()
                    .HasOne(er => er.Bonuses)
                    .WithMany(r => r.EmployeeBonuses)
                    .HasForeignKey(er => er.BonusId);


                modelBuilder.Entity<Roles>().HasData(
                new Roles { RoleId = 1, RoleName = "Analista I", MonthSalary = 2000000, HoursWeek = 40, HourCost = 12500 },
                new Roles { RoleId = 2, RoleName = "Analista II", MonthSalary = 3000000, HoursWeek = 40, HourCost = 18750 },
                new Roles { RoleId = 3, RoleName = "Ingeniero I", MonthSalary = 4000000, HoursWeek = 40, HourCost = 25000 },
                new Roles { RoleId = 4, RoleName = "Ingeniero II", MonthSalary = 5000000, HoursWeek = 40, HourCost = 31250 },
                new Roles { RoleId = 5, RoleName = "Supervisor I", MonthSalary = 6000000, HoursWeek = 40, HourCost = 37500 },
                new Roles { RoleId = 6, RoleName = "Supervisor II", MonthSalary = 7000000, HoursWeek = 40, HourCost = 43750 },
                new Roles { RoleId = 8, RoleName = "Genrente", MonthSalary = 8000000, HoursWeek = 40, HourCost = 50000 },
                new Roles { RoleId = 9, RoleName = "Gerente General", MonthSalary = 9000000, HoursWeek = 40, HourCost = 56250 },
                new Roles { RoleId = 10, RoleName = "Director Ejecutivo", MonthSalary = 10000000, HoursWeek = 40, HourCost = 62500 }
                );

                modelBuilder.Entity<Bonuses>().HasData(
                    new Bonuses { BonusId = 1, BonusName = "Bono de productividad", BonusDescription = "Bono de productividad por cumplimiento de objetivos", MontlyAmount = 100000 },
                    new Bonuses { BonusId = 2, BonusName = "Bono de antiguedad", BonusDescription = "Bono de antiguedad por cumplir 5 años en la empresa", MontlyAmount = 120000 },
                    new Bonuses { BonusId = 3, BonusName = "Bono de puntualidad", BonusDescription = "Bono de puntualidad por cumplir con la asistencia", MontlyAmount = 80000 },
                    new Bonuses { BonusId = 4, BonusName = "Bono de vacaciones", BonusDescription = "Bono de vacaciones por cumplir con las metas de vacaciones", MontlyAmount = 40000 },
                    new Bonuses { BonusId = 5, BonusName = "Bono de navidad", BonusDescription = "Bono de navidad por cumplir con las metas de fin de año", MontlyAmount = 140000 },
                    new Bonuses { BonusId = 6, BonusName = "Bono de desempeño", BonusDescription = "Bono de desempeño por alcanzar altos niveles de rendimiento", MontlyAmount = 90000 },
                    new Bonuses { BonusId = 7, BonusName = "Bono de capacitación", BonusDescription = "Bono de capacitación por completar cursos de formación", MontlyAmount = 75000 },
                    new Bonuses { BonusId = 8, BonusName = "Bono de referidos", BonusDescription = "Bono de referidos por recomendar nuevos empleados", MontlyAmount = 60000 },
                    new Bonuses { BonusId = 9, BonusName = "Bono de equipo", BonusDescription = "Bono de equipo por logros colectivos", MontlyAmount = 50000 },
                    new Bonuses { BonusId = 10, BonusName = "Bono de innovación", BonusDescription = "Bono de innovación por aportar ideas creativas", MontlyAmount = 80000 },
                    new Bonuses { BonusId = 11, BonusName = "Bono de fidelidad", BonusDescription = "Bono de fidelidad por años de servicio en la empresa", MontlyAmount = 100000 }
                );


                // Configuración adicional de otras relaciones uno a uno, si es necesario

                base.OnModelCreating(modelBuilder);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
=======

>>>>>>> 7e619a760a9991348b64feaa1be766d081e6e088
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
