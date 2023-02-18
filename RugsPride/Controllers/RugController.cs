using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RugsPride.Controllers{
    public class RugController : Controller
    {
        // 
        // GET: /Rug/

        public IActionResult Index()                    //IActionResult is not  a datatype like string
        {
            return View();
        }

        // 
        // GET: /Rug/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
