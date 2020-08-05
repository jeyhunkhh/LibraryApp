using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal WeekPrice { get; set; }
        public string Author{ get; set; }
        public int Count { get; set; }
        
    }
}
