using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car("BMW X6", "BI0007PO", "Polyovyi K.M.", 2012, 80530),
                new Car("AUDI A8", "BO3464PO", "Nosov A.Y.", 2015, 45370),
                new Car("Renault Kangoo", "BI3544XA", "Golovenko S.A.", 2008, 134744),
                new Car("Citroen Berlingo", "BR1289PO", "Begma L.P.", 2009, 110705),
                new Car("Daewoo Lanos", "BI7220XA", "Bezruk B.D.", 2014, 97300),
                new Car("Mitsubishi LancerX", "MN1212XI", "Kotova A.L.", 2014, 34712),
                new Car("Mazda 6", "BI0708PO", "Step K.A.", 2005, 178940),
                new Car("VAZ 2199", "BO7895XA", "Moroz T.S.", 2007, 110314),
                new Car("Chevrolet Aveo", "BI4478PO", "Chuba R.G.", 2011, 56804),
            };
            Console.WindowWidth = 100;
            Console.Write("Enter a minimum year of purchase:");
            ushort purchaseYear = 0;
            while (!ushort.TryParse(Console.ReadLine(), out purchaseYear))
            {
                Console.WriteLine("You must enter positive number, try again please!\nEnter a minimum year of purchase: ");
            }
            //First methot using LINQ
            //cars = 
            //    cars.OrderBy(car => car.Mileage)
            //    .Where(car => car.PurchaseYear < purchaseYear)
            //    .ToList();
            //
            //Second method using my sorting and filtration
            cars.FilterCarByPurchaseYear(purchaseYear);
            cars.Sort(new CarComparerByMileage());
            if (cars.Count>0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car.ToString());
                }    
            }
            else
            {
                Console.WriteLine("There are no cars older than {0}", purchaseYear);
            }
            Console.ReadLine();
        }
    }
}
