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
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json;
using Ti_poll.Clases;

namespace Ti_poll
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public string path = "JorgeJs.json";
        public Register()
        {
            InitializeComponent();
        }
        public int num = 1;
        List<Client> us = new List<Client>();
        private void register__button_Click(object sender, RoutedEventArgs e)
        {
            if (us.Exists(x => x.Username == user_txt.Text.ToLower())) MessageBox.Show("nel");
            else
            {
                if (!int.TryParse(age_txt.Text, out int age)) {
                    MessageBox.Show("nel");
                    return;
                }

                us.Add(new Client(name_txt.Text, age, user_txt.Text, pass_txt.Password));
                Dictionary<string, dynamic> temp = new Dictionary<string, dynamic> {
                    {
                        "num",
                        num
                    },
                    {
                        "us",
                        us
                    }
                };
                File.WriteAllText(path, JsonConvert.SerializeObject(temp));
            }
        }

        private string EncryptPassword()
        {
            string clave = pass_txt.Password;
            clave += "taco";
            SHA512 sha = SHA512.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(clave));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            sha.Dispose();
            return sb.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            country_txt.Visibility = Visibility.Visible;
            et_txt.Visibility = Visibility.Visible;
            income_txt.Visibility = Visibility.Visible;
            relationship_txt.Visibility = Visibility.Visible;
            gender_txt.Visibility = Visibility.Visible;


        }
    }
}
