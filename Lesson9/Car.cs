using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson9
{
    class Car
    {
        public string name;
        public bool needsWash;
        public Car(string name)
        {
            this.name = name;
            Thread thread = new Thread(new ThreadStart(Run));
            thread.Start();
        }
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(200);
                if (needsWash)
                {
                    Program.Wash(this);
                }
            }
        }
    }
}
