using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InventoryManegmentSystem3.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string FName { get; set; }
        [MaxLength(25)]
        public string LName { get; set; }
        [MaxLength(25)]
        public string AttName { get; set; }
        public DateOnly Dob { get; set; }
        [MaxLength(7)]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(25)]
        public string Tel { get; set; }
        [MaxLength(30)]
        public string Address { get; set; }
  
        [Required(ErrorMessage = "Password is required")]
        [MaxLength(25)]
        [RegularExpression(@"^([a-zA-Z0-9@*#]{8,15})$", ErrorMessage = "Password must contain: Minimum 8 characters, at least 1 UpperCase Alphabet, 1 LowerCase Alphabet, 1 Number, and 1 Special Character")]
        public string Password { get; set; }
        [MaxLength(25)]
        public string UserLevel { get; set; }
        public DateOnly UDate { get; set; }
    }
    
}
