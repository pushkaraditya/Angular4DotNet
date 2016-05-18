using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class CoursesController : JsonController
  {
    public ActionResult Index()
    {
      return Json(new RegistrationVmBuilder().GetCourseVms(), JsonRequestBehavior.AllowGet);
    }
  }
}