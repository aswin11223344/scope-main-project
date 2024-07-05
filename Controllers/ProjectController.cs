using Microsoft.AspNetCore.Mvc;
using project_ScopeIndia.Models;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using System.Diagnostics;
using MailKit.Net.Smtp;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Tls;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;


namespace project_ScopeIndia.Controllers
{
	public class ProjectController : Controller
	{
		public IActionResult home()
		{
			return View();
		}


	}
}
