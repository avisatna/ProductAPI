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
               Name= "OnePlus 6T",
               Description= "New OnePlus Mobile Phone",
               Price="$550",
               DisplayPrice= "$540.00",
               QuantityAvailable= "610",
               Images = new List<Image>
               {
                   new Image()
                   {
                        Type ="SmallImage",
                        Alt= "OnePlus 6T",
                        Url="/Product/OnePlus6TSmall.jpg"
                   },
                   new Image()
                   {
                        Type= "LargeImage",
                        Alt="OnePlus 6T",
                        Url= "/Product/OnePlus6TLarge.jpg"
                   }
               },
               Variants= new List<Variant>
                {
                    new Variant()
                    {
                        Name= "OnePlus 6T Silver White",
                        Sku= "I9899",
                        Price= "$550",
                        Weight= "149gm",
                        Height= "6.0",
                        Width= "2.1",
                        Depth= "0.56",
                        Description="OnePlus 6T Silver White",
                        Images= new List<Image>()
                        {
                            new Image()
                            {
                                Type= "SmallImage",
                                Alt= "OnePlus 6T Silver White",
                                Url="/Product/OnePlus6TSmallSilver White.jpg"
                            },
                            new Image()
                            {
                                Type="LargeImage",
                                Alt= "OnePlus 6T",
                                Url= "/Product/OnePlus6TLargeSilverWhite.jpg"
                            }
                        }
                    }
                }
            },
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
                        Type="LargeImage",
                        Alt="Metallic Sky",
                        Url="/Product/MetallicSky.jpg"
                    },
                    new Image()
                    {
                        Type="SmallImage",
                        Alt="Metallic Sky",
                        Url="/Product/MetallicSkySmall.jpg"
                    }
                },
                Price="$25",
                QuantityAvailable="50",
                Variants = new List<Variant>
                {
                    new Variant()
                    {
                        Name="Metallic Sky Blue",
                        Description="Metallic Sky Blue",
                        Price="$21",
                        Images= new List<Image>()
                        {
                            new Image()
                            {
                                Type="LargeImage",
                                Alt="Metallic Sky Blue",
                                Url="/Product/MetallicSkyBlue.jpg"
                            },
                            new Image()
                            {
                                Type="SmallImage",
                                Alt="Metallic Sky Blue",
                                Url="/Product/MetallicSkyBlueSmall.jpg"
                            }
                        }
                    }
                }
            }
        };
    }
}
