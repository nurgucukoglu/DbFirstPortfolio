using PortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        DbPortofioEntities4 db= new DbPortofioEntities4();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AboutPartial()
        {
            var values = db.ProfileTbl.ToList();
            return PartialView(values);
        }

        public PartialViewResult AbilityPartial()
        {
            var values = db.AbilityTbl.ToList();
            return PartialView(values);
        }

        public PartialViewResult CertificatePartial()
        {
            var values = db.CertificateTbl.ToList();
            return PartialView(values);
        }

        public PartialViewResult BlogPartial()
        {
            var values = db.BlogTbl.ToList();
            return PartialView(values);
        }

        public PartialViewResult ContactPartial()
        {
            var values = db.ContactTable.ToList();
            return PartialView(values);
        }

    }
}