using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NPocoApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository = new CustomerRepository();

        public IList<Customer> GetCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }

        [HttpGet("{id}")]
        public Customer GetCustomerById(int id)
        {
            return _customerRepository.GetCustomerbyId(id);
        }

        [HttpPost]
        public void AddCustomer([FromBody]Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        [HttpPut("{id}")]
        public void UpdateCustomer(int id, [FromBody]Customer customer)
        {
            _customerRepository.UpdateCustomer(id, customer);
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            _customerRepository.DeleteCustomer(id);
        }
    }
}