using System.ComponentModel.DataAnnotations;
namespace CustomValidations.Models;

public class MyForm
{
    [Required]
    public string? Name {get;set;}
    public string? DiscountCode {get;set;}

}

