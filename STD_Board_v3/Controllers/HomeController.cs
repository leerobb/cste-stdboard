using InMemoryContactData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STD_Board_v3.Controllers
{
    public class HomeController : Controller
    {
        IContactData db;

        public HomeController()
        {
            db = new InMemoryContactsData();
        }
        public ActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
        }
    }
}