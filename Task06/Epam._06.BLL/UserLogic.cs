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
        private IUserDAO _userDao;

        public UserLogic(IUserDAO userDao)
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
        public bool AddAward(int id, int awardId)
        {
            return _userDao.AddAward(id, awardId);
        }

        public bool RemoveAward(int id, int awardId)
        {
            return _userDao.RemoveAward(id, awardId);
        }

        public void RemoveInUsers(int awardId)
        {
        }
    }
}
