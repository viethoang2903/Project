using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Student
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public decimal Gpa { get; set; }
    }
}
