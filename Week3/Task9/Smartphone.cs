namespace Task9
{
    class Smartphone : Goods
    {
        public string OS { get; set; }
        public float ScreenDiagonal { get; set; }
        public string CoreName { get; set; }
        public static byte CoreCount { get; set; }

        public Smartphone(string name, float price, string os, float diagonal, string coreName, byte coreCount) 
            :base(name, price)
        {
            OS = os;
            ScreenDiagonal = diagonal;
            CoreName = coreName;
            CoreCount = coreCount;
        }
    }
}
