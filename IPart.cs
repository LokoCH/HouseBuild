using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public interface IPart
    {
        string Name { get; }
        ConsoleColor Color { get; }
        int Length { get; }
        int Width { get; }
        int Height { get; }
        bool CanInstall(int len, int width); 
        void Draw();
    }
}
