using Microsoft.AspNetCore.Mvc;
using project_ScopeIndia.model;
using project_ScopeIndia.Models;

namespace project_ScopeIndia.Controllers
{
  
    public class LoginController : Controller
    {
        public readonly Mydbcontext Mydbcontext;
        public LoginController(Mydbcontext mydbcontext)
        {
            Mydbcontext = mydbcontext;


        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login objlogin)
        { 
        
        
          return View();
        }
        public IActionResult Firsttimelogin()
        {


            return View();
        }
      
        [HttpPost]
       
        public IActionResult Firsttimelogin(Flogin flogin) {

            var obj = Mydbcontext.ScopeTables.FirstOrDefault(a=>a.Email==flogin.Email);
            if (obj != null)
            {
                return RedirectToAction("Flogin2");
            }
            else
            {
                ViewBag.msg = "Email doesn t exist";
                return View("FirsttimeLogin");
            }
           
       }
        public IActionResult Flogin2()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Flogin2(Flogin2 flogin2)

        {
            Flogin flogin1 = new Flogin();
           
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }



    }
}
/*if (flogin2.RememberMe)
{
    CookieOptions option = new CookieOptions();
    option.Expires = DateTime.Now.AddDays(1);
    HttpContext.Response.Cookies.Append("Email", flogin1.Email, option);
    HttpContext.Response.Cookies.Append("ConfirmPassword", flogin2.ConfirmPassword, option);
    return View();
}
else
{

}*/