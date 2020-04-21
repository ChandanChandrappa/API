using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using NPoco;

namespace NPocoApp
{
    public class CustomerRepository : ICustomerRepository
    {
        IDatabase connection = new Database(@"Data Source=.;Initial Catalog=DbCustomers;Integrated Security=True;", DatabaseType.SqlServer2012, SqlClientFactory.Instance);
        public void AddCustomer(Customer customer)
        {
            connection.Insert<Customer>(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            connection.Delete<Customer>(customerId);
        }

        public IList<Customer> GetAllCustomers()
        {
            string query = "SELECT * FROM Customers";
            IList<Customer> customerList = connection.Fetch<Customer>(query);
            return customerList;
        }

        public Customer GetCustomerbyId(int customerId)
        {
            Customer customer = connection.SingleById<Customer>(customerId);
            return customer;
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            customer.CustomerId = id;
            connection.Update(customer);
        }
    }
}
