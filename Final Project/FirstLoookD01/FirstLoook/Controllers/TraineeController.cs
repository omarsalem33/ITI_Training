using FirstLoook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstLoook.Controllers
{
    public class TraineeController : Controller
    {
        CollegeContext Db = new CollegeContext();
        public IActionResult GettAll()
        {
            //Model
            List<Trainee> DeptList = Db.Trainees.ToList();
            return View(DeptList);

        }
        public IActionResult getOne(int id)
        {
            Trainee dept = Db.Trainees.FirstOrDefault(d => d.Id == id);
            return View(dept);
        }
    }
}
