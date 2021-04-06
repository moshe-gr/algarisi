using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Manager : Worker
    {
        public Worker[] workers;
        public Manager(string name, int id, float salary, Worker[] workers) : base(name, id, salary)
        {
            this.workers = workers;   
        }
        public override void Print()
        {
            Console.WriteLine("\n");
            base.Print();
            Console.WriteLine("\nNum of workers: {0}.", workers.Length);
            foreach (Worker worker in workers)
            {
                worker.Print();
            }
        }
    }
}
