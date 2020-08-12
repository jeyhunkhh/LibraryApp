
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal WeekPrice { get; set; }
        [Required]
        [StringLength(50)]
        public string Author{ get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int BookShelf { get; set; }

        public IList<OrderItem> OrderItems { get; set; }

    }
}
