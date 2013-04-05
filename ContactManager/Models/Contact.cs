using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email Address")]
        [MaxLengthAttribute(50)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone Number")]
        [MaxLengthAttribute(12)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address")]
        [MaxLengthAttribute(50)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [MaxLengthAttribute(50)]
        public string City { get; set; }

        public int StateID { get; set; }

        [UIHint("StatePicker")]
        [ForeignKey("StateID")]
        public virtual USState State { get; set; }
    } 
}