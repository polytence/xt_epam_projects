using System;
using System.Collections.Generic;
using System.Linq;
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
            string userAwards = "";
            foreach (var award in _awards)
            {
                userAwards += " "+award;
            }
            StringBuilder user = new StringBuilder();
            user.Append($"ID: {Id}. Name: {Name}. Date of birth: {DateOfBirth.ToShortDateString()}. Age: {Age}.");
            user.Append($"User have awards: {userAwards}");
            return user.ToString();
        }

        private ISet<int> _awards;

        public User()
        {
            _awards = new SortedSet<int>();
        }
        public ISet<int> Awards { 
            get => _awards; 
            set => _awards = value; 
        }

        public bool AddAward(int awardId)
        {
            return _awards.Add(awardId);
        }

        public bool RemoveAward(int awardId)
        {
            return _awards.Remove(awardId);
        }
    }
}
