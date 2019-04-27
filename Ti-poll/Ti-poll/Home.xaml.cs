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
using Ti_poll.Clases;

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
            Store s = new Store();
            s.Owner = this;
            s.Show();
            Hide();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            profile_button.Content = Database.CurrentUser.Name;
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddSurvey a = new AddSurvey();
            a.Owner = this;
            a.Show();
            Hide();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //foreach (int i in Database.CurrentUser.Surveys)
            //{
            //    Clases.Survey s = Database.data.GetSurvey(i);
            //    Label l = new Label();
            //    l.Content = s.Name + " " + s.Category + " " + s.Views;
            //    l.Tag = i;
            //    panel.Children.Add(l);
            //    l.MouseDown += L_MouseDown;
            //}
        }

        private void L_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Clases.Survey s;
            Label l = sender as Label;
            int i = (int)l.Tag;
            for (int j = 0; j < Database.CurrentUser.Surveys.Count; j++)
            {
                if (j==i)
                {
                    s = Database.data.GetSurvey(j);
                    EditSurvey es = new EditSurvey(s);
                    es.Owner = this;
                    es.Show();
                    Hide();
                }
            }
        }

        private void PointsMoney_button_Click(object sender, RoutedEventArgs e)
        {
            Points_Store ps = new Points_Store();
            ps.Owner = this;
            ps.Show();
            Hide();
        }
    }
}
