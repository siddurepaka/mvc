using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HtmlHelpers.Models
{
    public class User
    {
        [Required(ErrorMessage ="please provide name")]
        
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please provide email")]
       
        [EmailAddress(ErrorMessage = "Invlaid EMail ID")]

        public string Email { get; set; }
        [Required(ErrorMessage ="Please provide DOB")]
       
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Please provide mobile no")]

        
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "INvalid mobile no")]
        public string Mobileno { get; set; }
        [Required(ErrorMessage = "please provide country")]
       

        public string Country { get; set; }
        [Required(ErrorMessage = "UserNAme is required")]
        
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is required")]
      
        [RegularExpression("[a-z0-9]{6,8}")]
        public string password { get; set; }


    }
}
