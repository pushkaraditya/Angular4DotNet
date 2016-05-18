using System.Web.Http;
using Angular4DotNetMvc.Models.Courses;
using Angular4DotNetMvc.Models.Registration;

namespace Angular4DotNetMvc.Controllers
{
  public class CoursesController : ApiController
  {
    public CourseVm[] Get()
    {
      return new RegistrationVmBuilder().GetCourseVms();
    }
  }
}