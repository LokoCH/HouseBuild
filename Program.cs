using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Program
    {
        static void Main(string[] args)
        {
            House h = new House();
            Team teamBuilders = new Team("Звезда", "Палкан", "Джамшут");
           
            while (true)
            {
                Console.Clear();
                teamBuilders.Work(h);
                Console.ReadLine();              
            }
        }
    }
}
