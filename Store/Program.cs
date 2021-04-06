﻿using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodProduct p1 = new BakeryGoods("Bread", 7, "000-6546-55", new Date(3, 4, 2021));
            FoodProduct p2 = new Dairy("Milk", 5, "000-7669-16", new Date(30, 3, 2021));
            FoodProduct p3 = new FruAndVegs("Tomato", 2, "000-6546-55", new Date(28, 3, 2021));
            FoodProduct p4 = new Meaty("Steak", 100, "000-9732-82", new Date(3, 7, 2021));
            FoodProduct p5 = new BakeryGoods("Bread", 7, "000-6546-55", new Date(3, 4, 2021));
            FoodProduct p6 = new Canned("Beans", 4, "000-5434-98", new Date(26, 12, 2021));
            FoodProduct p7 = new Dairy("Chease", 6, "000-6543-65", new Date(3, 4, 2021));
            FoodProduct p8 = new FruAndVegs("Banana", 7, "000-3765-82", new Date(3, 4, 2021));
            FoodProduct p9 = new Meaty("Liver", 7, "000-6239-05", new Date(1, 2, 2022));
            FoodProduct p10 = new BakeryGoods("Baget", 4, "000-6536-55", new Date(2, 4, 2021));
            FoodProduct p11 = new Canned("Mushrooms", 7, "000-6546-55", new Date(17, 6, 2021));
            FoodProduct p12 = new Dairy("Butter", 7, "000-5432-98", new Date(15, 5, 2021));
            FoodProduct p13 = new FruAndVegs("Potato", 4, "000-9597-11", new Date(1, 4, 2021));
            FoodProduct p14 = new Meaty("Chicken", 25, "000-9146-55", new Date(8, 5, 2021));
            FoodProduct p15 = new BakeryGoods("Buns", 4, "000-5434-98", new Date(26, 12, 2021));
            FoodProduct p16 = new Canned("Corn", 5, "000-6546-55", new Date(3, 4, 2021));
            FoodProduct p17 = new Dairy("Cream chease", 7, "000-6546-55", new Date(3, 4, 2021));
            FoodProduct p18 = new FruAndVegs("Onion", 10, "000-6546-55", new Date(3, 4, 2021));
            FoodProduct p19 = new Meaty("Meat", 54, "000-6546-55", new Date(3, 4, 2021));
            FoodProduct p20 = new Canned("Beans", 4, "000-5434-98", new Date(26, 12, 2021));
            HomeProduct p21 = new Cleaning("Broom", 5, "000-5432-65", 0);
            HomeProduct p22 = new Elec("Fan", 105, "000-5432-65", 2);
            HomeProduct p23 = new Pots("Pan", 55, "000-5432-65", 1);
            HomeProduct p24 = new Cleaning("Dust pan", 5, "000-5432-65", 0);
            HomeProduct p25 = new Elec("Vacume", 5, "000-5432-65", 5);
            HomeProduct p26 = new Pots("Soltam", 5, "000-5432-65", 2);
            HomeProduct p27 = new Cleaning("Brush", 5, "000-5432-65", 0);
            HomeProduct p28 = new Pots("Pot", 5, "000-5432-65", 1);
            HomeProduct p29 = new Elec("Ninga", 5, "000-5432-65", 10);
            HomeProduct p30 = new Cleaning("Spunge", 3, "000-5432-65", 0);
            HomeProduct p31 = new Elec("Toaster", 45, "000-5432-65", 2);
            HomeProduct p32 = new Pots("Wak", 69, "000-5432-65", 1);
            CleaningProduct p33 = new Dishes("Fairy", 4, "000-5434-98", new Date(26, 12, 2022));
            CleaningProduct p34 = new Floors("Fantastic", 4, "000-5434-98", new Date(12, 8, 2022));
            CleaningProduct p35 = new Laundry("Persil", 4, "000-5434-98", new Date(2, 10, 2022));
            CleaningProduct p36 = new Dishes("Soap", 4, "000-5687-98", new Date(1, 1, 2023));
            CleaningProduct p37 = new Floors("Ajax", 4, "000-3249-58", new Date(30, 12, 2021));
            CleaningProduct p38 = new Laundry("Ariel", 35, "000-5214-98", new Date(26, 12, 2021));
            CleaningProduct p39 = new Dishes("Sant moritz", 4, "000-9464-92", new Date(3, 5, 2023));
            CleaningProduct p40 = new Floors("Clean", 4, "000-5434-98", new Date(26, 12, 2021));
            CleaningProduct p41 = new Laundry("Oxigen", 14, "000-474-98", new Date(17, 12, 2023));
            CleaningProduct p42 = new Dishes("Dish wash", 4, "000-5434-98", new Date(26, 12, 2021));
            CleaningProduct p43 = new Floors("Sano floor", 4, "000-5434-98", new Date(26, 12, 2021));
            CleaningProduct p44 = new Laundry("Landry soap", 4, "000-5434-98", new Date(26, 12, 2021));

            p1.NeedsRef = false;
            p2.NeedsRef = true;
            p3.NeedsRef = false;
            p4.NeedsRef = true;
            p5.NeedsRef = false;
            p6.NeedsRef = false;
            p7.NeedsRef = true;
            p8.NeedsRef = false;
            p9.NeedsRef = true;
            p10.NeedsRef = false;
            p11.NeedsRef = false;
            p12.NeedsRef = true;
            p13.NeedsRef = false;
            p14.NeedsRef = true;
            p15.NeedsRef = false;
            p16.NeedsRef = false;
            p17.NeedsRef = true;
            p18.NeedsRef = false;
            p19.NeedsRef = true;
            p20.NeedsRef = false;
            p21.Breakable = false;
            p22.Breakable = true;
            p23.Breakable = false;
            p24.Breakable = false;
            p25.Breakable = true;
            p26.Breakable = false;
            p27.Breakable = false;
            p28.Breakable = false;
            p29.Breakable = true;
            p30.Breakable = false;
            p31.Breakable = true;
            p32.Breakable = true;
            p33.IsToxic = false;
            p34.IsToxic = true;
            p35.IsToxic = false;
            p36.IsToxic = true;
            p37.IsToxic = true;
            p38.IsToxic = false;
            p39.IsToxic = true;
            p40.IsToxic = true;
            p41.IsToxic = true;
            p42.IsToxic = false;
            p43.IsToxic = true;
            p44.IsToxic = true;

            List<Product> products = new List<Product>();

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);
            products.Add(p6);
            products.Add(p7);
            products.Add(p8);
            products.Add(p9);
            products.Add(p10);
            products.Add(p11);
            products.Add(p12);
            products.Add(p13);
            products.Add(p14);
            products.Add(p15);
            products.Add(p16);
            products.Add(p17);
            products.Add(p18);
            products.Add(p19);
            products.Add(p20);
            products.Add(p21);
            products.Add(p22);
            products.Add(p23);
            products.Add(p24);
            products.Add(p25);
            products.Add(p26);
            products.Add(p27);
            products.Add(p28);
            products.Add(p29);
            products.Add(p30);
            products.Add(p31);
            products.Add(p32);
            products.Add(p33);
            products.Add(p34);
            products.Add(p35);
            products.Add(p36);
            products.Add(p37);
            products.Add(p38);
            products.Add(p39);
            products.Add(p40);
            products.Add(p41);
            products.Add(p42);
            products.Add(p43);
            products.Add(p44);

            Stocker.SetProducts(products);
            Shop.Print();
        }
    }
}
