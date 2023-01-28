using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPI.Entities
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public string ImagePath { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
