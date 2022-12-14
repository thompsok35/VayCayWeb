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
//this service was added so the User built-in object can be accessed from any repository
builder.Services.AddHttpContextAccessor();
//TODO: Register the repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ITripRepository, TripRepository>();
builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();
builder.Services.AddScoped<ISubscriberRepository, SubscriberRepository>();
builder.Services.AddScoped<ITravelerGroupsRepository, TravelerGroupsRepository>();
builder.Services.AddScoped<ITravelGroupRepository, TravelGroupRepository>();
builder.Services.AddScoped<ITravelGroupTripsRepository, TravelGroupTripsRepository>();

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
