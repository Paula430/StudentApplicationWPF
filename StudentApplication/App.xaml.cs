using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;
using StudentApplication.EF;
using StudentApplication.ViewModels;

namespace StudentApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new SMDbContext());
            facade.EnsureCreated();

            Window window = new Window();

            window.DataContext = new LoggedViewModel();

           
            
        }
    }
}
