using Product.Editor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Editor.Repository
{
    public class ProductProvider : IProductProvider
    {
        public void Delete(Guid productId)
        {
            ProductHelper.products.RemoveAll(p => p.Id == productId);
        }

        public ProductInfo Load(Guid productId)
        {
            return ProductHelper.products.FirstOrDefault(p => p.Id == productId);
        }

        public ProductInfo Load(string productId)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductInfo> LoadAllProduct(string pageSize, string pageIndex)
        {
            return ProductHelper.products.ToList();
        }

        public void Save(ProductInfo productInfo)
        {
            ProductHelper.products.Add(
               new ProductInfo()
               {
                   Id = Guid.NewGuid(),
                   Description = productInfo.Description,
                   DisplayPrice = productInfo.DisplayPrice,
                   Name = productInfo.Name,
                   Price = productInfo.Price,
                   QuantityAvailable = productInfo.QuantityAvailable

               });
        }
    }
}
