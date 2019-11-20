using System;
using static System.Console;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Write a C program to input electricity unit charges and calculate total electricity bill according to the given condition:
             For first 50 units Rs. 0.50 / unit
             For next 100 units Rs. 0.75 / unit
             For next 100 units Rs. 1.20 / unit
             For unit above 250 Rs. 1.50 / unit
             An additional surcharge of 20% is added to the bill
             */
                                                               

            //Define Variable

            double ConsumedUnits;
            double from150to250Units;
            double above250Units;
            double total;
            double Surcharges = 0.2;
            


            //User Input
            Console.Write("Enter your consumed units: ");
            ConsumedUnits = double.Parse(Console.ReadLine());

            //Condition
            if (ConsumedUnits <= 50)
            {
                total = ConsumedUnits * 0.5;
            }
            else if (ConsumedUnits <= 150)
            {
                total = (ConsumedUnits - 50) * 0.75 + (50 * 0.5);
            }
            else if (ConsumedUnits <= 250)
            {
                from150to250Units = ConsumedUnits - 150;
                total = (from150to250Units * 1.20) + (100 * 0.75) + (50 * 0.5);
            }
            else
            {
                above250Units = ConsumedUnits - 250;
                total = (above250Units * 1.5) + (100 * 1.20) + (100 * 0.75) + (50 * 0.5);
            }

            //total with surcharges
            double totalWithSurcharge = total + (total * Surcharges);


            //print
            Console.WriteLine("******************************************");
            Console.WriteLine("Your total bill amount is: $" + totalWithSurcharge);


            ReadLine();
        }
    }
}



