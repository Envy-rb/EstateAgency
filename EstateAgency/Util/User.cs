using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency.Util
{
    public class User
    {
        static private User instance = null;
        static private String login;
        static private String name;
        static private String surname;
        static private String midname;
        static private String role;
        static private int accessLevel = 3;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Midname { get => midname; set => midname = value; }
        public string Role { get => role; set => role = value; }
        public int AccessLevel { get => accessLevel; set => accessLevel = value; }
        public string Login { get => login; set => login = value; }

        private User()
        {
        }

        public static User getInstance()
        {
            if (instance == null)
            {
                instance = new User();
            }
            return instance;
        }

        public void fillFields(String login, String name, String surname, String midname, String role, int accessLevel)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Midname = midname;
            Role = role;
            AccessLevel = accessLevel;
        }

        public override string ToString()
        {
            return Login;
        }
    }
}
