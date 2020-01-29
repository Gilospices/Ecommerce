using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class MainCategory
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Name { get; set; }

        public ICollection<SubCategory> subCategories { get; set; }
    }
}
