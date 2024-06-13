using Microsoft.AspNetCore.Mvc;
using project_ScopeIndia.Models;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using System.Diagnostics;
using MailKit.Net.Smtp;


namespace project_ScopeIndia.Controllers
{
	public class ProjectController : Controller
	{
		public IActionResult home()
		{
			return View();
		}
		public IActionResult Reg()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();	
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Contact(Contactas obj)
		{
			ViewBag.name= obj.Name;
			ViewBag.email = obj.Email;
			ViewBag.subject = obj.Subject;
			ViewBag.msg = obj.Msg;
			var email = new MimeMessage();
			email.From.Add(MailboxAddress.Parse("bibinrajbibinrajbibinraj@gmail.com"));
			email.To.Add(MailboxAddress.Parse("aswindaswind2003@gmail.com"));

			string htmlbody= @" <h1>Contact Form Submission</h1>< h1> Name: { obj.Name}</ h1 >< h1 > Email: { obj.Email}</ h1 >< p > Subject: { obj.Subject}</ p >< p > Message: { obj.Msg}</ p ></body></html> ";
			email.Body=new TextPart(TextFormat.Html){Text=htmlbody};
			 var smtp=new SmtpClient();
			smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
			smtp.Authenticate("bibinrajbibinrajbibinraj@gmail.com", "eyyq dlji odwf dnzh");
			smtp.Send(email);
			smtp.Disconnect(true);
			ViewBag.message = "message sented successfully";



            return View();
		}
      
    }
}
