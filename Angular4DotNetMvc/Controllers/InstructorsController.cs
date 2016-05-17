using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class InstructorsController : Controller
  {
    public ActionResult Index()
    {
      return View("Index", "", new RegistrationVmBuilder().GetSerializedInstrcutors());
    }
  }
}