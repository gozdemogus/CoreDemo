using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
            p.WriterStatus = true;
            p.WriterAbout = "Deneme Test";
            wm.WriterAdd(p);    
            return RedirectToAction("Index","Blog");
        }
    }
}
