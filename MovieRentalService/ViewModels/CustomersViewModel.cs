﻿using MovieRentalService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalService.ViewModels
{
    public class CustomersViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
    }
}