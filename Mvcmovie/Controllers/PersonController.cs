using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class Person : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult Personindex()
        {
            return View();
        }
        public string WelcomePerson()
        {
            return "Person test welcome";
        }
    }
}