using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirstApproachs.Models
{
    public partial class Tblanotheremployee
    {
        public int? Empid { get; set; }
        public string Empname { get; set; }

        public virtual Tblempl Emp { get; set; }
    }
}
