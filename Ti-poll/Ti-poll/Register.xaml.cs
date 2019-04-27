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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private bool redirect = false;

        public Register()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (!redirect)
            {
                Owner.Show();
                Close();
            }
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0) return;
            if (username.Text.Length == 0) return;
            if (password.Password.Length == 0) return;
            if (age.Text.Length == 0 || !int.TryParse(age.Text, out int Age)) return;

            User client = new User(name.Text, username.Text, Age, password.Password, true);
            
            Database.data.Users.Add(client);
            Database.data.save();

            redirect = true;
            Home home = new Home();
            home.Owner = Owner;
            home.Show();
            Close();
        }
    }
}
