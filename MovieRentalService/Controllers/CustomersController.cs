using MovieRentalService.Models;
using MovieRentalService.Repositories;
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
        private ICustomerRepository customerRepository;

        public CustomersController()
        {
            this.customerRepository = new CustomerRepository(new ApplicationDBContext());
        }

        public CustomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        // GET: Customers
        public ActionResult Index()
        {
            CustomersViewModel viewModel = new CustomersViewModel
            {
                Customers = customerRepository.GetCustomers()
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            Customer customer = customerRepository.GetCustomerById(id);

            if(customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        public ActionResult New()
        {
            CustomerFormViewModel viewModel = new CustomerFormViewModel
            {
                MembershipTypes = customerRepository.GetMembershipTypes()
            };
            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.Id == 0)
            {
                customerRepository.Add(customer);
                return RedirectToAction("Index", "Customers");
            }
            else
            {
                Customer existingCustomer = customerRepository.Update(customer);
                return RedirectToAction("Details", "Customers", new { Id = existingCustomer.Id });
            }
        }

        public ActionResult Edit(int id)
        {
            CustomerFormViewModel viewModel = new CustomerFormViewModel
            {
                Customer = customerRepository.GetCustomerById(id),
                MembershipTypes = customerRepository.GetMembershipTypes()
            };
            return View("CustomerForm", viewModel);
        }
    }
}