using System.Net;
using System.Web.Mvc;

namespace Angular4DotNetMvc.Controllers
{
  public class AccountController : Controller
  {
    [HttpPost]
    public ActionResult Save(StudentVm student)
    {
      // Save student
      return new HttpStatusCodeResult(HttpStatusCode.OK);
    }
  }
}