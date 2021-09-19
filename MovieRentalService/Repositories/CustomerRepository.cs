using MovieRentalService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieRentalService.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private ApplicationDBContext context;

        public CustomerRepository(ApplicationDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.Include(c => c.MembershipType).ToList();
        }

        public Customer GetCustomerById(int id)
        {
            return context.Customers.Find(id);
        }        
    }
}