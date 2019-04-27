﻿using System;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                //Console.WriteLine(Database.CurrentUser.Surveys.Count);
                //List<Clases.Survey> surveys = new List<Clases.Survey>();

                //foreach (int id in Database.CurrentUser.Surveys)
                //{
                //    surveys.Add(Database.data.GetSurvey(id));
                //} 

                //SurveyList.ItemsSource = surveys;
                //SurveyList.Items.Refresh();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void searchbar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key==Key.Enter)
            {

            }
        }

        private void profile_Click(object sender, RoutedEventArgs e)
        {
            Perfil p = new Perfil();
            p.Owner = this;
            Hide();
            p.Show();
        }

        private void store_Click(object sender, RoutedEventArgs e)
        {
            Store s = new Store();
            s.Owner = this;
            Hide();
            s.Show();
        }

        private void PointMoney_Click(object sender, RoutedEventArgs e)
        {
            PointStore ps = new PointStore();
            ps.Owner = this;
            Hide();
            ps.Show();
        }

        private void Stats_Click(object sender, RoutedEventArgs e)
        {
            Stats stats = new Stats();
            stats.Owner = this;
            Hide();
            stats.Show();
        }

        private void AddSurvey(object sender, RoutedEventArgs e)
        {
            AddSurvey addSurvey = new AddSurvey();
            addSurvey.Owner = this;
            Hide();
            addSurvey.Show();
        }
    }
}
