
using System.ComponentModel.DataAnnotations;
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
        public decimal WeekPrice { get; set; }
        [Required]
        [StringLength(50)]
        public string Author{ get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int BookShelf { get; set; }

        public int? OrderId { get; set; }
        public Order Order { get; set; }

    }
}
