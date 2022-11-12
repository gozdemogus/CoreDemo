using System;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
	public class Statistic4 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new EFBlogRepository());
            ViewBag.v1 = c.Admins.Where(x => x.AdminID == 1).Select(y => y.UserName).FirstOrDefault();
          ViewBag.v2=c.Admins.Where(x=>x.AdminID==1).Select(y => y.ImageURL).FirstOrDefault();
            ViewBag.v3 = c.Admins.Where(x => x.AdminID == 1).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}

