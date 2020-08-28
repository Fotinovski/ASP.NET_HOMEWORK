using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace SEDC.AspNet.Homework.Exercise01and02.Controllers
{
    [Route("homework/movie")]
    public class MovieController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("get-movies/{id:DateTime}")]
        public IActionResult GetMovieByDateTime(DateTime date)
        {
            date = DateTime.Now; //ako go nema ova kje dava nuli vo datumot
            var Movie = new { 
              Name = "Star Wars",
              id = date
            };
            return Json(Movie);
        }

       /* [HttpGet("get-movies/{id:DateTime}")]
        public IActionResult GetMovieByDateTime(DateTime date)
        {
            var Movie = new
            {
                Name = "FilmName",
                 id = date
             };
            return Json(Movie);
        }*/
              
        [HttpGet("get-available/{id:bool}")]
        public IActionResult IsAvailable(bool id)
        {
            var Movie = new
            {
                Name = id ? "Is_Available" : "Not_Available",  //simple if za ako e true ili false
                Id = id
            };
            return Json(Movie);
        }

    }
}
