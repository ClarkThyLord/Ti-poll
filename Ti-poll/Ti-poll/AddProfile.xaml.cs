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
    public partial class AddQuestion : Window
    {
        List<int> profiles;
        string base64ImageRepresentation;
        public AddQuestion()
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
            byte[] imageArray = File.ReadAllBytes(of.FileName);
            base64ImageRepresentation = Convert.ToBase64String(imageArray);

        }

        private void Done_button_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            (Owner as AddSurvey).addlist(profiles);
            Owner.Owner.Show();
            Owner.Close();
        }

        private void Add_quest_Click(object sender, RoutedEventArgs e)
        {
            Clases.Profile profile = new Clases.Profile(titulo_encuesta.Text,base64ImageRepresentation);

            Clases.Database.data.Profiles.Add(profile);
            
            Clases.Database.data.save();

            profiles.Add(profile.ID);
            int num = titulo_encuesta.Text.Length;
            if (titulo_encuesta.Text.Length>0)
            {
                if (titulo_encuesta.Text[num - 1] != '?')
                {
                    titulo_encuesta.Text += '?';
                }
                questions_lb.Items.Add(titulo_encuesta.Text);
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            profiles = new List<int>();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            questions_lb.Items.Remove(questions_lb.SelectedItem);
        }
    }
}
