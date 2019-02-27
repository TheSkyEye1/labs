using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int Rand(int min, int max)
        {
            int a;
            Random rnd = new Random();
            a = rnd.Next(min, max);
            return a;
        }
        static void Mas(int n, int m, int min, int max)
        {
            int[,] a = new int[n, m];
            for (int i = 0; i < n; n++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Rand(min, max);
            for (int i = 0; i < n; n++)
                for (int j = 0; j < m; j++)
                    Console.Write("{0}", a[i, j]);
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимум и максимум");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; n++)
                for (int j = 0; j < m; j++)
                    a[i, j] = Rand(min, max);
            for (int i = 0; i < n; n++)
                for (int j = 0; j < m; j++)
                    Console.Write("{0}", a[i, j]);
            Console.ReadKey();

        }
    }
}
