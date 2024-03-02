using Microsoft.EntityFrameworkCore;
using Mission08_3_12.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<_413firstThingsContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:TaskConnection"]);
});

builder.Services.AddScoped<ITaskRepository, EFTaskRepository>(); //Give each request an instance of EFBaseballRepository. Each HTTP request will get its own. 

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
