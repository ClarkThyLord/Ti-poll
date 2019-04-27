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
using Ti_poll.Clases;

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic 1 Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private bool redirect = false;

        public Register()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!redirect)
            {
                Owner.Show();
                Close();
            }
        }

        private void continue_Click(object sender, RoutedEventArgs e)
        {
            PageOne.Visibility = Visibility.Hidden;
            PageTwo.Visibility = Visibility.Visible;
        }

        private void finished_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0) return;
            if (username.Text.Length == 0) return;
            if (password.Password.Length == 0) return;
            if (age.Text.Length == 0 || !int.TryParse(age.Text, out int Age)) return;

            if (income1.Text.Length > 0 && !double.TryParse(income1.Text, out double Income)) return;

            User client = new User(name.Text, username.Text, Age, Database.encrypt_text(password.Password), true, new User.Background(
                income1.Text.Length > 0 ? double.Parse(income1.Text) : -1,
                gender.Text,
                country1.Text,
                ethnicity1.Text,
                sex_txt.Text,
                relationship1.Text
            ));

            Database.data.login(client);
            Database.data.Users.Add(client);
            Database.data.save();
            
            redirect = true;

            Home home = new Home();
            home.Owner = Owner;
            home.Show();
            Close();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
