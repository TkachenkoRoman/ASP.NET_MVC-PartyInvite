using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        [RegularExpression(".+/@.+/..+", ErrorMessage = "Please enter a valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you`ll attend")]
        public bool? WillAttend { get; set; }
    }
}