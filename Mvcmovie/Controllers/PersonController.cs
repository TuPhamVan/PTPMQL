using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class Person : Controller
    { 
        // GET: /HelloWorld/
       public IActionResult Index() {
        return View();
       }
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "Person test welcome";
        }
    }
}