using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAssesment.Models
{
    public class Shipment
    {
        [Key]
        public int ShipmentId { get; set; }
        public DateTime ShipmentDate { get; set; }
        

        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
