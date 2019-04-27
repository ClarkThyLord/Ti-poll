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

        private void register_Click(object sender, RoutedEventArgs e)
        {
            gender.Visibility = Visibility.Visible;
            gender1.Visibility = Visibility.Visible;
            country.Visibility = Visibility.Visible;
            country1.Visibility = Visibility.Visible;
            relationship.Visibility = Visibility.Visible;
            relationship1.Visibility = Visibility.Visible;
            income1.Visibility = Visibility.Visible;
            income.Visibility = Visibility.Visible;
            ethnicity.Visibility = Visibility.Visible;
            ethnicity1.Visibility = Visibility.Visible;
            finish_btn.Visibility = Visibility.Visible;
            sex_lbl.Visibility = Visibility.Visible;
            sex_txt.Visibility = Visibility.Visible;
        }

        private void finish_btn_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0) return;
            if (username.Text.Length == 0) return;
            if (password.Password.Length == 0) return;
            if (age.Text.Length == 0 || !int.TryParse(age.Text, out int Age)) return;

            if (income1.Text.Length == 0 || income1.Text.Length > 0 && !double.TryParse(income1.Text, out double Income)) return;

            User client = new User(name.Text, username.Text, Age, password.Password, true, new User.Background(
                double.Parse(income1.Text),
                gender.Text,
                country1.Text,
                ethnicity1.Text,
                "",
                relationship1.Text
            ));

            Database.data.Users.Add(client);
            Database.data.save();
            
            redirect = true;

            Home home = new Home();
            home.Owner = Owner;
            home.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            redirect = true;
            Start s = new Start();
            s.Owner = Owner;
            s.Show();
            Close();
        }
    }
}
