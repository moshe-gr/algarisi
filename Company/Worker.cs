using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Worker
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private float salary;

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public Worker(string name, int id, float salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: {0}, Salary: {1}.", Name, Salary);
        }
    }
}
