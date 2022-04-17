using BLL.Concrete;
using BLL.Abstract;
using DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebIU.Models;
using Microsoft.AspNetCore.Identity;
using Entity.Concrete;

namespace WebIU.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(SignInManager<AppUser> signInManager)
        {
            _signInManager=signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View(new UserLoginModel());
        }

        [HttpPost]
        public IActionResult Login(UserLoginModel userLoginModel)
        {
            if (ModelState.IsValid)
            {
                var singInResult= _signInManager.PasswordSignInAsync(userLoginModel.UserName, userLoginModel.Password,
                    userLoginModel.RememberMe, false).Result;
                if (singInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı ya da şifre hatalı");
                }

            }
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }










    }
}