using OSCBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSCDAL
{
    public class OrderDb : BaseRepositoryDb
    {
        public IEnumerable<Order> GetAllOrders()
        {
            IEnumerable<Order> orders = oscDbContext.Orders.ToList();
            return orders;
        }
        public Order GetOrderById(int Id)
        {
            Order order = oscDbContext.Find<Order>(Id) ?? null;
            return order;
        }
        public void AddOrder(Order order)
        {
            if (order != null) {
                oscDbContext.Add<Order>(order);
            }
        }
        public void DeleteOrder(Order order)
        {
           if (order != null) {
                oscDbContext.Remove<Order>(order);
            }
        }
        public void UpdateOrder(Order order)
        {
            if (order != null) {
                oscDbContext.Update<Order>(order);
            }
        }
    }
}
