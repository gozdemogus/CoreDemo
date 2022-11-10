using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EFWriterRepository());


		[Authorize]
        public IActionResult Index()
		{
			return View();
		}

		public IActionResult WriterProfile() { return View(); }

        public IActionResult WriterMail() { return View(); }

		[AllowAnonymous]
        public IActionResult Test() { return View(); }

        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
		{
			return PartialView();
		}

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
		{
			return PartialView();
		}

		[AllowAnonymous]
		public IActionResult WriterEditProfile()
		{
		 var writervalues = wm.TGetById(1);
			return View(writervalues);
		}
    }
}
