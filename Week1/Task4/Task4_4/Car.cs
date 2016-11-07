using System;
using System.Collections.Generic;


namespace Task4_4
{
    class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public string Owner { get; set; }
        public ushort PurchaseYear { get; set; }
        public int Mileage { get; set; }

        public Car(string model, string number, string owner, ushort purchaseYear, int mileage)
        {
            this.Model = model;
            this.Number = number;
            this.Owner = owner;
            this.PurchaseYear = purchaseYear;
            this.Mileage = mileage;
        }
        public override string ToString()
        {
            return string.Format("Car {0}, number {1}, owner {2}, year og purchace {3}, mileage {4}",
                Model, Number, Owner, PurchaseYear, Mileage);
        }
    }
    //My realization of Compare method for cars comparing by mileage
    class CarComparerByMileage : IComparer<Car>
    {
        public int Compare(Car car1, Car car2)
        {
            if (car1.Mileage > car2.Mileage)
            {
                return 1;
            }
            if (car1.Mileage < car2.Mileage)
            {
                return -1;
            }
            return 0;
        }
    }
    static class CarExtension
    {
        //Extension method for filtration of cars by year of purchase
        public static void FilterCarByPurchaseYear(this List<Car> cars, ushort purchaceYear)
        {
            List<Car> tempCars = new List<Car>();
            foreach (var car in cars)
            {
                if (car.PurchaseYear < purchaceYear)
                {
                    tempCars.Add(car);
                }
            }
            cars.Clear();
            cars.AddRange(tempCars);
        }
    }
}
