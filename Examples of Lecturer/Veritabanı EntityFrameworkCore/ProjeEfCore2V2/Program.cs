using Microsoft.EntityFrameworkCore;
using ProjeEfCore2.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



// ➤ Bağlantı cümlesini buraya yaz (hardcoded)
var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;";

// ➤ DbContext'i servise ekle
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(connectionString));

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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
