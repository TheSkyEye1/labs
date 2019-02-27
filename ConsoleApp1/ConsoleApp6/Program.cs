using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        struct SStudent
        {
            public string fio;
            public int phys;
            public int math;
        }

        static void list(ref SStudent[] students)
        {
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine("{0}    Phys={1}     Math={2}", students[i].fio, students[i].phys, students[i].math);
            }
        }
        static void goodmark(ref SStudent[] students)
        {
            for(int i = 0; i<10; i++)
            {
                if(students[i].phys > 3 && students[i].math > 3)
                {
                    Console.WriteLine("{0}    Phys={1}     Math={2}", students[i].fio, students[i].phys, students[i].math);
                }
            }
        }
        static void onebad(SStudent[] students)
        {
            for(int i=0;i<10;i++)
            {
                if(students[i].phys < 4 || students[i].math < 4)
                {
                    Console.WriteLine("{0}    Phys={1}     Math={2}", students[i].fio, students[i].phys, students[i].math);
                }
            }
        }

        static void Main(string[] args)
        {
            SStudent[] students = new SStudent[10];
            Random rnd = new Random();
            int n;
            for (int i = 0; i < 10; i++)
            {
                
                students[i].fio = ("Sname" + i
                    );
                students[i].phys = rnd.Next(2, 6);
                students[i].math = rnd.Next(2, 6);
                
            }
            n = int.Parse(Console.ReadLine());
            switch (n)
                {
                    case 1:
                        {
                            list(ref students);
                            break;
                        }
                    case 2:
                        {
                            goodmark(ref students);
                                break;
                        }
                    case 3:
                        {
                            onebad(students);
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
