namespace Task9
{
    abstract class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
