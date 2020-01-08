using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;
using Epam._06.BLL;
using Epam._06.Enitities;
using Settings;
using Epam._06.DAL;
using System.Configuration;

namespace Epam._06.PL
{
    class Program
    {
        private static IUserLogic _userLogic;
        static void Main(string[] args)
        {
            WriteMode();
            _userLogic = SetConfig.UserLogic;

            UserMode();
        }
        private static void WriteMode()
        {
            Console.WriteLine("Select mode");
            Console.WriteLine("1. Write on HDD.");
            Console.WriteLine("2. RAM.");
            Console.WriteLine("3. Configuration file.");

            for (; ; )
            {
                int mode;
                while (!int.TryParse(Console.ReadLine(), out mode))
                {
                    Console.WriteLine("Wrong input. Try again.");
                }
                switch (mode)
                {
                    case 1:
                        {
                            WriteSetting("File");
                            return;
                        }
                    case 2:
                        {
                            WriteSetting("Memory");
                            return;
                        }
                    case 3:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong number. Try again.");
                            continue;
                        }
                }
            }
        }

        private static void WriteSetting(string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings["DAL"] == null)
                {
                    settings.Add("DAL", value);
                }
                else
                {
                    settings["DAL"].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Something wrong");
            }
        }
        private static void UserMode()
        {
            while (true)
            {
                Menu();
                if (!int.TryParse(Console.ReadLine(), out int mode))
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    continue;
                }

                switch (mode)
                {
                    case 1:
                        {
                            User user = CreateUser();
                            _userLogic.Add(user);
                            Console.WriteLine($"User added. User  {user.Id} : {user.Name}");
                            Console.WriteLine($"Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            int id = GetId();
                            User user = _userLogic.GetById(id);
                            ShowUser(user);
                            Console.WriteLine($"Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 3:
                        {
                            ShowAllUsers();
                            Console.WriteLine($"Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 4:
                        {
                            int id = GetId();
                            if (_userLogic.RemoveById(id))
                            {
                                Console.WriteLine($"User with ID = {id} is removed.");
                            }
                            else
                            {
                                Console.WriteLine("Wrong id.");
                            }
                            Console.WriteLine($"Press any key to continue");
                            Console.ReadLine();
                            break;
                        }
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong. Try again.");
                            Console.ReadLine();
                            break;
                        }
                }
                if (mode == 0)
                {
                    break;
                }
                Console.Clear();
            }
        }
        private static int GetId()
        {
            Console.WriteLine("Enter id:");
            int id;
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out id))
                {
                    Console.WriteLine("Try again.");
                    continue;
                }
                if (id < 1)
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    continue;
                }
                break;
            }
            return id;
        }

        private static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Select mode:");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Show user by ID");
            Console.WriteLine("3. Show users");
            Console.WriteLine("4. Remove user by ID");
            Console.WriteLine("0. Exit");
        }

        private static User CreateUser()

        {
            string name;
            DateTime dateOfBirth;

            Console.WriteLine("Enter name:");
            while (true)
            {
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Incorrect input. Try again.");
                    continue;
                }
                break;
            }

            Console.WriteLine("Enter date of birth format: DD.MM.YYYY:");
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.WriteLine("Incorrect input. Try again.");
            }
            return new User() { Name = name, DateOfBirth = dateOfBirth };
        }

        private static void ShowUser(User user)
        {
            if (user == null)
            {
                Console.WriteLine("Wrong id.");
            }
            else
            {
                Console.WriteLine(user);
            }
        }
        private static void ShowAllUsers()
        {
            IEnumerable<User> users = _userLogic.GetAll();
            if (users.Count() == 0)
            {
                Console.WriteLine("We not have users");
            }
            else
            {
                foreach (var item in users)
                {
                    ShowUser(item);
                }
            }
        }

    }
}
