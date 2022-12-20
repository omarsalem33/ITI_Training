using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class DepartmentController : Controller
    {
        CollegeContext Db=new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Department> DeptList = Db.Departments.ToList();
            return View(DeptList); 

        }
        public IActionResult getOne(int id)
        {
            Department dept = Db.Departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
        public IActionResult getEmp(int id)
        {
            Department dept = Db.Departments.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }

    }
}
