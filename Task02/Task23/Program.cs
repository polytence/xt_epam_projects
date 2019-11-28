using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task23
{
    class Program
    {
        static void Main(string[] args)
        {
            User Artem = new User("Artem", "Danilkin", "Ur'evich", new DateTime(1997, 07, 24));
            Console.WriteLine("Фамилия: " + Artem.SecondName + " Имя: " + Artem.FirstName + " Отчество: " + Artem.Patronymic);
            Console.WriteLine("Дата рождения: " + Artem.Birthday.ToLongDateString() + " Возраст: " + Artem.Age());
        }
        class User
        {
            public string UserFirstName;
            public string UserSecondName;
            public string UserPatronymic;
            public DateTime UserBirthday;
             public int Age()
            {
                int CalculationAge = DateTime.Now.Year - UserBirthday.Year;
                return CalculationAge;
            }
            public string FirstName { get { return UserFirstName; } set { UserFirstName = value; } }
            public string SecondName { get { return UserSecondName; } set { UserSecondName = value; } }
            public string Patronymic { get { return UserPatronymic; } set { UserPatronymic = value; } }
            public int UserAge { get { return Age(); } }
            public DateTime Birthday { get { return UserBirthday; } set { UserBirthday = value; } }
            void NewUser(string UserFirstName, string UserSecondName, string UserPatronymic, DateTime UserBirthday)
            {
                FirstName = UserFirstName;
                SecondName = UserSecondName;
                Patronymic = UserPatronymic;
                Birthday = UserBirthday;
            }
            public User(string UserFirstName, string UserSecondName, string UserPatronymic, DateTime UserBirthday)
            {
                NewUser(UserFirstName, UserSecondName, UserPatronymic, UserBirthday);
            }
        }
    }
}
