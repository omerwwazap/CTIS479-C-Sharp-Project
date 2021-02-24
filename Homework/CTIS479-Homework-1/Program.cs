﻿using System;

namespace CTIS479_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Levent Durdalı - Homework 1");
            Console.WriteLine("************\n");

            //2.Add is-a relation between the classes
            //6.Override the base class method in the sub class and from the sub class overridden method, call the base class overridden method.
            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Levent", "Durdalı");
            retailSalesPerson.Sell();
            retailSalesPerson.Car_Develop();

            Console.WriteLine("\n************\n");

            RetailSalesPerson SalesPerson2 = new RetailSalesPerson("Levent", "Durdalı",50); // 9. Implement at least one method which has optional parameters
            SalesPerson2.Sell();
            SalesPerson2.Car_Develop();

            Console.WriteLine("\n************\n");
            Address a1 = new Address(addressLine: "Bilkent.....",city: "Ankara", state: "Ankara");
            Location isim1_Loc_now = new Location(0, 0);
            Buyer buys = new Buyer(lastName:"isim1",firstName:"isim2",address: a1, now: isim1_Loc_now); // 10.Call the methods by using the named arguments
            buys.GetFullname();
            buys.display();

            // Location of Car that is bought
            //13.Create at least one structure and use it in your application.
            Location skoda = new Location(500, 200);
            skoda.Display();



            Console.WriteLine("\n************\n");
            Re_Helper helper = new Re_Helper("Yardımcı1", "Yardımcı1");
            helper.Sell();



        }

        public static void Add(this Point a, Point b)
        {
            a.X += b.X;
            a.Y += b.Y;
        }


    }
}
