using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        public ICollection<Order> Orders { get; set; }
        
    }
}
