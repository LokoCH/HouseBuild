using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Window : IPart
    {
        public Window(string n, int l, int h)
        {
            Name = n;
            Color = ConsoleColor.Cyan;
            Length = l;
            Width = 0;
            Height = h;
        }
        public string Name { get; }

        public ConsoleColor Color { get; }

        public int Length { get; }

        public int Width { get; }

        public int Height { get; }

        public bool CanInstall(int len, int width)
        {
            if (Length < len && Height <= width)
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
