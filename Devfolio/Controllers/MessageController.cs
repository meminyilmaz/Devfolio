using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Devfolio.Models;

namespace Devfolio.Controllers
{
    public class MessageController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult MessageList()
        {
            var values = db.TblContact.ToList();

            return View(values);
        }

        [HttpGet]
        public ActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CreateMessage(TblContact p)
        {
            db.TblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("MessageList");
            
        }

        public ActionResult DeleteMessage(int id)
        {
            var value =db.TblContact.Find(id);
            db.TblContact.Remove(value);
            db.SaveChanges();
            return RedirectToAction("MessageList");
        }

        [HttpGet]
        public ActionResult UpdateMessage(int id)
        {
            var value=db.TblContact.Find(id);
            return View(value);
            
        }

        [HttpPost]
        public ActionResult UpdateMessage(TblContact p)
        {
            var value=db.TblContact.Find(p.ContactID);
            value.NameSurname = p.NameSurname;
            value.Email=p.Email;
            value.Subject=p.Subject;
            value.Message=p.Message;
            value.IsRead=p.IsRead;
            value.SendMessageDate=p.SendMessageDate;
            db.SaveChanges();
            return RedirectToAction("MessageList");

        }
    }
}