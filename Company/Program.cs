using System;
using System.Collections.Generic;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager[] managers = new Manager[] {
                new Manager("a", 911, 10000, new Worker[] {
                    new Worker("w1", 9111, 5000),
                    new Worker("w2", 9112, 5500),
                    new Worker("w3", 9113, 5300),
                    new Worker("w4", 9114, 4000),
                    new Worker("w5", 9115, 6070),
                    new Worker("w6", 9116, 5003)
                }),
                new Manager("b", 812, 9000, new Worker[] {
                    new Worker("w1", 8111, 5000),
                    new Worker("w2", 8112, 5500),
                    new Worker("w3", 8113, 5300),
                    new Worker("w4", 8114, 4000),
                    new Worker("w5", 8115, 6070),
                    new Worker("w6", 8116, 5003),
                    new Worker("w7", 8117, 6000)
                }),
                new Manager("c", 713, 20000, new Worker[] {
                    new Worker("w1", 7111, 5000),
                    new Worker("w2", 7112, 5500),
                    new Worker("w3", 7113, 5300),
                    new Worker("w4", 7114, 4000),
                }),
                new Manager("d", 614, 18000, new Worker[] {
                    new Worker("w1", 6111, 5000),
                    new Worker("w2", 6112, 5500),
                    new Worker("w3", 6113, 5300),
                    new Worker("w4", 6114, 4000),
                    new Worker("w5", 6115, 6070),
                    new Worker("w6", 6116, 5003),
                    new Worker("w7", 6117, 5003),
                    new Worker("w8", 6118, 5003),
                    new Worker("w9", 6119, 5003),
                    new Worker("w10", 61110, 5003)
                })
            };
            Ceo ceo = new Ceo("ceo", 1, 70000, managers);
            ceo.Print();
            ceo.PrintManager();
        }
    }
}
