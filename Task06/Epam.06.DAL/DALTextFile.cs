using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Epam._06.Enitities;
using Newtonsoft.Json;


namespace Epam._06.DAL
{
    public class DALTextFile : IUserDao
    {
        private readonly string path = @".users.json";
        private readonly IDictionary<int, User> _users;

        public DALTextFile()
        {
            if (File.Exists(path))
            {
                using (var streamReader = new StreamReader(File.Open(path, FileMode.Open)))
                {
                    string fileContent = streamReader.ReadLine();
                    _users = JsonConvert.DeserializeObject<Dictionary<int, User>>(fileContent);
                }
            }
            else
            {
                _users = new Dictionary<int, User>();
            }
            
        }

        public User Add(User user)
        {
            var lastId = _users.Keys.Count > 0 ? _users.Keys.Max() : 0;

            user.Id = lastId + 1;

            _users.Add(user.Id, user);

            WriteUsers();

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
            bool removeResult = _users.Remove(id);
            WriteUsers();
            return removeResult;
        }
        private void WriteUsers()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (var streamWriter = new StreamWriter(File.Open(path, FileMode.Create)))
            {
                streamWriter.Write(JsonConvert.SerializeObject(_users));
            }
            File.SetAttributes(path, FileAttributes.Hidden);
            Console.WriteLine("File saved");
        }

    }
}
