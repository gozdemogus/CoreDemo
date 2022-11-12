using System;
using System.Linq;
using System.Xml.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.ViewComponents
{
	public class Statistic1:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			BlogManager bm = new BlogManager(new EFBlogRepository());
			Context c = new Context();
			ViewBag.v1 = bm.GetList().Count;
			ViewBag.v2 = c.Contacts.Count();
			ViewBag.v3 = c.Comments.Count();
		//	string api = "afdcf90f4119a67a6614ffe47414b8df";
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=da9950905e00cf5be0122431eacd45a6";
			XDocument document = XDocument.Load(connection);
			ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			return View();
		}
	}
}

