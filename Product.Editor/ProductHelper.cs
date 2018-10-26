using Product.Editor.Model;
using System;
using System.Collections.Generic;

namespace Product.Editor
{
    public static class ProductHelper
    {
        public static List<ProductInfo> products = new List<ProductInfo>
        {
            new ProductInfo()
            {
                Id=Guid.NewGuid(),
                Name="Metallic Sky",
                Description="Metallic Sky Ring Crossbody",
                DisplayPrice="$20.00",
                Images = new List<Image>
                {
                    new Image()
                    {
                        Id="10090",
                        Type="SmallImage",
                        Alt="Metallic Sky",
                        Url="/Product/MetallicSky.jpg"
                    }
                },
                Price="$25",
               QuantityAvailable="50",
               Variants = new List<Variant>
               {
                   new Variant()
                   {
                       Id="",
                       Name="",
                       Description="",
                       Price=""
                   }
               }
            }
        };
    }
}
