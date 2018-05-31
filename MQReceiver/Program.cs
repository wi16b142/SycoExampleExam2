using DataRepository;
using MQHandling;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQReceiver
{
    class Program
    {

        static void Main(string[] args)
        {
            MQHandler<XItem> mq = new MQHandler<XItem>("sycoexample2");
            DataHandler dh = new DataHandler();
            

            while (true)
            {
                var temp = mq.Receive();
                dh.AddItem(temp);
                Console.WriteLine("New Item received and added to DB: " + temp.Description + ", " + temp.Price + ", " + temp.Amount + ", " + temp.Category);
            }
        }
    }
}
