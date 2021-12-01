using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Wall : IPart
    {
        public Wall(string n, int l, int w, int h)
        {
            Name = n;
            Color = ConsoleColor.Red;
            Length = l;
            Width = w;
            Height = h;
        }
        public string Name { get; }

        public ConsoleColor Color { get; }

        public int Length { get; } // длина стены 

        public int Width { get; }  // толщина стены

        public int Height { get; } // высота стены

        public bool CanInstall(int len, int width)
        {
            if (Length <= len && Width <= width)
                return true;
            return false;
        }

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
