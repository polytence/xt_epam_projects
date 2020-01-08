using DAL.Interface;
using Epam._06.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam._06.DAL
{
        public class DALMemory : IUserDao
        {
            private readonly IDictionary<int, User> _users;
            public DALMemory()
            {
                _users = new Dictionary<int, User>();
            }

            public User Add(User user)
            {
                var lastId = _users.Keys.Count > 0 ? _users.Keys.Max() : 0;

                user.Id = lastId + 1;

                _users.Add(user.Id, user);

                return user;
            }

            public User GetById(int id)
            {
                _users.TryGetValue(id, out var user);
                return user;
            }

            public IEnumerable<User> GetAll()
            {
                return _users.Values;
            }


            public bool RemoveById(int id)
            {
                return _users.Remove(id);
            }  
        }
 }

