using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Deadline { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReturnDate { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal OrderPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? FinePrice { get; set; }
        [Required]
        public bool Status  { get; set; }
        public IList<OrderItem> OrderItems { get; set; }

    }
}
