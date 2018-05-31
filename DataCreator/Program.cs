using MQHandling;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataCreator
{
    class Program
    {
        static SR_Categories.ServiceItemsClient client = new SR_Categories.ServiceItemsClient();
        static string[] categories = client.GetCategories();
        static Random rand = new Random();

        static void Main(string[] args)
        {
            MQHandler<XItem> mq = new MQHandler<XItem>("sycoexample2");

            while (true)
            {
                var temp = GetRandomItem();
                mq.Send(temp);
                Console.WriteLine("New Item sent: "+temp.Description+", "+temp.Price+", " + temp.Amount+", " + temp.Category);
                Thread.Sleep(5000);
            }
        }

        private static XItem GetRandomItem()
        {
            return new XItem(
                "Item"+rand.Next(),
                rand.Next(1,100000),
                rand.Next(0,100000),
                categories[rand.Next(0,categories.Length)]
                );
        }
    }
}
