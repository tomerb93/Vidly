using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>()
        {
            new Customer(id: 1, name: "Tomer"),
            new Customer(id: 2, name: "Eynat")
        };
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new IndexCustomerViewModel()
            {
                Customers = _customers
            };

            return View(viewModel);
        }
        
        [Route("customers/details/{customerId}")]
        public ActionResult Details(int? customerId)
        {
            if (customerId == null)
            {
                return HttpNotFound();
            }

            var customer = _customers.SingleOrDefault(c => c.Id == customerId);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }
    }
}