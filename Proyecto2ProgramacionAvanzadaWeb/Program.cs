using Microsoft.EntityFrameworkCore;
using Proyecto2ProgramacionAvanzadaWeb.IServices;
using Proyecto2ProgramacionAvanzadaWeb.Services;
using Proyecto2ProgramacionAvanzadaWeb.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddScoped<IEmployeesService, EmployeesService>();
builder.Services.AddScoped<IRolesService, RolesService>();
builder.Services.AddScoped<IEmployeeRolService, EmployeeRolService>();
builder.Services.AddScoped<IJobsHistoryService, JobsHistoryService>();
builder.Services.AddScoped<IBonusesService, BonusesServices>();
builder.Services.AddScoped<IEmployeeBonusesService, EmployeeBonusesService>();


var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.InitializeDatabase();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employees}/{action=Employees}/{id?}");

app.Run();
