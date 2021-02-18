using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excercise.Models;

namespace Excercise.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new Customer() { Name = "Sherk!" };
            return View(customer);
        }
    }
}