using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.DataAccess.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IEmployeeDataAccess, EmployeeDB>();
builder.Services.AddTransient<IItemDataAccess, ItemDB>();
builder.Services.AddTransient<IEmployeeContainer, EmployeeContainer>();
builder.Services.AddTransient<IItemContainer, ItemContainer>();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
