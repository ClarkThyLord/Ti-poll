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
using System.IO;
using Microsoft.Win32;
namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for Add_Question.xaml
    /// </summary>
    public partial class Add_Question : Window
    {
        public Add_Question()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog()==true)
            {
                pic.Source = new BitmapImage(new Uri(of.FileName));
            }
            
        }

        private void Done_button_Click(object sender, RoutedEventArgs e)
        {
            Owner.Owner.Show();
            Owner.Close();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Owner.Show();
            Owner.Close();
        }
    }
}
