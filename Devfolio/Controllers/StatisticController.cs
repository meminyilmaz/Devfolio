using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Devfolio.Models;

namespace Devfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbDevFolioEntities db = new DbDevFolioEntities();
        public ActionResult StatisticList()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount=db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.serviceCount = db.TblService.Count(); //yeni 1
            ViewBag.addressCount = db.TblAddress.Count(); //yeni 2
            ViewBag.skillAvgValue = db.TblSkill.Average(x => x.SkillValue);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.firstServiceTitleName = db.GetFirstServiceTitle().FirstOrDefault();
            ViewBag.coreCategoryProjectCount=db.TblProject.Where(x=>x.ProjectCategory==1).Count();
            ViewBag.flutterCategoryProjectCount=db.TblProject.Where(x=>x.ProjectCategory==2).Count();
            return View();
        }
    }
}