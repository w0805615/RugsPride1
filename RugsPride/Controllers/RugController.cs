using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RugsPride.Controllers{
    public class RugController : Controller
    {
        // 
        // GET: /Rug/

        public IActionResult Index()
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
