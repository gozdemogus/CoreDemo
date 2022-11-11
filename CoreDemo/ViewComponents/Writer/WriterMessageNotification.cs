﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p = "deneme@gmail.com";
            var values = mm.GetInboxListByWriter(p);
            return View(values);
        }
    }
}
