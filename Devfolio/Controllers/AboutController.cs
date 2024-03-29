﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Devfolio.Models;
using Microsoft.Ajax.Utilities;

namespace Devfolio.Controllers
{
    public class AboutController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(TblAbout p)
        {
            db.TblAbout.Add(p);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value=db.TblAbout.Find(id);
            return View(value);
        }
    }
}