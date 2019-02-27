using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    { 
        static void swap(ref double a,ref  double b)
    {
            double c = a;
            a = b;
            b = c;
    }
    
        static void Main(string[] args)
        {
            double a = 10.103;
            double b = 19.00009;
            Console.Write("{0} {1}", a, b);
            swap(ref a,ref b);
            Console.Write("{0} {1}", a, b);
            Console.ReadKey();
        }
    }
}
