using DAL.Interface;
using Epam._06.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam._06.DAL
{
    public class DALAwardMemory : IAwardDAO
    {
        private readonly IDictionary<int, Award> _awards;

        public DALAwardMemory()
        {
            _awards = new Dictionary<int, Award>();
        }
        public Award Add(Award award)
        {
            var lastId = _awards.Keys.Count > 0 ? _awards.Keys.Max() : 0;

            award.Id = lastId + 1;

            _awards.Add(award.Id, award);

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

            return removeResult;
        }
    }
}
