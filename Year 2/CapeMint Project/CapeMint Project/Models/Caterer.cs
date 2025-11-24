using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapeMint_Project.Models
{
    public class Caterer
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string Cat_Name { get; set; }
        
        [DisplayName("Surname")]
        [Required]
        public string Cat_LName { get; set; }

        [DisplayName("Email Address")]
        public string Cat_email {  get; set; }

        [DisplayName("Telephone")]
        [Required]
        public string Cat_phone { get; set; }

        public List<MealType> MealServices { get; set; }

    }
}