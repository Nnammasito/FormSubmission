#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;
public class User
{
    [Display(Name ="First Name")]
    [Required]
    [MinLength(4, ErrorMessage ="First Name must be a minimum of 4 characters")]
    public string FirstName {get;set;}

    [Display(Name = "Last Name")]
    [Required]
    [MinLength(4, ErrorMessage = "Last Name must be a minimun of 4 charcters")]
    public string LastName {get;set;}

    [Display(Name = "Email Address")]
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Range(0, int.MaxValue)]
    public int Age { get; set; }

    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Field must be 8 characters or more")]
    public string Password { get; set; }
}