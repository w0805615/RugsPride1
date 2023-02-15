using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RugsPride.Controllers{
    public class RugController : Controller
    {
        // 
        // GET: /Rug/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Rug/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
