using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAssesment.Models
{
    public class Order
    {
        [Key]
        public int? OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        

        public int? UserId { get; set; }
        public User? User { get; set; }

        public ICollection<Product>? Products { get; set; }
        public Shipment? Shipment { get; set; }
        public Payment? Payment { get; set; }
    }
}
