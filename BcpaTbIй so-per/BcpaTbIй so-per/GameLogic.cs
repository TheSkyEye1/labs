﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcpaTbIй_so_per
{
    class GameLogic
    {
       public int[,] gr;


        public bool tryer(int x, int y)
        {
            bool normal = true;

            if (x < 0 || x > gr.GetLength(0) - 1)
                normal = false;
            if (y < 0 || y > gr.GetLength(1) - 1)
                normal = false;

            int smolx = x - 1;
            if (smolx < 0)
                smolx = 0;
            int miny = y - 1;
            if (miny < 0)
                miny = 0;

            int bigix = x + 1;
            if (bigix > gr.GetLength(0) - 1)
                bigix = gr.GetLength(0) - 1;
            int maxy = y + 1;
            if (maxy > gr.GetLength(1) - 1)
                maxy = gr.GetLength(1) - 1;


            for (int i = smolx; i < bigix; i++)
            {
                for (int j = miny; j < maxy; j++)
                {
                    if (gr[i, j] == 0)
                    {
                        normal = false;
                        break;
                    }
                }
                if (normal == false)
                    break;
            }
            return normal;
        }
        public void sozdavator(int n)
        {
            gr = new int[n, n];
        }

        public void zakladka(int n, int tag)
        {
            if (n < 1) throw new Exception("Маловато мин");
            if (n >= 71) throw new Exception("Что-то ты переборщил с бомбами");

            Random nemayor = new Random();

            for(int i = 0; i<n; i++)
            {
                int x = nemayor.Next(0, gr.GetLength(0));
                int y = nemayor.Next(0, gr.GetLength(1));
                
                if (x*10+y == tag)
                {
                    i--;
                }
                else
                if(gr[x, y] == 9)
                {
                    i--;
                }
                else
                {
                    gr[x, y] = 9;
                };

                for (int h = 0; h < gr.GetLength(0); h++)
                {
                    for (int k = 0; k < gr.GetLength(1); k++)
                        if (tryer(x, y) == true)
                        {
                            gr[x, y] = 0;
                            i--;
                            break;
                        }
                    if (gr[x, y] == 0) break;
                }
            
            }
        }

        public void zapolnyator()
        {
            for (int i = 0; i < gr.GetLength(0); i++)
                for (int j = 0; j < gr.GetLength(1); j++)
                {
                    if (gr[i, j] == 0)
                    {
                        int smolx = i - 1;
                        if (smolx < 0) smolx = 0;
                        int miny = j - 1;
                        if (miny < 0) miny = 0;

                        int bigx = i + 1;
                        if (bigx > gr.GetLength(0) - 1) bigx = gr.GetLength(0) - 1;
                        int maxy = j + 1;
                        if (maxy > gr.GetLength(1) - 1) maxy = gr.GetLength(1) - 1;

                        int count = 0;

                        for (int h = smolx; h <= bigx; h++)
                        {
                            for (int n = miny; n <= maxy; n++)
                            {
                                if (gr[h, n] == 9)
                                {
                                    count++;
                                }
                            }

                        }
                        gr[i, j] = count;
                    }
                }

        }

        public void otkrivashka(int x, int y)
        {
            if(x>=0 && y>=0 && x< gr.GetLength(0) && y < gr.GetLength(1))
            {
                if(gr[x,y] == 0)
                {
                    gr[x, y] = 10;
                    otkrivashka(x - 1, y );
                    otkrivashka(x , y - 1);
                    otkrivashka(x + 1 , y);
                    otkrivashka(x , y + 1);
                }
            }
        }
        public int celler(int x, int y)
        {
            return gr[x, y];
        }

    }
}
