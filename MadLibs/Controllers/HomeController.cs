using Microsoft.AspNetCore.Mvc; //imports functionality from ASP.NET Core MVC package
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller  //class HomeController with Controller to inherit functionality from ASP.NET Core Controller class
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/output")]
    public ActionResult Output(string noun, string name, string pronoun, string itemchoice, string animal, string animalname, string color, string flavor, string housename, string classname, string whybestclass)
    {

      BuildClass newBuildClass = new BuildClass();
      newBuildClass.Noun = noun;
      newBuildClass.Name = name;
      newBuildClass.Pronoun = pronoun;
      newBuildClass.ItemChoice = itemchoice;
      newBuildClass.Animal = animal;
      newBuildClass.AnimalName = animalname;
      newBuildClass.Color = color;
      newBuildClass.Flavor = flavor;
      newBuildClass.HouseName = housename;
      newBuildClass.ClassName = classname;
      newBuildClass.WhyBestClass = whybestclass;
      return View(newBuildClass);
    } //ActionResult handles redering views. This one references Output.cshtml. Returns the View of that Output.cshtml
  }
}