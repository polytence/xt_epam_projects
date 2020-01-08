using System;
using System.Text;

namespace Epam._06.Enitities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                DateTime date = DateTime.Now;
                int age = date.Year - DateOfBirth.Year;
                if (date.AddYears(-age) < DateOfBirth) age--;
                return age;
            }
        }
        public override string ToString()
        {
            StringBuilder user = new StringBuilder();
            user.Append($"ID: {Id}. Name: {Name}. Date of birth: {DateOfBirth.ToShortDateString()}. Age: {Age}.");           
            return user.ToString();
        }
    }
}
