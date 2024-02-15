using Organaizer3121.Classes_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Organaizer3121.Windows_
{
    /// <summary>
    /// Interaction logic for LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        Classes_.Entities context = new Classes_.Entities();
        public LogInWindow()
        {
            InitializeComponent();
            cmb.ItemsSource = context.Users.Select(x => x.Question).ToList();
        }

        private void LogIn_btn_Click(object sender, RoutedEventArgs e)
        {
            Users us = context.Users.Where(x => x.Login == login_txt.Text && x.Password == pass_txt.Text).FirstOrDefault();
            if (us != null)
            {
                TasksWindow tw = new TasksWindow(us);
                tw.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect login or password");
            }
        }

        private void ResetPass_btn_Click(object sender, RoutedEventArgs e)
        {
            sp2.Visibility = Visibility.Visible;
            var userName = login_txt.Text;
            
        }

        private void SignUp_btn_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow suw = new SignUpWindow();
            suw.Show();
            this.Hide();
        }
    }
}
