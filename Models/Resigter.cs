using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyOwnProject.Models
{
    public class Resigter
    {
        [Required(ErrorMessage = "username must be entered")]
        public string Hoten { get; set; }
        [Required(ErrorMessage = "email address must be entered")]
        public string Email { get; set; }
        [Required(ErrorMessage = "mobile number must be entered")]
        public int mobile { get; set; }
        [Required(ErrorMessage = "date month and year must be entered")]
        public DateTime dob { get; set; }
        [Required(ErrorMessage = "city must be entered")]
        public string city { get; set; }
        [Required(ErrorMessage = "country must be entered")]
        public string country { get; set; }
    }
}
