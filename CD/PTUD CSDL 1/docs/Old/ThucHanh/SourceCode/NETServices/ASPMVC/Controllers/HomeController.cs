using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVC.EmployeeServices;
namespace ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getdata()
        {
            EmployeeSerClient client = new EmployeeSerClient();
            NhanVien[] lst = client.getall();
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getall()
        {
            List<Product> lst = new List<Product>();
            lst.Add(new Product { name = "TV", price = 10, quantity=2 });
            lst.Add(new Product { name = "Tu lanh", price = 20, quantity=1 });

            return View(lst);
        }

    }
}
