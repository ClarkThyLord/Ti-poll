using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll
{
    class Encrypt
    {
        //Class


        public class User
        {
            public int IdUser { get; set; }
            public string nickname { get; set; }
            public string password { get; set; }
            public int puntos { get; set; }
        }

        //Main
        public string path = "JorgeJs.json";

        public MainWindow()
        {
            if (File.Exists(path))
            {
                Dictionary<string, dynamic> temp = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(File.ReadAllText(path));

                Console.WriteLine(temp["num"]);
                Console.WriteLine(temp["us"]);

                num = (int)(temp["num"]);
                us = JsonConvert.DeserializeObject<List<User>>(temp["us"].ToString());
            }

            InitializeComponent();
        }

        int num = 1;
        List<User> us = new List<User>();
        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            if (us.Exists(x => x.nickname == txtUser.Text.ToLower()))
            {
                string mensaje = "nel";
                MessageBox.Show(mensaje);
            }
            else
            {
                StringBuilder sb = EncryptPassword();
                User p1 = new User { IdUser = num, nickname = txtUser.Text.ToLower(), password = sb.ToString(), puntos = 0, };
                us.Add(p1);
                num++;
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

        private StringBuilder EncryptPassword()
        {
            string clave = TxtPassword.Password;
            clave += "taco";
            SHA512 sha = SHA512.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(clave));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            lblEncrypt.Content = sb.ToString();
            sha.Dispose();
            return sb;
        }


    }
}
