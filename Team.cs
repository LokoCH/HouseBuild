using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Team : IWorker
    {
        public Team(string n, string leader, string worker)
        {
            Name = n;
            _leader = new TeamLeader(leader);
            _workers = new Worker(worker);
        }
        public string Name { get; }

        Worker _workers;
        TeamLeader _leader;

        public void Work(House h)
        {
            _workers.Work(h);
            _leader.Work(h);
        }
    }
}
