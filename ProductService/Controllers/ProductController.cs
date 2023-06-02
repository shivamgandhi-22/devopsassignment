using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public List<string> Get()
        {
            var productList = new List<string> { "Product 1", "Product 2", "Product 3" };
            return productList;
        }
        [HttpDelete]
        [Route("ProductVersion/{id}")]
        public string ProductVersion(int id)
        {
            return $"product with id{id} is removed";
        }
    }
}
