using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Print nubmber of month");
            a = int.Parse(Console.ReadLine());
            a = (a-1) / 3;
            switch(a)
            {
                case 0:
                    {
                        Console.WriteLine("Winter");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Spring");
                            break;
                    }
                case 2:
                    {
                        Console.WriteLine("Summer");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Autmn");
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;

                    }
            }
            Console.ReadKey();
        }
    }
}
