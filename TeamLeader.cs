using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class TeamLeader : IWorker
    {
        public TeamLeader(string n)
        {
            Name = n;
        }
        public string Name { get; }

        public void Work(House h)
        {
            Console.WriteLine("Информация о строительстве дома");

            Console.WriteLine("Фундамент");
            for (int i = 0; i < h.HouseBasement.Length; i++)
            {
                if (h.HouseBasement[i] != null)
                {
                    Console.WriteLine($"{h.HouseBasement[i].Name}: {h.HouseBasement[i].Length}x{h.HouseBasement[i].Width}x{h.HouseBasement[i].Height}");
                }
                else
                    Console.WriteLine("Элемент не построен");
            }

            Console.WriteLine("Стены");
            for (int i = 0; i < h.Walls.Length; i++)
            {
                if (h.Walls[i] != null)
                {
                    Console.WriteLine($"{h.Walls[i].Name}: {h.Walls[i].Length}x{h.Walls[i].Width}x{h.Walls[i].Height}");
                }
                else
                    Console.WriteLine("Элемент не построен");
            }

            Console.WriteLine("Дверь");
            if (h.HouseDoor != null)
            {
                Console.WriteLine($"{h.HouseDoor.Name}: {h.HouseDoor.Length}x{h.HouseDoor.Height}");
            }

            Console.WriteLine("Окна");
            for (int i = 0; i < h.HouseWindows.Length; i++)
            {
                if (h.HouseWindows[i] != null)
                {
                    Console.WriteLine($"{h.HouseWindows[i].Name}: {h.HouseWindows[i].Length}x{h.HouseWindows[i].Height}");
                }
                else
                    Console.WriteLine("Элемент не построен");
            }

            Console.WriteLine("Крыша");
            if (h.HouseRoof != null)
            {
                Console.WriteLine($"{h.HouseRoof.Name}: {h.HouseRoof.Length}x{h.HouseRoof.Width}x{h.HouseRoof.Height}");
            }
            else
                Console.WriteLine("Элемент не построен");
        }
    }
}
