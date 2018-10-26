using System.Collections.Generic;

namespace Product.Editor.Model
{
    public class Variant
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Sku { get; set; }

        public string Price { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public string Width { get; set; }

        public string Depth { get; set; }

        public string Description { get; set; }

        public List<Image> Images { get; set; }
    }
}
