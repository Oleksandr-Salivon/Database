using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirstApproachs.Models
{
    public partial class Salary
    {
        public int SalId { get; set; }
        public int Basic { get; set; }
        public int Hra { get; set; }
        public int Da { get; set; }
        public int Deduction { get; set; }
    }
}
