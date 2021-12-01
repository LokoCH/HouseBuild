using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    internal class Worker : IWorker
    {
        public Worker(string n)
        {
            Name = n;
        }
        public string Name { get; }

        public void Work(House h)
        {
            for (int i = 0; i < 2; i++)
                if (h.HouseBasement[i] == null)
                {
                    if (MakeBasement(h, i))
                    {
                        Console.WriteLine($"{i + 1}-ая и {i + 3}-ая стороны фундаменита построены");
                    }
                    return;
                }

            for (int i = 0; i < 2; i++)
                if (h.Walls[i] == null)
                {
                    if (MakeWall(h, i))
                    {
                        Console.WriteLine($"{i + 1}-ая и  {i + 3}-ая стена построены");
                    }
                    return;
                }

            if (h.HouseDoor == null)
                if (MakeDoor(h))
                {
                    Console.WriteLine($"Дверь установлена");
                    return;
                }
                else
                    return;

            for (int i = 0; i < 2; i++)
                if ((h.HouseWindows[i] == null))
                {
                    if (MakeWindow(h, i))
                    {
                        Console.WriteLine($"Окно установлено в стены {i + 1} и {i + 3}");
                    }
                    return;
                }

            if (h.HouseRoof == null)
                if (MakeRoof(h))
                {
                    Console.WriteLine($"Крыша установлена");

                }
                else
                    return;
        }
        private bool MakeBasement(House h, int side)
        {
            int len;
            int width;
            int height;
            Console.WriteLine($"Введите размеры {side + 1}-й и {side + 3}-й стороны фундамента");

            while (true)
            {
                Console.Write("Длина: ");
                if (!int.TryParse(Console.ReadLine(), out len))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("Толщина: ");
                if (!int.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Высота: ");
                if (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            h.HouseBasement[side] = new Basement($"Сторона {side + 1}", len, width, height);
            h.HouseBasement[side + 2] = new Basement($"Сторона {side + +3}", len, width, height);
            return true;
        }

        private bool MakeWall(House h, int side)
        {
            int len;
            int width;
            int height;
            Console.WriteLine($"Введите размеры {side + 1}-й и {side + 3}-й стены");

            while (true)
            {
                Console.Write("Длина: ");
                if (!int.TryParse(Console.ReadLine(), out len))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Ширина: ");
                if (!int.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Высота: ");
                if (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            Wall tmp = new Wall($"Стена {side + 1}", len, width, height);
            if (tmp.CanInstall(h.HouseBasement[side].Length, h.HouseBasement[side].Width))
            {
                h.Walls[side] = tmp;
                h.Walls[side + 2] = new Wall($"Стена {side + 1}", len, width, height);
                return true;
            }
            return false;
        }
        private bool MakeDoor(House h, int side = 0)
        {
            int len;
            int height;

            Console.WriteLine($"Введите размеры двери");
            while (true)
            {
                Console.Write("Длина: ");
                if (!int.TryParse(Console.ReadLine(), out len))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Высота: ");
                if (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            Door tmp = new Door("Дверь", len, height);
            if (tmp.CanInstall(h.Walls[side].Length, h.Walls[side].Height))
            {
                h.HouseDoor = tmp;
                h.SideDoor = side;
                return true;
            }
            return false;
        }
        private bool MakeWindow(House h, int side)
        {
            int len;
            int height;

            Console.WriteLine($"Введите размеры окна");
            while (true)
            {
                Console.Write("Длина: ");
                if (!int.TryParse(Console.ReadLine(), out len))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Высота: ");
                if (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            Window tmp = new Window($"Окно {side + 1}", len, height);
            if (tmp.CanInstall(h.Walls[side].Length, h.Walls[side].Height))
            {
                h.HouseWindows[side] = tmp;
                h.HouseWindows[side+2] = new Window($"Окно {side + 1}", len, height);
                return true;
            }
            return false;
        }
        private bool MakeRoof(House h)
        {
            int len;
            int width;
            int height;

            Console.WriteLine($"Введите размеры крыши");
            while (true)
            {
                Console.Write("Длина: ");
                if (!int.TryParse(Console.ReadLine(), out len))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Ширина: ");
                if (!int.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Высота: ");
                if (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод");
                    continue;
                }
                break;
            }

            Roof tmp = new Roof("Крыша", len, width, height);
            if (tmp.CanInstall(h.Walls[0].Length, h.Walls[1].Length))
            {
                h.HouseRoof = tmp;
                return true;
            }
            return false;
        }
    }
}
