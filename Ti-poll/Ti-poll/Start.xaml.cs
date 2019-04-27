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
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            user_txt.Focus();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            user_txt.Text = "";
            pass_txt.Password = "";
            survey_code.Text = "";
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void user_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (user_txt.Text.Length > 0 && e.Key == Key.Enter)
            {
                pass_txt.Focus();
            }
        }

        private void pass_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (user_txt.Text.Length > 0 && e.Key == Key.Enter)
            {
                attempt_login();
            }
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            attempt_login();
        }

        private void attempt_login()
        {
            User user = Database.data.attempt_login(user_txt.Text, pass_txt.Password);
            if (user == null) {
                user_txt.Focus();
                user_txt.SelectAll();
                return;
            }

            Database.data.login(user);

            Home h = new Home();
            h.Owner = this;
            h.Show();
            Hide();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Owner = this;
            register.Show();
            Hide();
        }

        private void survey_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!int.TryParse(survey_code.Text, out int id))
                {
                    survey_code.SelectAll();
                    return;
                }

                Database.data.GetProfile(id);

                Survey s = new Survey();
                s.Owner = this;
                s.Show();
                Hide();
            }
        }
    }
}
