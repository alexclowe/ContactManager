using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
    public class USState
    {
        [Key]
        public int StateID { get; set; }

        [Display(Name = "State")]
        [MaxLengthAttribute(50)]
        public string StateName { get; set; }

        [Display(Name = "Abbreviation")]
        [MaxLengthAttribute(2)]
        public string StateAbbreviation { get; set; }

        public int ContactID { get; set; }
        [InverseProperty("ContactID")]
        public Contact Contact { get; set; }
    }
}