using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public interface IWorker
    {
        string Name { get; }
        void Work(House h);
    }
}
