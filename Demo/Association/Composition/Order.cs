using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association.Composition
{
    // Association Relationship [Composition]: has a
    //                                       : OrderItems has a Items
    internal class Order
    {
        public int Id { get; set; }
        public /*required*/ string UserEmail { get; set; }
        public decimal SubTotal { get; set; }
        public /*required*/  List<OrderItem> Items { get; set; }
        public Order(string userEmail, List<OrderItem> items)
        {
            UserEmail = userEmail;
            Items = items;
        }
    }
}
