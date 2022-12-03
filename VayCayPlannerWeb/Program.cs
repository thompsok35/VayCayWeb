using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VayCayPlannerWeb.Data;
using VayCayPlannerWeb.Data.Extensions;
using AutoMapper;
using VayCayPlannerWeb.Configuration;
using VayCayPlannerWeb.Contracts;
using VayCayPlannerWeb.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
//TODO: Dependency Inject the Services:
//TODO: Register the Database context.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

//TODO: Change the default 'IdentityUser' to the extended user class 'Subscriber'
builder.Services.AddDefaultIdentity<Subscriber>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

//TODO: Register the repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ITripRepository, TripRepository>();

//TODO: Register the AutoMapper
builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
