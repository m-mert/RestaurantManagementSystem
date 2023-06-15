using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Restaurant
    {
        public List<Menu> MenuItems { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }

        public Restaurant() 
        {
            MenuItems = new List<Menu>();
            Orders = new List<Order>();
            Customers = new List<Customer>();
        }
        public void AddMenuItem(Menu item)
        {
            MenuItems.Add(item);
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public decimal MakePaymenr(string orderNumber)
        {
            Order order = Orders.Where(x=>x.OrderNumber == orderNumber).FirstOrDefault();
        return order.TotalAmount;
        }

    }
}
