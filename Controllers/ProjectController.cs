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
		
		public IActionResult Contact()
		{
			return View();	
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Contact(Contactas obj)
		{
	
			var email = new MimeMessage();
			email.From.Add(MailboxAddress.Parse("bibinrajbibinrajbibinraj@gmail.com"));
			email.To.Add(MailboxAddress.Parse("aswindaswind2003@gmail.com"));

			string htmlbody= @$" <h1>Contact Form Submission</h1><h5> Name: { obj.Name}</h5><h5> Email: { obj.Email}</h5><h5> Subject: { obj.Subject}</h5><h5> Message: { obj.Msg}</h5>";
			email.Body=new TextPart(TextFormat.Html){Text=htmlbody};
			 var smtp=new SmtpClient();
			smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
			smtp.Authenticate("bibinrajbibinrajbibinraj@gmail.com", "eyyq dlji odwf dnzh");
			smtp.Send(email);
			smtp.Disconnect(true);
			ViewBag.message = "message sented successfully";



            return View();
		}
        public IActionResult Reg()
        {

            return View();
        }

    }
}
