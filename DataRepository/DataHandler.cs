using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class DataHandler
    {
        syco_trainingEntities db;

        public DataHandler()
        {
           db = new syco_trainingEntities();
        }

        public List<XItem> QueryAllItems()
        {
            var query = from x in db.sbItem
                        select new XItem()
                        {
                            Description = x.Description,
                            Price = (int)x.Price,
                            Amount = (int)x.Amount,
                            Category = x.sbCategory.Description
                        };

            return query.ToList();
        }

        public string[] GetCategories()
        {
            return db.sbCategory.Select(x => x.Description).ToArray();
        }

        //add item


    }
}
