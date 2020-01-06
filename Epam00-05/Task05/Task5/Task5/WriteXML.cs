using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task5
{
    class WriteXML
    {
        public static void Write(string name, string path, DateTime dateTime, string text)
        {
            //string path = $@"C:\Users\{Environment.UserName}\Desktop\backup\logs.txt";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load($@"C:\Users\{Environment.UserName}\Desktop\backup\logs.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент
            XmlElement file = xDoc.CreateElement("File");
            // создаем атрибут fileName
            XmlAttribute fileAttr = xDoc.CreateAttribute("Name");
            // создаем элементы 
            XmlElement nameTextE = xDoc.CreateElement("Name");
            XmlElement pathTextE = xDoc.CreateElement("Path");
            //XmlElement dateTextE = xDoc.CreateElement("Date");
            XmlElement TextE = xDoc.CreateElement("Text");

            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode(name);
            XmlText pathText = xDoc.CreateTextNode(path);
            XmlText dateText = xDoc.CreateTextNode(dateTime.ToString());
            XmlText Text = xDoc.CreateTextNode(text);

            //добавляем узлы
            fileAttr.AppendChild(dateText);
            nameTextE.AppendChild(nameText);
            pathTextE.AppendChild(pathText);
            //dateTextE.AppendChild(dateText);
            TextE.AppendChild(Text);
            file.Attributes.Append(fileAttr);
            file.AppendChild(nameTextE);
            file.AppendChild(pathTextE);
            //file.AppendChild(dateTextE);
            file.AppendChild(TextE);
            xRoot.AppendChild(file);
            xDoc.Save($@"C:\Users\{Environment.UserName}\Desktop\backup\logs.xml");


            Console.WriteLine("worked");
        }
    }
}
