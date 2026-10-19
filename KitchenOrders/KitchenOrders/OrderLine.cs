using System.Collections.Generic;

namespace KitchenOrders
{
    class OrderLine
    {
        public string Name;
        public int Qty;
        public List<string> Mods = new List<string>();
        public string Note = "";
    }
}
