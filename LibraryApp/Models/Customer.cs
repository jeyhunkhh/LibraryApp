using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
        
    }
}
