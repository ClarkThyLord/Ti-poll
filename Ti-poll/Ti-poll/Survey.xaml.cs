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
    /// Interaction logic for Survey.xaml
    /// </summary>
    public partial class Survey : Window
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void ok_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("ok!");
        }

        private void cross_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("cross!");
        }

        private void exit_Pressed(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
