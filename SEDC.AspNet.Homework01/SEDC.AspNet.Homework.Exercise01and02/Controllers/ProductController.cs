using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SEDC.AspNet.Homework.Exercise01and02.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-product/{id:int}")]
        public IActionResult GetProductById(int id)
        {
            var Product = new
            {
                Name = "Product_byID",
                Id = id
            };
            return Json(Product);
        }

        [HttpGet("get-product/{id:alpha}")]
        public IActionResult GetProductByName(string id)
        {
            var Product = new
            {
                Name = "Product_byName",
                Id = id
            };
            return Json(Product);
        }
    }
}
