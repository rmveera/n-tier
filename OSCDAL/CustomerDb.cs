using OSCBOL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OSCDAL
{
    public class CustomerDb : BaseRepositoryDb
    {
        public IEnumerable<Customer> GetAllCustomers(){
            IEnumerable<Customer> customers = oscDbContext.Customers.ToList();
            return customers;
        }
        public Customer GetCustomerById(int Id) {
            Customer customer = oscDbContext.Find<Customer>(Id) ?? null;       
            return customer;
        }
        public void AddCustomer(Customer customer) {
            if (customer != null) {
                oscDbContext.Add<Customer>(customer);
            }
        }
        public void DeleteCustomer(Customer customer) {
            if (customer != null) {
                oscDbContext.Remove<Customer>(customer);
            }
        }
        public void UpdateCustomer(Customer customer) {
            if (customer != null) {
                oscDbContext.Update<Customer>(customer);
            }
        }
    }
}
