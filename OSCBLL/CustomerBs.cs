using System;
using OSCBOL;
using OSCDAL;
using System.Linq;
using System.Collections.Generic;

namespace OSCBLL
{
    public class CustomerBs
    {
        CustomerDb customerDb;
        public CustomerBs()
        {
            customerDb = new CustomerDb();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerDb.GetAllCustomers(); ;
        }
        public Customer GetCustomerById(int Id)
        {
            return customerDb.GetCustomerById(Id);
        }
        public void AddCustomer(Customer customer)
        {
            if (customer != null)
                customerDb.AddCustomer(customer);
        }
        public void DeleteCustomer(Customer customer)
        {
            if (customer != null)
                customerDb.DeleteCustomer(customer);
        }
        public void UpdateCustomer(Customer customer)
        {
            if (customer != null){
                customerDb.UpdateCustomer(customer);
            }
        }
        public void Save() {
            customerDb.Save();
        }
    }
}
