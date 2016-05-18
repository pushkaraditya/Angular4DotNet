using System.Web.Http;
using Angular4DotNetMvc.Models.Instructors;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class InstructorsController : ApiController
  {
    public InstructorVm[] Get()
    {
      System.Threading.Thread.Sleep(5000);
      return new RegistrationVmBuilder().GetInstrcutorVms();
    }
  }
}