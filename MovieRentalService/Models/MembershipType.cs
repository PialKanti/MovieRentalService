using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalService.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SignUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public double DiscountRate { get; set; }
    }
}