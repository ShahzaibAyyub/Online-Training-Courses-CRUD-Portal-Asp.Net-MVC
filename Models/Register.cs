using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PNTS.Models
{
    public class Register
    {
        public int RegisterID { get; set; }
        public int CourseID { get; set; }
        public int UserID { get; set; }
        public virtual Course Course { get; set; }
        public virtual User Users { get; set; }
    }
}