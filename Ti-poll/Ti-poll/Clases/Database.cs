using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    }
}
