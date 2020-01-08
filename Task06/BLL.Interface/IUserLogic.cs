using Epam._06.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;

namespace BLL.Interface
{
    public interface IUserLogic
    {
        User Add(User user);

        User GetById(int id);

        IEnumerable<User> GetAll();

        bool RemoveById(int id);
    }
}
