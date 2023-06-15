using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class Order
    {
        public Order()
        {
            OrderDate = DateTime.Now;
            OrderNumber = Guid.NewGuid().ToString();
        }
        public Customer Customer { get; set; }
        public List<Menu> Items { get; set; }
        public decimal TotalAmount 
        {
            get { return GetTotalAmount(); }
        }
        public string OrderNumber { get; private set; }
        private DateTime OrderDate { get; set; }

        private decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
                
                              
            }
            return total;
        }
    }
}
