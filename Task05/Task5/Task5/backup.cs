using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using System.Threading;

namespace Task5
{
    class Backup
    {
        public static void ReadXml()
        {
            XDocument UsersData = XDocument.Load($@"C:\Users\{Environment.UserName}\Desktop\backup\logs.xml");
            XElement root = UsersData.Element("Files");
            foreach (XElement xe in root.Elements("File").ToList())
                foreach (XAttribute x in xe.Attributes().ToList())
                {
                    Console.WriteLine(x.Value); 
                }
            var temp = DateTime.Now.ToString(CultureInfo.CurrentCulture);
            Console.WriteLine("Enter date format: \"{0}\" : to backup", temp);
            var Restoration = Console.ReadLine();
            try
            {
                DateTime.Parse(Restoration).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Spy.SpyChanged();
            foreach (XElement xe in root.Elements("File").ToList())
                foreach (XAttribute x in xe.Attributes().ToList())
                {
                    if (x.Value == Restoration)
                    {
                        //Console.WriteLine(xe.Element("Text").Value);
                        //x.Value = "ok";
                        //using (FileStream file = new FileStream(xe.Element("Path").Value, FileMode.OpenOrCreate))
                        //using (StreamWriter fileWrite = new StreamWriter(file))
                        //{
                        //    fileWrite.Write(xe.Element("Text").Value);
                        //}
                        try
                        {
                            var text = xe.Element("Text").Value;
                            File.WriteAllText(xe.Element("Path").Value, text.ToString());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The process failed: {0}", e.ToString());
                        }


                        try
                        {
                            File.SetLastWriteTime(xe.Element("Path").Value, DateTime.Parse(x.Value));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("The process failed: {0}", e.ToString());
                        }
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
