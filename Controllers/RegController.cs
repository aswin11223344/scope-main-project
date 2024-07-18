using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using project_ScopeIndia.Models;

namespace project_ScopeIndia.Controllers
{
    public class RegController : Controller
    {
        public IActionResult Reg()
        {
            return View();
        }
        [BindProperty]
        public List<string> Hobbies { get; set; }
        string hobbies;
      
        [HttpPost]
        public IActionResult Reg(Reg objr)
        {
          

           
                if (Hobbies != null && Hobbies.Count > 0)
                {
                    foreach (var item in Hobbies)
                    {
                        hobbies += item + ";";
                    }
                }

                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=scope_india_project;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Register(Name,Age,Country,State,City,PhoneNo,Email,Gender,Hobbies) values(@name,@age,@country,@state,@city,@phonenumber,@email,@gender,@hobbies)", con);
                cmd.Parameters.AddWithValue("@name", objr.Name);
                cmd.Parameters.AddWithValue("@age", objr.Age);
                cmd.Parameters.AddWithValue("@country", objr.Country);
                cmd.Parameters.AddWithValue("@state", objr.State);
                cmd.Parameters.AddWithValue("@city", objr.City);
                cmd.Parameters.AddWithValue("@phonenumber", objr.PhoneNumber);
                cmd.Parameters.AddWithValue("@email", objr.Email);
                cmd.Parameters.AddWithValue("@gender", objr.Gender);
                cmd.Parameters.AddWithValue("@hobbies", hobbies);
                cmd.ExecuteNonQuery();
                con.Close();

                return View();
            }
        }
    }
   

