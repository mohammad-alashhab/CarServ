using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CarServ.Data;
using CarServ.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CarServContextConnection") ?? throw new InvalidOperationException("Connection string 'CarServContextConnection' not found.");

builder.Services.AddDbContext<CarServContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CarServUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CarServContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
