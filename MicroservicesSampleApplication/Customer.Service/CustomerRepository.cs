using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Service
{
    class CustomerRepository : GenericRepository<CustomerModel, Customer>, ICustomerRepository
    {
        CustomerModel model;
        public CustomerRepository()
        {
            model = new CustomerModel();
        }
        public List<Customer> GetCustomers()
        {
            var data = GetAll();
            var customerList = model.Customers.AsQueryable().ToList();
            return customerList;
        }

        public Customer GetId(string id)
        {
            var data = model.Customers.FirstOrDefault(x => x.CustomerID == id);
            return data;
        }
    }
}
