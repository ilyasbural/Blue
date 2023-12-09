using Blue.Core;
using Blue.Service;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<SetlirsContext>(x => x.UseSqlServer(Configuration.GetConnectionString("SqlServer")!));
builder.Services.LoadServices();
builder.Services.AddAutoMapper(typeof(CityMapper));
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromDays(30); options.Cookie.HttpOnly = true; options.Cookie.IsEssential = true; });
//builder.Services.AddCors(options => options.AddDefaultPolicy(builder => { builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));
//builder.Services.AddSingleton<IConnectionMultiplexer>(multiplexer);
//builder.Services.AddSwaggerGen();

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

//app.MapControllerRoute(
//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//	name: "areas",
//	pattern: "{area:exists}/{controller=Home}/{action=Index}"
//);

//app.MapControllerRoute(
//    name: "management",
//    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//	name: "api",
//	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//	name: "backup",
//	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "backup",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "management",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();