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
    public class AwardLogic : IAwardLogic
    {
        private IAwardDAO _awardDao;

        public AwardLogic(IAwardDAO awardDao)
        {
            _awardDao = awardDao;
        }

        public Award Add(Award award)
        {
            return _awardDao.Add(award);
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardDao.GetAll();
        }

        public Award GetById(int id)
        {
            return _awardDao.GetById(id);
        }

        public bool RemoveById(int id)
        {
            return _awardDao.RemoveById(id);
        }
    }
}
