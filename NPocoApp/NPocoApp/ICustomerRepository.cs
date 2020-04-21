using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPocoApp
{
    public interface ICustomerRepository
    {
        IList<Customer> GetAllCustomers();
        Customer GetCustomerbyId(int customerId);
        void AddCustomer(Customer customer);
        void UpdateCustomer(int id,Customer customer);
        void DeleteCustomer(int customerId);
    }
}
