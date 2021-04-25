using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/finalstory")]
        public ActionResult FinalStory(string person1, string person2, string animal, string verb, string noun, string exclamation)
        {
            UserInputs myUserInputs = new UserInputs();
            myUserInputs.Person1 = person1;
            myUserInputs.Person2 = person2;
            myUserInputs.Animal = animal;
            myUserInputs.Noun = noun;
            myUserInputs.Verb = verb;
            myUserInputs.Exclamation = exclamation;
            return View(myUserInputs);
        }

        [Route("/")]
        public ActionResult MadLibsForm() { return View(); }
    }
}