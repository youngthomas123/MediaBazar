using MediaBazar.BusinessLogic.Containers;
using MediaBazar.BusinessLogic.Interfaces;
using MediaBazar.DataAccess.Database;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using S2GroupProject.Forms;
using System;

namespace S2GroupProject
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			

            // DI start
            var services = new ServiceCollection();

            services.AddTransient<IEmployeeDataAccess, EmployeeDB>();
            services.AddTransient<IItemDataAccess, ItemDB>();
            services.AddTransient<IEmployeeContainer, EmployeeContainer>();
            services.AddTransient<IItemContainer, ItemContainer>();
            services.AddTransient<IWarehouseDataAccess, WarehouseDB>();
            services.AddTransient<IWarehouseContainer, WarehouseContainer>();

            //regestring services for forms
            services.AddTransient<MainPage>();
            services.AddTransient<LoginForm>();
            services.AddTransient<CalendarPopUp>();
            services.AddTransient<WarehouseManager>();
            services.AddTransient<EmployeeUC>();
            services.AddTransient<Days>();
            services.AddTransient<CalendarDay>();
            services.AddTransient<CreateWarehousePopUp>();


            var serviceProvider = services.BuildServiceProvider();
            //DI end

            Application.Run(serviceProvider.GetService<MainPage>());
		}
	}
}