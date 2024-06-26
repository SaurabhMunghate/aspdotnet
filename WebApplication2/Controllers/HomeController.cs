using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        // private readonly IEmailSender emailSender;
 
        // public HomeController(IEmailSender emailSender)
        // {
        //     this.emailSender = emailSender;
        // }
    
        // [HttpPost]
        // public async Task<IActionResult> Index(string email, string subject, string message)
        // {
        //     await emailSender.SendEmailAsync(email, subject, message);
        //     return View();
        // }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Students()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
