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

        private void login_Click(object sender, RoutedEventArgs e)
        {
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
                Survey s = new Survey();
                s.Owner = this;
                s.Show();
                Hide();
            }
        }
    }
}
