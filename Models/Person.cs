using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyOwnProject.Models
{
    public class Person
    {
        [Display(Name = "Ho ten")]
        
        [RegularExpression(@"^[A-Za-z\s]{1,1000}$", ErrorMessage = "text only")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "username must be entered")]
        public string Hoten { get; set; }

        [Display(Name = "Email")]
       
        [DataType(DataType.EmailAddress, ErrorMessage = "Please input a valid email address")]
        [Required(ErrorMessage = "email address must be entered")]
        public string email { get; set; }

        [Display(Name = "Dien thoai")]
        [Required(ErrorMessage = "mobile number must be entered")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Not a proper phone number")]
        public int mobile { get; set; }

        [Display(Name = "Ngay Sinh")]
        [Required(ErrorMessage = "date month and year must be entered")]
        [DataType(DataType.Date, ErrorMessage = "Use proper date time")]
        public DateTime dob { get; set; }

        [Display(Name = "Thanh pho ")]
        [Required(ErrorMessage = "city must be entered")]
        [RegularExpression(@"^[A-Za-z\s]{1,1000}$", ErrorMessage = "text only")]
        [DataType(DataType.Text)]
        public string city { get; set; }

        [Display(Name = "Quoc gia")]
        [Required(ErrorMessage = "country must be entered")]
        [RegularExpression(@"^[A-Za-z\s]{1,1000}$", ErrorMessage = "text only")]
        [DataType(DataType.Text)]
        public string country { get; set; }
    }
}
