using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Pizza_project.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Pizza_projectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Pizza_projectContext") ?? throw new InvalidOperationException("Connection string 'Pizza_projectContext' not found.")));
builder.Services.AddDbContext<DataPizza_projectContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataPizza_projectContextConnection")));

builder.Services.AddDefaultIdentity<Pizza_projectUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DataPizza_projectContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
