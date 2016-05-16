using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
  public class HelloController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}