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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void searchbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {

            }
        }

        private void profile_button_Click(object sender, RoutedEventArgs e)
        {
            Perfil p = new Perfil();
            p.Show();
            p.Owner = this;
            Hide();
        }

        private void points_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void store_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Survey_Click(object sender, RoutedEventArgs e)
        {
            AddSurvey a = new AddSurvey();
            a.Owner = this;
            a.Show();
            Hide();
        }
    }
}
