using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Data
{
    public class SubCategory
    {
        public int id { get; set; }
        public int Id { get; internal set; }
        public string Name { get; set; }


        public string BannerImage { get; set; }
        public int MainCategoryId { get; set; }

        public MainCategory MainCategory { get; set; }

        public List<Product> Products { get; set; }
    }
}
