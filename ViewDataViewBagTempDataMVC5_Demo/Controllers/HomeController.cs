using System.Linq;
using System.Web.Mvc;
using ViewDataViewBagTempDataMVC5_Demo.Data;

namespace ViewDataViewBagTempDataMVC5_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewDataExample()
        {
            ViewData["Employees"] = db.Employees.ToList();
            return View();
        }

        public ActionResult ViewBagExample()
        {
            ViewBag.Employee = db.Employees.ToList();
            return View();
        }

        public ActionResult TempDataExample()
        {
            TempData["Employees"] = db.Employees.ToList();
            return View();
        }
    }
}