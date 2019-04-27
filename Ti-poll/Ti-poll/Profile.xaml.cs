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
    /// Interaction logic for Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            nickname.Content = Database.CurrentUser.Nickname;

            name.Text = Database.CurrentUser.Name;
            age.Text = Database.CurrentUser.Age.ToString();
            points.Text = Database.CurrentUser.Points.ToString();

            gender.Text = Database.CurrentUser.Backgrounds.Gender;
            relationship.Text = Database.CurrentUser.Backgrounds.Relationship;
            country.Text = Database.CurrentUser.Backgrounds.Country;
            ethnicity.Text = Database.CurrentUser.Backgrounds.Ethnicity;
            income.Text = Database.CurrentUser.Backgrounds.Income.ToString();
            sexuality.Text = Database.CurrentUser.Backgrounds.Sexuality;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Show();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length > 0) Database.CurrentUser.Name = name.Text;
            if (password.Password.Length > 0) Database.CurrentUser.Password = Database.CurrentUser.Password = Database.encrypt_text(password.Password);
            if (age.Text.Length > 0 && int.TryParse(age.Text, out int Age)) Database.CurrentUser.Age = Age;

            if (income.Text.Length > 0 && double.TryParse(income.Text, out double Income)) Database.CurrentUser.Backgrounds.Income = Income;
            if (gender.Text.Length > 0) Database.CurrentUser.Backgrounds.Gender = gender.Text;
            if (country.Text.Length > 0) Database.CurrentUser.Backgrounds.Country = country.Text;
            if (ethnicity.Text.Length > 0) Database.CurrentUser.Backgrounds.Ethnicity = ethnicity.Text;
            if (sexuality.Text.Length > 0) Database.CurrentUser.Backgrounds.Sexuality = sexuality.Text;
            if (relationship.Text.Length > 0) Database.CurrentUser.Backgrounds.Relationship = relationship.Text;

            Database.data.save();

            MessageBox.Show("Se guardo correctamente!");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
