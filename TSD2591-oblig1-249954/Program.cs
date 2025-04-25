using TSD2591_oblig1_249954.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//  Dette leser appsettings.json og henter ConnectionString korrekt:
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrer DbContext først:
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Så registrerer du resten:
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Pipeline config:
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
