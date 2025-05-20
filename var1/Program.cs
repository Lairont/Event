using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Man man = new Man(i.ToString());
                man = new Man($"Человек {i}");
                Barrier.OpenEvent += man.OnBarrierOpen;
                Barrier.CloseEvent += man.OnBarrierClose;

                Barrier.RandomEvent(rnd.Next(1, 3));
            }
            Console.ReadLine();
        }
    }
}