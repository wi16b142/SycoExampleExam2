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

        public int AddItem(XItem item)
        {

            db.sbItem.Add(new sbItem()
            {
                Id = Guid.NewGuid(),
                Description = item.Description,
                Price = item.Price,
                Amount = item.Amount,
                fkCategory = GetCategoryByDescription(item.Category)[0]
            });
            return db.SaveChanges();
        }

        private List<Guid> GetCategoryByDescription(string description)
        {
            var query = from x in db.sbCategory
                        where x.Description.Equals(description)
                        select x.Id;
            return query.ToList();
        }
    }
}
