using DAL.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Invoice
    {
        public Invoice() 
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }

        public User? Buyer { get; set; }

        public Product? Product { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(300)]
        public string DeliveryAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public InvoiceStatus Status { get; set; }

        
        
        
    }
}
