using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public string model;
        public double price;
        public Color color;
        public Car()
        {

        }
        public Car(string model, double price, Color color)
        {
            this.model = model;
            this.price = price;
            this.color = color;
        }
        public override string ToString()
        {
            return "Car model: " + model + ", Price: " + price + ", " + color;
        }
    }
}
