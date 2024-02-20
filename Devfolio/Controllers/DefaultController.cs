using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.Mvc;
using Devfolio.Models;

namespace Devfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            
            return PartialView(values);
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();

            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();

            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values =db.TblService.ToList();
            return PartialView(values);

        }

        public PartialViewResult PartialStatistic()
        {

            var values = db.TblStatistic.ToList();
            return PartialView(values);

        }

        public PartialViewResult PartialPortfolio()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
            
        }

        public PartialViewResult PartialTestimonial()
        {

            var values =db.TblTestimonial.ToList();
            return PartialView(values);

        }

       [HttpGet]
        public PartialViewResult PartialMessage()
        {

            var values = db.TblContact.ToList();
            return PartialView(values);
        }

        [HttpPost]
       public PartialViewResult PartialMessage(TblContact p)
       {

           var value = db.TblContact.Add(p);

           value.NameSurname = p.NameSurname;
           value.Email = p.Email;
           value.Subject = p.Subject;
           value.Message = p.Message;
           value.IsRead=true;
           value.SendMessageDate=DateTime.Today;
           db.SaveChanges();
           return PartialView();
       }

       public PartialViewResult PartialAddress()
       {
            var values =db.TblAddress.ToList();
            return PartialView(values);
            
       }

       public PartialViewResult PartialSocialMedia()
       {
           var values = db.TblSocialMedia.ToList();
           return PartialView(values);

       }

    }
}