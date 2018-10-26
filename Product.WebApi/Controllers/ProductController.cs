using Microsoft.AspNetCore.Mvc;
using Product.Editor.Repository;
using System;
using System.Collections.Generic;
using Product.Editor.Model;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductProvider _provider;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider"></param>
        public ProductController(IProductProvider provider)
        {
            _provider = provider;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<ProductInfo>> Get()
        {
            return _provider.LoadAllProduct("10","1");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ProductInfo> Get(Guid id)
        {
            return _provider.Load(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] ProductInfo productInfo)
        {
            _provider.Save(productInfo);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _provider.Delete(id);
        }
    }
}
