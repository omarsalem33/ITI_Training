using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class ResutlController : Controller
    {
        public IActionResult GettAll()
        {
            CollegeContext Db = new CollegeContext();
            //Model
            List<CrsResult> DeptList = Db.Results.ToList();
            return View(DeptList);

        }
    }
}
