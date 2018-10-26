using Product.Editor.Model;
using System;
using System.Collections.Generic;

namespace Product.Editor.Repository
{
    public interface IProductProvider
    {
        /// <summary>
        /// Read the data from repository
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        ProductInfo Load(Guid productId);

        /// <summary>
        /// Read all product from repostory
        /// </summary>
        /// <returns></returns>
        List<ProductInfo> LoadAllProduct(string pageSize, string pageIndex);

        /// <summary>
        /// Save the data in repository
        /// </summary>
        /// <param name="productInfo"></param>
        /// <returns></returns>
        void Save(ProductInfo productInfo);

        /// <summary>
        /// Delete the data from repository
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        void Delete(Guid productId);
    }
}
