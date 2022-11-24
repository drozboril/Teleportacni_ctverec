using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Teleportační_čtverec
{
    class Program
    {
        static void Main(string[] args)
        {
            Trida t = new Trida();
            Random rnd = new Random();
            Random b = new Random();
            for (int i = 0; i < 20; i++)
            {
                int x = rnd.Next(78);
                int y = rnd.Next(27);
                Console.ForegroundColor = (ConsoleColor)b.Next(14);
                t.Tisk(x, y);
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.SetWindowSize(80, 29);
            Console.Read();
        }
    }
    class Trida
    {
        public void Tisk(int x,int y)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i==0)
                {
                    Console.SetCursorPosition(x, y);
                }
                else
                {
                    Console.SetCursorPosition(x, y + 1);
                }
                for (int j = 0; j < 2; j++)
                {
                    
                    Console.Write("o");  
                }
                Console.WriteLine();
            }
        }
    }   
}