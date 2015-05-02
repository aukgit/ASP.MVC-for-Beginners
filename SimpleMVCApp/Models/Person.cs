using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleMVCApp.Models {
    public class Person {
        //[Key]
        public int PersonID { get; set; }
        [StringLength(40)]
        [Required]
        //[Display(Name = "First name")]
        [DisplayName("First name from display name")]

        public string FirstName { get; set; }
        [StringLength(40)]
        [Required]

        public string   LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}