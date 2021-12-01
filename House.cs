using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class House
    {
        public House()
        {
            HouseBasement = new Basement[4];
            Walls = new Wall[4];
            HouseDoor = null;
            HouseWindows = new Window[4];
            HouseRoof = null;
        }
        public Basement[] HouseBasement { get; set; }
        public Wall[] Walls { get; set; }
        public Door HouseDoor { get; set; }
        public int SideDoor { get; set; }
        public Window[] HouseWindows { get; set; }
        public Roof HouseRoof { get; set; }
    }
}
