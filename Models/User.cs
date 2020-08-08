using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PNTS.Models
{
    public class User
    {
        public int ID { get; set; }
        
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        
        public string FirstMidName { get; set; }
        public virtual ICollection<Register> Registrations { get; set; }
    }
}