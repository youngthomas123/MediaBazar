using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.DataAccess.Database;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IEmployeeDataAccess, EmployeeDB>();
builder.Services.AddTransient<IItemDataAccess, ItemDB>();
builder.Services.AddTransient<IEmployeeContainer, EmployeeContainer>();
builder.Services.AddTransient<IItemContainer, ItemContainer>();
builder.Services.AddTransient<IStatisticsDataAccess, StatisticsDB>();
builder.Services.AddTransient<IStatisticsContainer, StatisticsContainer>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.Cookie.HttpOnly = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
        options.LoginPath = "/Index";
        options.AccessDeniedPath = "/Forbidden/";
    });

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapRazorPages();

app.Run();
