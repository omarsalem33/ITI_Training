using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            CompanyContext Db = new CompanyContext();
            // Model
            List<Department> Deptlist = Db.Departments.ToList();
            //  return View("GetAll" , Deptlist );
            return View("Index");
            
        }
    }
}
