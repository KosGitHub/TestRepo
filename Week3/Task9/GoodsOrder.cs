using System;
using System.Collections.Generic;

namespace Task9
{
    class GoodsOrder
    {
        private readonly ushort _storeLimit;
        public Goods Goods { get; set; }
        private ushort _count;
        public ushort Count
        {
            get { return _count; }
            set
            {
                if (value <= _storeLimit)
                {
                    _count = value;
                }
                else
                {
                    Messager.SendMessage(string.Format("There are not so much {0} in store! There are only {1}pc., but you specified {2}pc.", Goods.Name, _storeLimit, value));
                }
            }
        } // Counter for one king of goods in order

        public GoodsOrder(Goods goods, ushort count)
        {
            Goods = goods;
            _storeLimit = Store.GetGoodsStoreCount(Goods);
            Count = count;
            //Count = count;
        }
    }

    static class GoodsOrderExtenshion
    {
        public static string Print(this List<GoodsOrder> goods)
        {
            string resultString = string.Empty;
            foreach (var g in goods)
            {
                resultString += String.Format("{0} ({1}$) - {2}pc. = {3}$, ", g.Goods.Name, g.Goods.Price, g.Count, g.Goods.Price * g.Count);
            }
            return resultString.Trim(' ', ',');
        }
    }
}