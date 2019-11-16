using System;
using static System.Console;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define Variable

            //double TotalElectricityBill;
            double ConsumedUnits;
            double from150to250Units;
            double above250Units;
            double total;
            double Surcharges = 0.2;
            


            //User Input
            
     
            Console.WriteLine("Consumed Units: ");
            ConsumedUnits = double.Parse(Console.ReadLine());

            //condition
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

            //total
            double totalWithSurcharge = total + (total * Surcharges);
            //surcharge
            //print
            Console.WriteLine("Your total Bill is: " + totalWithSurcharge);


            //Condition Check




            ReadLine();
        }
    }
}



