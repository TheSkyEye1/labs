using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void stest(int a)
        {
            int j = 0;
            for(int i=1;i<(a/2);i++)
            {
                if(a%i==0)
                {
                    j++;
                }
            }
            if(j>1)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }

        static void sprint(ref int a)
        {
            int b = 0;
            for (int i = 1; i < a; i++)
            {
                for (int j = 1; j < (i/2)+1; j++)
                {
                    if (i%j == 0)
                    {
                        b++;
                    }
                }
                if(b>1)
                {
                    Console.Write(" {0}", i);
                }
                b = b - b;
            }
        }
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            stest(a);
            Console.WriteLine();
            sprint(ref a);
            Console.ReadKey();

        }
    }
}
