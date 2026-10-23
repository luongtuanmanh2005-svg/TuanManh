using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LuongTuanManh.Controllers
{
    public class HelloController1 : Controller
    {
        public string Index()
        {
            return "Hello, World!";
        }

        public string Welcome(string name, int numTime = 1)
        {
            return HtmlEncoder.Default.Encode(
                $"Hello {name}, NumTime is: {numTime}"
            );
        }
    }
}
