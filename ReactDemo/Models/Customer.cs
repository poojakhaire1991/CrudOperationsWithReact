using System;
using System.Collections.Generic;

namespace ReactDemo.Models
{
    public partial class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhNo { get; set; }
    }
}
