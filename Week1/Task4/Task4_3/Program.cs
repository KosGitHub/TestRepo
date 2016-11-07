using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Baggage> baggageList = new List<Baggage>()
            {
                new Baggage("John Baill", 3, 25.3f),
                new Baggage("Henry Johanson", 2, 15.2f),
                new Baggage("Linda Mall", 4, 32),
                new Baggage("Josh Milray", 1, 12.5f),
                new Baggage("Ben Floor", 2, 14.4f),
                new Baggage("Jan Goodjonsen", 1, 8.5f),
                new Baggage("Ann Heiry", 3, 21),
                new Baggage("Mariah Frank", 2, 16.7f),
            };
            Console.Write("Enter average weight limit, please:");
            float avgWeightLimit = 0;
            string consoleInput = Console.ReadLine();
            while (!float.TryParse(consoleInput, out avgWeightLimit) || float.Parse(consoleInput) <=0)
            {
                Console.Write("You must enter number more 0, try again please!\nEnter average weight limit, please: ");
                consoleInput = Console.ReadLine();
            }
            //First methot using LINQ
            //baggageList =
            //    baggageList.OrderBy(x => x.BaggageCount)
            //        .Where(x => x.BaggageWeight >= avgWeightLimit * x.BaggageCount)
            //        .ToList();
            //
            //Second method using my sorting and filtration
            baggageList.FilterBaggagesByWeight(avgWeightLimit);
            baggageList.Sort(new BaggageCountComparer());
            if (baggageList.Count>0)
            {
                foreach (var baggage in baggageList)
                {
                    Console.WriteLine(baggage.ToString());
                }    
            }
            else
            {
                Console.WriteLine("There are no baggages with average weight more than {0}", avgWeightLimit);
            }
            Console.ReadLine();
        }
    }
}
