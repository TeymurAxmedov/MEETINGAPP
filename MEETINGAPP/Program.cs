var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

//{controller=home}/{action=index}/id?

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
        pattern: "{Controller=Home}/{Action=Index}/{id?}"
);
    

app.Run();
