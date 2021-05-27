// Author: Pavel Dzhalev
// Created on 27 05 2021

using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : Controller
    {
        private static List<Product> _products = new List<Product>(new Product[]{
                new Product() {Id = 1, Name = "Notebook", Price = 100},
                new Product() {Id = 2, Name = "Laptop", Price = 200},
                new Product() {Id = 3, Name = "Phone", Price = 500}
            })
        ;

        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            return _products;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _products.SingleOrDefault(p => p.Id == id);
            
            if (product == null)
                return NotFound();

            _products.Remove(product);
            return Ok();
            
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            _products.Add(product);
            return CreatedAtAction(nameof(Get), new {product.Id});
        }
        
        [HttpPost("AddProduct")]
        public IActionResult PostBody([FromBody] Product product)
        {
            return Post(product);
        }
    }
}