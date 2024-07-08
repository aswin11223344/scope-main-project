using Microsoft.AspNetCore.Mvc;
using project_ScopeIndia.Models;

namespace project_ScopeIndia.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login objlogin)
        { 
        
        
          return View();
        }
    }
}
