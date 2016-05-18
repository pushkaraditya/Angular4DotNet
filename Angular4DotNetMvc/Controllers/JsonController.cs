using System;
using System.Net;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMvc.Controllers
{
  public class JsonController : Controller
  {
    protected new ActionResult Json(object data, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
    {
      var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

      if (Request.RequestType == WebRequestMethods.Http.Get && behavior == JsonRequestBehavior.DenyGet)
        throw new InvalidOperationException("GET operation is not permitted for this request");

      var jsonResult = new ContentResult
      {
        Content = JsonConvert.SerializeObject(data, settings),
        ContentType = "application/json"
      };
      return jsonResult;
    }
  }
}