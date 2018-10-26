using System;
using System.Collections.Generic;

namespace Product.Editor.Model
{
    public class ProductInfo
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Price { get; set; }

        public string DisplayPrice { get; set; }

        public string  QuantityAvailable { get; set; }

        public List<Image> Images { get; set; }

        public List<Variant> Variants { get; set; }
    }
}
