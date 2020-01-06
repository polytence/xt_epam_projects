using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    class Employee : User
    {
        public string Position { get; set; }
        public DateTime WorkExperience { get; set; }
        public Employee(string position, DateTime workExperience, string FirstName, string SecondName, string patronymic,
               DateTime birthday) : base(FirstName, SecondName, patronymic, birthday)
        {
            Position = position;
            WorkExperience = workExperience;
        }
        public int Experience()
        {
            int Experience = DateTime.Now.Year - WorkExperience.Year;
            return Experience;
        }
    }
}

