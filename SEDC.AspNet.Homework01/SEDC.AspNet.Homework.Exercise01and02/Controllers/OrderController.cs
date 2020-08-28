using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SEDC.AspNet.Homework.Exercise01and02.Controllers
{
    //***BONUS***
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //so shto i da zapisheme raboti
        [HttpGet("{id:alpha}/order/create-order")]
        public IActionResult CreateOrder()
        {
            return RedirectToAction("Index", "Home");
        }


        //ako treba da raboti samo so pizza
        /* [HttpGet("pizza/order/create-order")]
         public IActionResult CreateOrder()       
         {
             return RedirectToAction("Index","Home");
         }*/
    }
}
