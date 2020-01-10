using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam._06.Enitities;

namespace DAL.Interface
{
    public interface IAwardDAO
    {
        Award Add(Award award);

        Award GetById(int id);

        IEnumerable<Award> GetAll();

        bool RemoveById(int id);
    }
}
