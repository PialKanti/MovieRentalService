using MovieRentalService.Models;
using MovieRentalService.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalService.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            CustomersViewModel viewModel = new CustomersViewModel
            {
                Customers = GetCustomers()
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            Customer customer = GetCustomers().FirstOrDefault(c => c.Id == id);
            return View(customer);
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "John Smith"},
                new Customer{Id =2, Name="Anna Bell" }
            };
        }
    }
}