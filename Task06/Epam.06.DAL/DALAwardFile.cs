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
    public class DALAwardFile : IAwardDAO
    {
        private readonly IDictionary<int, Award> _awards;
        private const string Path = @".awards.json";

        public DALAwardFile()
        {
            if (File.Exists(Path))
            {
                using (var streamReader = new StreamReader(File.Open(Path, FileMode.Open)))
                {
                    string fileContent = streamReader.ReadLine();
                    _awards = JsonConvert.DeserializeObject<Dictionary<int, Award>>(fileContent);
                }
            }
            else
            {
                _awards = new Dictionary<int, Award>();
            }
        }

        public Award Add(Award award)
        {
            var lastId = _awards.Keys.Count > 0 ? _awards.Keys.Max() : 0;
            award.Id = lastId + 1;
            _awards.Add(award.Id, award);
            WriteAwards();
            return award;
        }

        public IEnumerable<Award> GetAll()
        {
            return _awards.Values;
        }

        public Award GetById(int id)
        {
            _awards.TryGetValue(id, out var award);
            return award;
        }

        public IEnumerable<Award> GetByIdList(IEnumerable<int> ids)
        {
            var awardsIds = _awards.Where((k) => ids.Contains(k.Key));
            List<Award> awards = new List<Award>(awardsIds.Count());
            foreach (var awardId in awardsIds)
            {
                awards.Add(awardId.Value);
            }
            return awards;
        }

        public bool RemoveById(int id)
        {
            Award awardToRemove = _awards[id];
            bool removeResult = _awards.Remove(id);
            WriteAwards();
            return removeResult;

        }
        private void WriteAwards()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            using (var streamWriter = new StreamWriter(File.Open(Path, FileMode.Create)))
            {
                streamWriter.Write(JsonConvert.SerializeObject(_awards));
            }
            File.SetAttributes(Path, FileAttributes.Hidden);
        }
    }
}
