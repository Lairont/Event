using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Barrier
    {
        public static event Message OpenEvent;
        public static event Message CloseEvent;

        public static void OnOpen()
        {
            Console.WriteLine("Открыто.");
            OpenEvent?.Invoke();
        }
        public static void OnClose()
        {
            Console.WriteLine("Закрыто.");
            CloseEvent?.Invoke();
        }
        public static void RandomEvent(int eventNum)
        {
            if (eventNum == 1)
                OnOpen();
            else if (eventNum == 2)
                OnClose();
        }
    }
}
