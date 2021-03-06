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
    /// Interaction logic for AddSurvey.xaml
    /// </summary>
    public partial class AddSurvey : Window
    {
        Clases.Survey survey;
        public AddSurvey()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (titulo_encuesta.Text.Length > 0 && categoria_encuesta.Text.Length > 0)
            {
                int[] owners = new int[]
                {
                    Clases.Database.CurrentUser.ID
                };
                survey = new Clases.Survey() {
                    Name = titulo_encuesta.Text,
                    Category = categoria_encuesta.Text,
                    Public = privadopublico(),
                    Owners = owners
                };

                Database.data.Surveys.Add(survey);
                Database.CurrentUser.Surveys.Add(survey.ID);
                Database.data.save();

                AddQuestion aq = new AddQuestion();
                aq.Owner = this;
                aq.Show();
                Hide();
                
            }
            else
            {
                string h = "No deje espacios en blanco";
                MessageBox.Show(h);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }
        public bool privadopublico()
        {
            if (Publico.IsChecked==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void addlist(List<int> l)
        {
            survey.profiles = l;
        }
    }
}
