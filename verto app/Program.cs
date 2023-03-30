using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using verto_app.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<verto_appContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("verto_appContext") ?? throw new InvalidOperationException("Connection string 'verto_appContext' not found.")));

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
