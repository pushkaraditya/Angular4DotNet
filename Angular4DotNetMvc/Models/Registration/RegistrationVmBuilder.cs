using Angular4DotNetMvc.Models.Courses;
using Angular4DotNetMvc.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNetMvc.Models.Registration
{
  public class RegistrationVmBuilder
  {
    public string GetSerializedCourseVms()
    {
      var courses = new[] {
      new CourseVm { Number = "CREA101", Name = "Care of Magical Creatures", Instructor = "Rubeus Hagrid" },
      new CourseVm { Number = "DARK501", Name = "Defense Against the Dark Arts", Instructor = "Severus Snape" },
      new CourseVm { Number = "TRAN201", Name = "Transfiguration", Instructor = "Minerva McGonagall" }
      };
      var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
      return JsonConvert.SerializeObject(courses, settings);
    }

    public string GetSerializedInstrcutors()
    {
      var instructors = new[] {
        new InstructorVm{ Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001 },
        new InstructorVm{ Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105 },
        new InstructorVm{ Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102 }
      };

      var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
      return JsonConvert.SerializeObject(instructors, settings);
    }

    public RegistrationVm BuildRegistrationVm()
    {
      return new RegistrationVm
      {
        Courses = GetSerializedCourseVms(),
        Instructors = GetSerializedInstrcutors()
      };
    }
  }
}