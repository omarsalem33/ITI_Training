using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class DepartmentController : Controller
    {
        CompanyContext Db = new CompanyContext(); 
        
        public IActionResult Index()
        {
            List<Department> DeptList = Db.Departments.ToList();
            return View(DeptList); 
        }
        public IActionResult Details(int id)
        {
            Department dept = Db.Departments.FirstOrDefault(d=> d.Id == id);  
            return View(dept);  
        }
    }
}
