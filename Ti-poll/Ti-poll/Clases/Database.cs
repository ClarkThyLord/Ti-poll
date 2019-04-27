using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ti_poll.Clases
{
    class Database
    {
        public static string FILE_NAME = "data.json";
        public static string PATH = $@"{Directory.GetCurrentDirectory()}\database\";
        public static string FILE_PATH {
            get
            {
                return PATH + FILE_NAME;
            }
        }

        public static Database data = load();

        public static User CurrentUser = null;

        private int usercount = 0;
        public int UserCount {
            get
            {
                usercount++;
                return usercount - 1;
            }
            set { usercount = value; }
        }

        private int surverycount = 0;
        public int SurveyCount
        {
            get
            {
                surverycount++;
                return surverycount - 1;
            }
            set { surverycount = value; }
        }

        private int profilecount = 0;
        public int ProfileCount
        {
            get
            {
                profilecount++;
                return profilecount - 1;
            }
            set { profilecount = value; }
        }

        public List<User> Users = new List<User>();
        public List<Survey> Surveys = new List<Survey>();
        public List<Profile> Profiles = new List<Profile>();

        public void save()
        {
            System.IO.Directory.CreateDirectory(PATH);
            File.WriteAllText(FILE_PATH, JsonConvert.SerializeObject(this));
        }

        public static Database load()
        {
            if (File.Exists(FILE_PATH))
            {
                return JsonConvert.DeserializeObject<Database>(File.ReadAllText(FILE_PATH));
            }
            else
            {
                return new Database();
            }
        }

        public static string encrypt_text(string text)
        {
            text += "taco";

            SHA512 sha = SHA512.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            sha.Dispose();

            return sb.ToString();
        }

        public User attempt_login(string username, string password)
        {
            password = encrypt_text(password);
            return Users.Find(user => user.Nickname.ToLower() == username.ToLower() && user.Password == password);
        }

        public void login(User user)
        {
            CurrentUser = user;
        }

        public void logout()
        {
            CurrentUser = null;
        }

        public Survey GetSurvey(int id)
        {
            return Surveys.Find(survey => survey.ID == id);
        }

        public Profile GetProfile(int id)
        {
            return Profiles.Find(profile => profile.ID == id);
        }
    }
}
