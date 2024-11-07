using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace info.Models
{
    public class Info
    {
        [Required(ErrorMessage = "Please provide your name.")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide your ID.")]
        [RegularExpression(@"^\d{2}-\d{5}-\d{1}$", ErrorMessage = "ID must follow the format xx-xxxxx-x.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Please provide your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please provide your phone number.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Phone number must be exactly 11 digits.")]
        public string Phone { get; set; }


    }
}