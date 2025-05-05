using BasicApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicApp.Controllers
{


   public  class CourseController : Controller
    {

        public IActionResult Index(){

            return View("Index");
        }


        public IActionResult Apply(){

            return View();
        }

        [HttpPost]
        public IActionResult Apply(Course model){

            Repository.Add(model);
            return View();
        }

         public IActionResult Update(Course model){

            Repository.Add(model);
            return View();
        }

    }
    
}