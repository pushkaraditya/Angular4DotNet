using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular4DotNetMvc.Controllers
{
  public class AccountController : ApiController
  {
    public HttpResponseMessage Post(HttpRequestMessage request, StudentVm student)
    {
      if (student != null && ModelState.IsValid)
      {
        // Save student
        return new HttpResponseMessage(HttpStatusCode.OK);
      }

      return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessages());
    }

    private IEnumerable<string> GetErrorMessages()
    {
      return ModelState.Values.SelectMany(x => x.Errors.Select(e => e.ErrorMessage));
    }
  }
}