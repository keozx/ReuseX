using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public enum Status
    {
        Paid,
        Received
    }

    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        
        public int CustomerId { get; set; }

        
        public int ProductId { get; set; }

        
        public int IdRestaurant { get; set; }

        
        public int Quantity { get; set; }

        
        public decimal UnitPrice { get; set; }

        
        public virtual Status ? IdStatus { get; set; }

        public virtual Customer Customer { get; set; }        

        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

}
