using System.Web.Mvc;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class InstructorsController : JsonController
  {
    public ActionResult Index()
    {
      return Json(new RegistrationVmBuilder().GetInstrcutorVms(), JsonRequestBehavior.AllowGet);
    }
  }
}