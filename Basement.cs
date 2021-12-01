using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Basement : IPart
    {
        public Basement(string n, int l, int w, int h)
        {
            Name = n;
            Color = ConsoleColor.Gray;
            Length = l;
            Width = w;
            Height = h;
        }
        public string Name { get; }

        public ConsoleColor Color { get; }

        public int Length { get; } // длина фундамента

        public int Width { get; }  // толщина фундамента

        public int Height { get; } // высота фундамента

        public bool CanInstall(int len = 0, int width = 0) => true;

        public void Draw()
        {
            Console.BackgroundColor = Color;
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
