using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();



if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/error"); 
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default", 
    pattern: "{Controller=Home}/{action=index}/{id?}");
app.Run();
