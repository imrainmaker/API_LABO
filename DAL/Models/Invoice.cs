using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        
        
        
    }
}
