using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Xml;

namespace Task5
{
    class Backup
    {
        public static void Write(object obj)
        {
            string path = $@"C:\Users\{Environment.UserName}\Desktop\backup\logs.txt";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load($@"C:\Users\{Environment.UserName}\Desktop\backup\logs.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement file = xDoc.CreateElement("File");
            // создаем атрибут fileName
            XmlAttribute fileName = xDoc.CreateAttribute("fileName");
            // создаем элементы company и age
            XmlElement CreatedElem = xDoc.CreateElement("Created");
            XmlElement ChangedElem = xDoc.CreateElement("Changed");
            XmlElement DeletedElem = xDoc.CreateElement("Deleted");
            XmlElement FullPath = xDoc.CreateElement("Path");

            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode("Mark Zuckerberg");
            XmlText companyText = xDoc.CreateTextNode("Facebook");
            XmlText ageText = xDoc.CreateTextNode("30");

            //добавляем узлы
            fileName.AppendChild(nameText);
            CreatedElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            file.Attributes.Append(fileName);
            file.AppendChild(companyElem);
            file.AppendChild(ageElem);
            xRoot.AppendChild(file);
            xDoc.Save($@"C:\Users\{Environment.UserName}\Desktop\backup\logs.xml");

            //
            //using (FileStream file = new FileStream(path, FileMode.Append))
            //using (StreamWriter filewrite = new StreamWriter(file))
            //    filewrite.WriteLine(File.GetLastWriteTime(path));

            //Console.WriteLine("worked");
        } 
    }
}
