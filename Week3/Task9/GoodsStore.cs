namespace Task9
{
    class GoodsStore
    {
        public Goods Goods { get; set; }
        public ushort Count { get; set; }

        public GoodsStore(Goods goods, ushort count)
        {
            Goods = goods;
            Count = count;
        }
    }
}
