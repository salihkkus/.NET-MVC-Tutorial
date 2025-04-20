var builder = WebApplication.CreateBuilder(args);
//servisleri buraya
builder.Services.AddControllersWithViews();

var app = builder.Build();

//middlewareleride buraya yaz
//app.MapGet("/Varsayilan", () => "Hello World!");
//app.MapDefaultControllerRoute();
app.UseStaticFiles();
app.MapControllerRoute
(
    name:"Default",
    pattern:"{controller=Deneme}/{action=Index}/{id?}"
);

app.Run();
