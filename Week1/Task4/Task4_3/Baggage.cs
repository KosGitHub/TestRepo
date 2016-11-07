using System;
using System.Collections.Generic;

namespace Task4_3
{
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
}
