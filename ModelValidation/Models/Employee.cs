using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ModelValidation.Models;

namespace ModelValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "pls Enter ID")]
        [DisplayName("Employee ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Pls ENter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be")]
        public int Name { get; set; }
        [EmailAddress(ErrorMessage = "Invlaid EMail ID")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="INvalid mobile no")]
        public string mobile { get; set; }
        [Required(ErrorMessage = "UserNAme is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Required(ErrorMessage = "Password Mismatch")]
        public string Cpwd { get; set; }
    }
}
