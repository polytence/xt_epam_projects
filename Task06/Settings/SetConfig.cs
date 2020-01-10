using BLL.Interface;
using DAL.Interface;
using Epam._06.BLL;
using Epam._06.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public class SetConfig
    {
        public static IUserDAO UserDao { get; private set; }

        public static IUserLogic UserLogic { get; private set; }
        public static IAwardDAO AwardDao { get; set; }

        public static IAwardLogic AwardLogic { get; set; }

        static SetConfig()
        {
            var DALConf = ReadSetting("DAL");
            if (DALConf == "File")
            {
                UserDao = new DALTextFile();
                AwardDao = new DALAwardFile();
            }
            else
            {
                UserDao = new DALMemory();
                AwardDao = new DALAwardMemory();
            }

            UserLogic = new UserLogic(UserDao);
            AwardLogic = new AwardLogic(AwardDao);

        }

        private static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                return appSettings[key] ?? "Not Found";
            }
            catch (ConfigurationErrorsException)
            {
                return "Not Found";
            }
        }
    }
}
