using Epam._06.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserDao
    {
        User Add(User user);

        User GetById(int id);

        IEnumerable<User> GetAll();

        bool RemoveById(int id);
    }
}
