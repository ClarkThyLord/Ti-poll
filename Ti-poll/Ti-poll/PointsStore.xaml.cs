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
            if(MessageBox.Show("Are you sure to buy this item?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                string answer = "Successfully purchased!, you got 100 extra points!";
                MessageBox.Show(answer);
            }
        }

        private void Imagebtn_250_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Are you sure to buy this item?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                string answer = "Successfully purchased!, you got 250 extra points!";
                MessageBox.Show(answer);
            }
        }

        private void Imagebtn_500_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Are you sure to buy this item?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                string answer = "Successfully purchased!, you got 500 extra points!";
                MessageBox.Show(answer);
            }
        }

        private void Imagebtn_1000_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Are you sure to buy this item?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                string answer = "Successfully purchased!, you got 1000 extra points!";
                MessageBox.Show(answer);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
            Owner.Show();
        }
    }
}
