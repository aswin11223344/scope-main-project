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
                return View("Login");
            }
            else
            {
                return View();
            }
          

           


            
        }
       
      
    }
}
