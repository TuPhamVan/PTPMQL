using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class Person : Controller
    { 
        // GET: /HelloWorld/
        public string IndexPerson()
        {
            return "Person test Index123";
        }
        public string WelcomePerson()
        {
            return "Person test welcome";
        }
    }
}