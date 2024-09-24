using Microsoft.AspNetCore.Mvc;
using Mvcmovie.Models;
using System.Text.Encodings.Web;

// {
//     public class PersonController : Controller
//     { 
//         // GET: /HelloWorld/
//         public IActionResult IndexPerson()
//         {
//             return View();
//         }
//         public string WelcomePerson()
//         {
//             return "Person test welcome";
//         }
//     }
// }
namespace Mvcmovie.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string str0utput = "Xin chao " + ps.PersonId + "-" +ps.FullName +"-" + ps.Address;
            ViewBag.infoPerson = str0utput;
            return View();
        }
    }
}