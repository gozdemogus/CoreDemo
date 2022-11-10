using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        //sayfa yuklenir yuklenmez veritabanına kayit atilmasin diye
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //ekleme islemi yapilirken httpget ve httppost attributelerinin tanimlandigi metotlarin isimleri ayni olmalidir
        //httpget >> sayfa yuklenince
        //httppost >> sayfada buton tetiklenince
        //mesela HttpGet attributeu sayfada kategorize veya benzeri islemler kullanilirken sayfa yuklendigi anda listelenmesi
        //istenen niteliklerde kullanilabilir
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();

            ValidationResult results = wv.Validate(p);  
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                wm.TAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }  
            }
            return View();

         
        }
    }
}
