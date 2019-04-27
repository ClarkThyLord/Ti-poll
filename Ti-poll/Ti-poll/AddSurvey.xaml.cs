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

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for AddSurvey.xaml
    /// </summary>
    public partial class AddSurvey : Window
    {
        public AddSurvey()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (titulo_encuesta.Text.Length > 0 && categoria_encuesta.Text.Length > 0)
            {
                
                AddQuestion aq = new AddQuestion();
                aq.Owner = this;
                aq.Show();
                Hide();
                aq.name_lbl.Content = titulo_encuesta.Text;
                
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
    }
}
