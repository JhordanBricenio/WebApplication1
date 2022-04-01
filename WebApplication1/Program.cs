using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connection = "Server=.; Database = test; User ID = sa; Password = 12345678; Trusted_Connection = false; MultipleActiveResultSets = true";
builder.Services.AddDbContext<Conexion>(options => options.UseSqlServer(connection));
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
    pattern: "{controller=Persona}/{action=Index}/{id?}");

app.Run();
