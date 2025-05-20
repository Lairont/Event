using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Message();
    internal class Man
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Man(string name)
        {
            this.Name = name;
        }

        public void OnBarrierOpen()
        {
            Console.WriteLine($"{Name} иду");
            Barrier.OpenEvent -= OnBarrierOpen;
            Barrier.CloseEvent -= OnBarrierClose;
        }

        public void OnBarrierClose()
        {
            Console.WriteLine($"{Name} стою");
            Barrier.OpenEvent -= OnBarrierOpen;
            Barrier.CloseEvent -= OnBarrierClose;
        }
    }
}
