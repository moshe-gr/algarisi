using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Ceo : Manager
    {
        public Ceo(string name, int id, float salary, Manager[] managers) : base(name, id, salary, managers)
        {
        }
        public override void Print()
        {
            base.Print();
        }
        public void PrintManager()
        {
            foreach (Manager manager in workers)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Salary: {2}.", manager.Name, manager.Id, manager.Salary);
            }
        }
    }
}
