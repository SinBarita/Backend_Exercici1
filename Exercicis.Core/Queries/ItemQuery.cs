using System.Collections.Generic;
using System.Linq;
using Exercicis.Contracts.Domain.Items;

namespace Exercicis.Core.Queries
{
    public class ItemQuery
    {
        public ItemQuery() { }

        public IEnumerable<AItem> GetItems()
        {
            return MockDatabase.Items;
        }

        public AItem GetItemById(int id)
        {
            return MockDatabase.Items.SingleOrDefault(i => i.Id == id);
        }        
    }
}
