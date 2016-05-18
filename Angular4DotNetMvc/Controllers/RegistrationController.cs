using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class RegistrationController : Controller
  {
    public ActionResult Index()
    {
      //var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
      //return JsonConvert.SerializeObject(courses, settings);

      return View("Index");
    }
  }
}