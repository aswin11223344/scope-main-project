using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
        public IActionResult Firsttimelogin()
        {


            return View();
        }
         public List<string> listemail = new List<string>();
        [HttpPost]
       
        public IActionResult Firsttimelogin(Flogin flogin) {
         
            SqlConnection FCON = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=scope_india_project;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            FCON.Open();

            SqlCommand cmd = new SqlCommand("SELECT EMAIL FROM Register WHERE EMAIL=@email",FCON);
            cmd.Parameters.AddWithValue("@email",flogin.Email);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) {
                    listemail.Add(reader.GetString(0));
                }
            }
            if (listemail.Count == 0)

            {
                ViewBag.msg = "Email is not Register ";
                return View();
            }
            else
            {
                return View("Flogin2");
            }
           
       }
        public IActionResult Flogin2()
        {
            if (HttpContext.Request.Cookies["Email"] != null)
            {

                return RedirectToAction("Reg");
            }
            else
            {
                return View();
            }
           
           
        }
        [HttpPost]
        public IActionResult Flogin2(Flogin2 flogin2)

        {
            Flogin flogin1 = new Flogin();
            if (flogin2.RememberMe) { 
            CookieOptions option=new CookieOptions();
                option.Expires= DateTime.Now.AddDays(1);
                HttpContext.Response.Cookies.Append("Email", flogin1.Email, option);
                HttpContext.Response.Cookies.Append("ConfirmPassword", flogin2.ConfirmPassword, option);
                return View();
            }
            else
            {
             
            }
            return View();
        }



    }
}
