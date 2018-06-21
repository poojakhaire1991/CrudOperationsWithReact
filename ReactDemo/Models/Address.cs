using System;
using System.Collections.Generic;

namespace ReactDemo.Models
{
    public partial class Address
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
