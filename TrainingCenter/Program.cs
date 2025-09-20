using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TrainingCenter.Data;
using TrainingCenter.Repository;
using TrainingCenter.Repository.Base;
//using TrainingCenter.Repository;
//using TrainingCenter.Repository.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();






var conectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(conectionString));


builder.Services.AddScoped(typeof(IRepository<>), typeof(MainRepository<>));
//builder.Services.AddScoped<IRepoProduct, RepoProduct>();
//builder.Services.AddScoped<IRepoCategory, RepoCategory>();
//builder.Services.AddScoped<IRepoEmployee, RepoEmployee>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddControllersWithViews().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

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
