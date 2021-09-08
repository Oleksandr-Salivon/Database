using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirstApproachs.Models
{
    public partial class Employeesalary
    {
        public int EmpId { get; set; }
        public int SalId { get; set; }
        public int Extra { get; set; }
        public DateTime SalDate { get; set; }
    }
}
