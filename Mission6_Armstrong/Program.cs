using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Mission6_Armstrong.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MoviesContext>(options => {
    options.UseSqlite(builder.Configuration["ConnectionStrings:MovieConnection"]);
});
 
var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
