using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /HelloWorld/
        public string IndexPerson()
        {
            return "Person test 123";
        }
        public string WelcomePerson()
        {
            return "Person test welcome";
        }
    }
}