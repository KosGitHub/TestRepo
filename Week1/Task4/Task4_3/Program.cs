using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    #region Baggage
    class Baggage
    {
        public string Fio { get; set; }
        public int BaggageCount { get; set; }
        public float BaggageWeight { get; set; }
        public Baggage(string fio, int baggageCount, float baggageWeight)
        {
            this.Fio = fio;
            this.BaggageCount = baggageCount;
            this.BaggageWeight = baggageWeight;
        }
        public override string ToString()
        {
            return String.Format("Fio: {0}, baggage count: {1}, baggage weight: {2}", Fio, BaggageCount, BaggageWeight);
        }
    }
    //My realization of Compare method for baggage comparing by count
    class BaggageCountComparer : IComparer<Baggage>
    {
        public int Compare(Baggage baggage1, Baggage baggage2)
        {
            if (baggage1.BaggageCount > baggage2.BaggageCount)
            {
                return 1;
            }
            if (baggage1.BaggageCount < baggage2.BaggageCount)
            {
                return -1;
            }
            return 0;
        }
    }

    static class BaggageExtension
    {
        //Extension method for filtration of BaggagesList by baggage weight
        public static void FilterBaggagesByWeight(this List<Baggage> baggageList, float avgWeightLimit)
        {
            List<Baggage> tempBaggageList = new List<Baggage>();
            foreach (var baggage in baggageList)
            {
                if (baggage.BaggageWeight >= avgWeightLimit * baggage.BaggageCount)
                {
                    tempBaggageList.Add(baggage);
                }
            }
            baggageList.Clear();
            baggageList.AddRange(tempBaggageList);
        }
    }
    #endregion
}
