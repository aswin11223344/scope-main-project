using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using project_ScopeIndia.model;
using project_ScopeIndia.Models;

namespace project_ScopeIndia.Controllers
{
    public class RegController : Controller
    {
        public readonly Mydbcontext Mydbcontext;
        public RegController(Mydbcontext mydbcontext)
        {
            Mydbcontext = mydbcontext;
         
          
        }

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
            var table = new ScopeTable
            {
                Id = Guid.NewGuid(),
                Name = objr.Name,
                Age = objr.Age,
                Country = objr.Country,
                State = objr.State,
                City = objr.City,
                PhoneNumber = objr.PhoneNumber,
                Email = objr.Email,
                Gender = objr.Gender,
                Hobbies = hobbies




            };
            Mydbcontext.ScopeTables.Add(table);
            Mydbcontext.SaveChanges();

             
                return View();
            }
        }
    }
   

