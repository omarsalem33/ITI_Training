using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class InstructorController : Controller
    {
        CollegeContext Db = new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Instructor> DeptList = Db.Instructors.ToList();
            return View(DeptList);

        }
        public IActionResult getOne(int id)
        {
            Instructor dept = Db.Instructors.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
    }
}
