using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace PNTS.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string DeliveryMethod { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public virtual ICollection<Register> Registrations { get; set; }
    }
}