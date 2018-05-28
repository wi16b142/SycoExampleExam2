using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class XItem
    {
        public XItem()
        {
        }

        public XItem(string description, int price, int amount, string category)
        {
            Description = description;
            Price = price;
            Amount = amount;
            Category = category;
        }

        public string Description { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string Category { get; set; }
    }
}
