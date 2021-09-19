using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalService.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DateTime? BirthDate { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
    }
}