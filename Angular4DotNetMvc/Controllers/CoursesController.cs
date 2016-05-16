using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
  public class CoursesController : Controller
  {
    public ActionResult Index()
    {
      return View("Index", "", "you");
    }
  }
}