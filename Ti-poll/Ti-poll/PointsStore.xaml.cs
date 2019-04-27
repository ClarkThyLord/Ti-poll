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
    /// Interaction logic for Points_Store.xaml
    /// </summary>
    public partial class PointStore : Window
    {
        public PointStore()
        {
            InitializeComponent();
        }

        private void Imagebtn_100_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string answer = "Successfully purchase 100 points!";
            MessageBox.Show(answer);
        }

        private void Imagebtn_250_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string answer = "Successfully purchase 250 points!!";
            MessageBox.Show(answer);
        }

        private void Imagebtn_500_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string answer = "Successfully purchase 500 points!";
            MessageBox.Show(answer);
        }

        private void Imagebtn_1000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string answer = "Successfully purchase 1000 points!";
            MessageBox.Show(answer);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Owner.Show();
        }
    }
}
