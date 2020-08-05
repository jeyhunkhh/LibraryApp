using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime Deadline { get; set; }
        public List<Book> Books { get; set; }
        public decimal OrderPrice { get; set; } = 0;

    }
}
