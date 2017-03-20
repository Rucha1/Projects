using Performance_evaluation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Performance_evaluation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult List(Performance performance)
        {
            ViewBag.Message = "Your contact page.";
            List<UserModel> listuser = new List<UserModel>();

            UserModel users = new UserModel();

            string name = Convert.ToString(Request["txtName"]);

            string designation = Convert.ToString(Request["txtDesignation"]);


            listuser.Add(new UserModel { Name = name, Designation = designation });

            return View("Newview");
        }
        public ActionResult Submitdata(Performance performance)
        {
            ViewBag.Message = "Your contact page.";

            return View("Newview");
        }
        public ActionResult Technicalskills(Performance performance)
        {
            ViewBag.Message = "Your contact page.";

            return View("Tskills");
        }
        public ActionResult Developerskills(Performance performance)
        {
            ViewBag.Message = "Your contact page.";

            return View("Dskills");
        }
        public ActionResult Savedata(Performance performance)
        {
            ViewBag.Message = "Your contact page.";

            return View("Index");
        }
        [HttpPost]
        public ActionResult Login()

        {

           

            return View("Index");

        }
      


    }
}