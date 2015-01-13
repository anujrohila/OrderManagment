using OrderManagement.Web.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;

namespace OrderManagement.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            HomePageModel homePageModel = new HomePageModel();
            homePageModel.Students = GetStudent();

            return View(homePageModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [GridAction]
        public ActionResult ListAllStudentAjax()
        {
            return View(new GridModel { Data = GetStudent() });
        }


        private List<Student> GetStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { RollNo = 1, Name = "Anuj Rohila", Mark1 = 90, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 2, Name = "Jayesh", Mark1 = 91, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 3, Name = "Kamlesh", Mark1 = 92, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 4, Name = "Bhargav", Mark1 = 93, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 5, Name = "Nisarg", Mark1 = 94, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 6, Name = "Jinal", Mark1 = 85, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 7, Name = "Rajesh", Mark1 = 75, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 8, Name = "Devagana", Mark1 = 52, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 9, Name = "Nimmi", Mark1 = 100, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 10, Name = "Priyanka", Mark1 = 90, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 11, Name = "Zakir", Mark1 = 90, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 12, Name = "Moshin", Mark1 = 90, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 13, Name = "Kiran", Mark1 = 90, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 14, Name = "Naresh", Mark1 = 90, Mark2 = 91, Result = 100 });
            students.Add(new Student { RollNo = 14, Name = "Mahesh", Mark1 = 90, Mark2 = 91, Result = 100 });
            return students;
        }
    }
}
