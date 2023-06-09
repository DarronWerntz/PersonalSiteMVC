using System.ComponentModel.DataAnnotations;

namespace PersonalSiteMVC.Models
{
    public class ContactViewModel
    {
        //We can use data annotations to add validation to our model.
        //This is useful when we have required fields, or we want to enforce certain types of information.

        [Required(ErrorMessage = "* Required")]//Marks an item as "required." Useful for non-nullable database fields.
        public string? Name { get; set; }

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.EmailAddress)] //Certain formatting is expected (@ symbol, .com, etc)
        public string? Email { get; set; }

        [Required(ErrorMessage = "* Required")]
        public string? Subject { get; set; }

        [Required(ErrorMessage = "* Required")]
        [DataType(DataType.MultilineText)] //Makes the textbox for this field bigger.
        public string? Message { get; set; }
    }
}
