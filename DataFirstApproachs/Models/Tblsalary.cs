using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirstApproachs.Models
{
    public partial class Tblsalary
    {
        public string Id { get; set; }
        public double? Basic { get; set; }
        public double? Hra { get; set; }
        public double? Da { get; set; }
        public double? Deduction { get; set; }
    }
}
