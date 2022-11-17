﻿using CoreDemo.Models;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    return RedirectToAction("Index","Login");
                }
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }

    }
}



/*  CLAIMS
 *  
 *  [HttpPost]
      public async Task<IActionResult> Index(Writer p)
      {
          Context c = new Context();
          var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
          if(datavalue != null)
          {
              var claims = new List<Claim>
              {
                  new Claim(ClaimTypes.Name,p.WriterMail)
              };
              var useridentity=new ClaimsIdentity(claims,"a");    
              ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);
              await HttpContext.SignInAsync(claimsPrincipal);
              return RedirectToAction("Index", "Dashboard");
          }
          else
          {
              return View();

          }

      }*/



//SESSION
//Context c = new Context();
//var datavalue = c.Writers.FirstOrDefault(x=>x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
//if(datavalue != null)
//{
//    HttpContext.Session.SetString("username", p.WriterMail);
//    return RedirectToAction("Index","Writer");   
//}
//else
//{
//    return View();

//}