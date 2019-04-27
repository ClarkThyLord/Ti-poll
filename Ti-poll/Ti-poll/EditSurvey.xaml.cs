using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for EditSurvey.xaml
    /// </summary>
    public partial class EditSurvey : Window
    {
        public Clases.Survey survey;
        int index;
        string ir;
        public EditSurvey(Clases.Survey survey)
        {
            InitializeComponent();
            this.survey = survey;
            questions_lb.ItemsSource = survey.profiles;
        }

        private void questions_lb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            index = questions_lb.SelectedIndex;
            Clases.Profile profile= Clases.Database.data.GetProfile(index);
            titulo_encuesta.Text = profile.Question;

            byte[] binaryData = Convert.FromBase64String(profile.Image);

            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(binaryData);
            bi.EndInit();

            Image img = new Image();
            img.Source = bi;
            pic = img;
        }

        private void Add_quest_Click(object sender, RoutedEventArgs e)
        {
            int index = (int)questions_lb.SelectedValue;
            Clases.Profile profile = Clases.Database.data.GetProfile(index);
            titulo_encuesta.Text = profile.Question;
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == true)
            {
                pic.Source = new BitmapImage(new Uri(of.FileName));
            }
            byte[] imageArray = File.ReadAllBytes(of.FileName);
            ir = Convert.ToBase64String(imageArray);
            profile.Image = ir;
            Clases.Database.data.save();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }
    }
}
