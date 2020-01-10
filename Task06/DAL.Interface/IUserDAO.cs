using Epam._06.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserDAO
    {
        User Add(User user);

        User GetById(int id);

        IEnumerable<User> GetAll();

        bool RemoveById(int id);

        bool AddAward(int id, int awardId);

        bool RemoveAward(int id, int awardId);

        void RemoveInUsers(int awardId);
    }
}
