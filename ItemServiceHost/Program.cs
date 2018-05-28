using ItemServiceDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ItemServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceItems));
            host.Open();
            Console.WriteLine("Service Started.");
            Console.ReadLine();
        }
    }
}
