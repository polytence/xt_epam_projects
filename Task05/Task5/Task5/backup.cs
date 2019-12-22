using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;

namespace Task5
{
    class Backup
    {
        public static void ReadXml()
        {
            var temp = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            Console.WriteLine("Enter date format: \"{0}\" :", temp);
            var Restoration = Console.ReadLine();
            try
            {
                DateTime.Parse(Restoration).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            XDocument UsersData = XDocument.Load($@"C:\Users\{Environment.UserName}\Desktop\backup\logs.xml");
            XElement root = UsersData.Element("Files");
            foreach (XElement xe in root.Elements("File").ToList())
                foreach(XAttribute x in xe.Attributes().ToList())
                {
                    if (x.Value == Restoration)
                    {
                        Console.WriteLine(x.Value + "ok");
                    }

                } 
               // {
               //     Console.WriteLine(xe.Attribute("fileName").Value);
                //}


            //foreach (XElement xe in root.Elements("File").ToList())
            //{
            //    if ((xe.Element("Name").Value == "123124214.txt"))
            //    {
            //        Console.WriteLine("ok");    
            //    }
            //}
        } 
    }
}
