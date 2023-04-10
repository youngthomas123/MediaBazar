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
<<<<<<< HEAD
			
			Application.Run(new LoginForm());
=======

            // DI start
            var services = new ServiceCollection();

            services.AddTransient<IEmployeeDataAccess, EmployeeDB>();
            services.AddTransient<IItemDataAccess, ItemDB>();
            services.AddTransient<IEmployeeContainer, EmployeeContainer>();
            services.AddTransient<IItemContainer, ItemContainer>();

            //regestring services for forms
            services.AddTransient<MainPage>();
            services.AddTransient<LoginForm>();
            services.AddTransient<ItemsPopUp>();
            services.AddTransient<CalendarPopUp>();
            services.AddTransient<EmployeeUC>();
            services.AddTransient<Days>();
            services.AddTransient<CalendarDay>();


            var serviceProvider = services.BuildServiceProvider();
            //DI end

            Application.Run(serviceProvider.GetService<MainPage>());
>>>>>>> 2f302d482ce3e3c959407d6f0fe5afa017d13454
		}
	}
}