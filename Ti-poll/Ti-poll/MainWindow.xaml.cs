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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpalshScreen splashscreen;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void survey_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {

            }
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            Close();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            splashscreen = new SpalshScreen();
            splashscreen.Owner = this;
            splashscreen.Finished += Splashscreen_Finished;
            splashscreen.Start();

            this.Hide();
            splashscreen.Show();
        }

        private void Splashscreen_Finished(object sender, EventArgs e)
        {
            splashscreen.Hide();
            this.Show();
        }
    }
}
