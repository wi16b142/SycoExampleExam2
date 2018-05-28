using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataRepository;
using Shared;

namespace ItemServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServiceItems : IServiceItems
    {
        DataHandler dh = new DataHandler();

        public string[] GetCategories()
        {
            return dh.GetCategories();
        }

        public List<XItem> QueryAllItems()
        {
            return dh.QueryAllItems();
        }
    }
}
