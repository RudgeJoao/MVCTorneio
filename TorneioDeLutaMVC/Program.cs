using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TorneioDeLutaMVC.Data;

var builder = WebApplication.CreateBuilder(args);
IWebHostEnvironment env = builder.Environment;
IConfiguration Configuration = new ConfigurationBuilder()
              .SetBasePath(env.ContentRootPath)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: false)
              .AddEnvironmentVariables()
              .Build();
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbContext, OracleDbContext>(opt =>
{
    opt.UseOracle(Configuration["Database:ConnectionString"]);
    opt.EnableSensitiveDataLogging();
    opt.LogTo(message => Debug.WriteLine(message));

});

var app = builder.Build();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
