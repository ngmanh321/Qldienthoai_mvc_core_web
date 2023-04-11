using BTL_Web.Models;
using BTL_Web.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("QldienthoaiContext");
builder.Services.AddDbContext<QldienthoaiContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddScoped<HangSxRepository, HangSx>();
builder.Services.AddScoped<HdhRepository, Hdh>();
builder.Services.AddScoped<ManHinhRepository, ManHinh>();
builder.Services.AddSession();


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
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Access}/{action=Login}/{id?}");

app.Run();
