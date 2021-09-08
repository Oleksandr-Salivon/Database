using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirstApproachs.Models
{
    public partial class Empsal
    {
        public int? Empid { get; set; }
        public string Salid { get; set; }
        public DateTime? Saldate { get; set; }
        public double? Totalsal { get; set; }

        public virtual Tblempl Emp { get; set; }
        public virtual Tblsalary Sal { get; set; }
    }
}
