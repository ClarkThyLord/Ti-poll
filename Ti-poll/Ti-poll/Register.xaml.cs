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
    /// Interaction logic for Register.xaml
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
            redirect = true;
            Home home = new Home();
            home.Owner = Owner;
            home.Show();
            Close();
        }
    }
}
