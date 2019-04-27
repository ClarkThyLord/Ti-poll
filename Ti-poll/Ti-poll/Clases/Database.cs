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

        public static User User = null;

        public static int UsersCount = 0;
        public static List<User> Users = new List<User>();

        public static void load()
        {
            if (File.Exists(FILE_PATH))
            {
                Dictionary<string, dynamic> data = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(File.ReadAllText(FILE_PATH));

                UsersCount = data["UsersCount"];
                Users = data["Users"];
            }
        }

        public static void save()
        {
            JsonConvert.SerializeObject(new Dictionary<string, dynamic> {
                {
                    "UsersCount",
                    UsersCount
                },
                {
                    "Users",
                    Users
                }
            });
        }
    }
}
