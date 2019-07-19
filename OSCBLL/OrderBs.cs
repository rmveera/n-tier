using System;
using OSCBOL;
using OSCDAL;
using System.Linq;
using System.Collections.Generic;

namespace OSCBLL
{
    public class OrderBs
    {
        OrderDb orderDb;
        public OrderBs() {
            orderDb = new OrderDb();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return orderDb.GetAllOrders(); ;
        }
        public Order GetOrderById(int Id)
        {
            return orderDb.GetOrderById(Id);
        }
        public void AddOrder(Order order)
        {
            if (order != null)
                orderDb.AddOrder(order);
        }
        public void DeleteOrder(Order order)
        {
            if (order != null)
                orderDb.DeleteOrder(order);
        }
        public void UpdateOrder(Order order)
        {
            if (order != null){
                orderDb.UpdateOrder(order);
            }
        }
        public void Save() {
            orderDb.Save();
        }
    }
}
