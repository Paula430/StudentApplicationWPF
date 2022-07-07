using Microsoft.EntityFrameworkCore;
using StudentApplication.Domain.Model;
using StudentApplication.Domain.Services;
using StudentApplication.EF;
using StudentApplication.EF.Services;
using StudentApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentApplication
{
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
        
            var email=txtStudentEmail.Text;
            var password = txtPassword.Password;

            using (SMDbContext context = new SMDbContext())
            {
                bool userfound = context.Students.Any((e) => e.Email == email && e.Password==password);
                if (userfound)
                {
                    Authentication.currentStudentId = context.Students.Where(e=>e.Email==email).FirstOrDefault<Students>().Id;
                    GrantAccess();
                    Close();
                }
                else if (txtStudentEmail.Text.Length == 0)
                {
                    MessageBox.Show("Enter an email.", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtStudentEmail.Focus();
                }
                else if (!Regex.IsMatch(txtStudentEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {

                    MessageBox.Show("Enter a valid email.","",MessageBoxButton.OK,MessageBoxImage.Error);
                    txtStudentEmail.Select(0, txtStudentEmail.Text.Length);
                    txtStudentEmail.Focus();
                }
                else if(txtPassword.Password.Length == 0)
                {
                    MessageBox.Show("Enter password", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Email or password is incorrect", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }          

        public void GrantAccess()
        {
            LoggedPage loggedPage = new LoggedPage();
            loggedPage.Show();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

