//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentbuddy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ContactU
    {
        public int ContactUS_ID { get; set; }

        [Required(ErrorMessage = "Please enter your full name")]
        [Display(Name = "Full name")]
        public string ContactUS_Name { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        [DataType(DataType.PhoneNumber)]
        public int ContactUS_PhoneNo { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address!")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string ContactUS_Email { get; set; }

        [Required(ErrorMessage = "Please enter your message!")]
        [Display(Name = "Message")]
        [DataType(DataType.Text)]
        public string ContactUS_Message { get; set; }
    }
}