using BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam._06.Enitities;
using DAL.Interface;

namespace Epam._06.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao _userDao;

        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public User Add(User user)
        {
            return _userDao.Add(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public User GetById(int id)
        {
            return _userDao.GetById(id);
        }

        public bool RemoveById(int id)
        {
            return _userDao.RemoveById(id);
        }
        
    }
}
