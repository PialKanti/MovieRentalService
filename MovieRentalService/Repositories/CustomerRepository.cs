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
            return context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
        }

        public IEnumerable<MembershipType> GetMembershipTypes()
        {
            return context.MembershipTypes.ToList();
        }

        public Customer Add(Customer customer)
        {
            Customer newCustomer = context.Customers.Add(customer);
            context.SaveChanges();
            return newCustomer;
        }

        public Customer Update(Customer customer)
        {
            Customer customerInDB = context.Customers.Single(c => c.Id == customer.Id);

            customerInDB.Name = customer.Name;
            customerInDB.BirthDate = customer.BirthDate;
            customerInDB.MembershipTypeId = customer.MembershipTypeId;
            customerInDB.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            context.SaveChanges();
            return customerInDB;
        }
    }
}