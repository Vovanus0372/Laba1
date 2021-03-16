using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabotai
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int menu = 0;
                List<Count> counts = new List<Count>();
                do
                {
                Console.WriteLine("1. Добавить изделие");
                Console.WriteLine("2. Посмотреть изделия");
                menu = Convert.ToInt32(Console.ReadLine());
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Введите имя изделия");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите шифр изделия");
                            string shifr = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Введите колличество изделий");
                            int sum = Convert.ToInt32(Console.ReadLine());
                            counts.Add(new Count(name, shifr, sum));
                            break;
                        case 2:
                            Console.Write("Имя");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].name);
                            }
                            Console.WriteLine();
                            Console.Write("Шифр");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].shifr);
                            }
                            Console.WriteLine();
                            Console.Write("Колличество");
                            for (int i = 0; i < counts.Count; i++)
                            {
                                Console.Write(" " + counts[i].sum);
                            }
                            Console.ReadKey();
                            break;
                    }
                } while (menu < 3);
                Console.ReadKey();
            }
            catch { }

        }
    }
}
