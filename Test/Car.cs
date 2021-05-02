using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    abstract class Car: ICanDrive
    {
        string color;
        string model;
        int id;
        abstract public int MaxSeats { get; }
        public Car(string color, string model, int id)
        {
            this.color = color;
            this.model = model;
            this.id = id;
        }

        public virtual bool CanDrive(Driver driver)
        {
            return driver.typeOfLisnce == GetType();
        }
    }
}
