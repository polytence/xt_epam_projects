using Epam._06.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IAwardLogic
    {
        Award Add(Award award);

        Award GetById(int id);

        IEnumerable<Award> GetAll();

        bool RemoveById(int id);
    }
}
