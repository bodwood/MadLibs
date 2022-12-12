using Microsoft.AspNetCore.Mvc; //imports functionality from ASP.NET Core MVC package
//using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller  //class HomeController with Controller to inherit functionality from ASP.NET Core Controller class
  {
    [Route("/")]
    public ActionResult Output()  {return View();} //ActionResult references Output.cshtml. Returns the View of that Output.cshtml
  }
}