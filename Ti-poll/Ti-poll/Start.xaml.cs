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

        private void survey_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {

            }
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            h.Owner = this;
            h.Show();
            Hide();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Close();
        }

        private void register__button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Owner = this;
            register.Show();
            Hide();
        }
    }
}
