using System;
using System.Collections.Generic;

namespace Task9
{
    class Store
    {
        public static List<GoodsStore> GoodsStore { get; set; }

        public Store(List<GoodsStore> goodsStore)
        {
            GoodsStore = new List<GoodsStore>();
            GoodsStore.AddRange(goodsStore);
        }

        // Method whisc show how many current goods in Store - needed for GoodsOrder
        public static ushort GetGoodsStoreCount(Goods goods)
        {
            ushort result = 0;
            bool found = false;
            while (!found)
            {
                foreach (var goodsStore in GoodsStore)
                {
                    if (goodsStore.Goods == goods)
                    {
                        result = goodsStore.Count;
                        found = true;
                        break;
                    }
                }
            }
            return result;
        }

        // Method for recalculation of goods in store 
        public static void GoodsRecalculate(object sender, OrderEventArgs e)
        {
            foreach (var gOrder in e.Order.Goods)
            {
                foreach (var gStore in GoodsStore)
                {
                    if (gStore.Goods == gOrder.Goods)
                    {
                        gStore.Count -= gOrder.Count;
                    }
                }
            }
        }
    }
}
