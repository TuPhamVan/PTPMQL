using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /HelloWorld/
        public IActionResult IndexPerson()
        {
            return View();
        }
        public string WelcomePerson()
        {
            return "Person test welcome";
        }
    }
}