using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult GetAll()
        {
            List<Product> products = ProductSampleData.ProductList;
            return View("Display",products);
        }

        public IActionResult GetOne(int prdId)
        {
            Product prd = ProductSampleData.ProductList.FirstOrDefault(p=>p.Id == prdId);
            return View("Details", prd);
        }


        public string welcome()
        {
            return "Hello!!! from Welcome Action ";
        }

        public string Test()
        {
            return "Hello!!! from Test Action ";
        }

        public ContentResult WelcomeV02()
        {
          

            return Content("Hello!!! from WelcomeV02 Action");
        }

        public JsonResult TestJson()
        {
            JsonResult obj = new JsonResult(new { Id = 1, Name = "Hamada" });
            return obj;
        }
        public ViewResult TestView()
        {
          

            return View("MyView");
        }

        public IActionResult TestCondition()
        {
            if(DateTime.Now.Day == 10)
                return Content("Hello!!! from WelcomeV02 Action");
            else
                return View("MyView");
        }
       
    }
}
