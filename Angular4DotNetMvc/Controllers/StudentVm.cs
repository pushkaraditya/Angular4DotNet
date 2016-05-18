using System.ComponentModel.DataAnnotations;

namespace Angular4DotNetMvc.Controllers
{
  public class StudentVm
  {
    [Required(ErrorMessage="Please enter First Name")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Please enter Last Name")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Please enter Email")]
    [RegularExpression(@"^[a-zA-Z0-9'._%+-]+@[a-zA-Z0-9-][a-zA-Z0-9.-]*\.[a-zA-Z]{2,9}$", ErrorMessage="Invalid email address")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Please enter Password")]
    public string Password { get; set; }
  }
}