using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class CoursesController : Controller
  {
    public ActionResult Index()
    {
      return View("Index", "", new RegistrationVmBuilder().GetSerializedCourseVms());
    }
  }
}