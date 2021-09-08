using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirstApproachs.Models
{
    public partial class Cust
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Reffby { get; set; }
    }
}
